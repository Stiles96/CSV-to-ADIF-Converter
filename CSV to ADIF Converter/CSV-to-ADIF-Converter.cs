using CSV_to_ADIF_Converter_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_to_ADIF_Converter
{
    public partial class CSVADIFConverterGUI : Form
    {
        Logic crtl;
        List<KeyValuePair<string, string>> ADIFdefaultFieldsValues;
        public CSVADIFConverterGUI()
        {
            InitializeComponent();
            crtl = new Logic();
        }

        private void btOpenCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
            openFileDialog.ShowDialog();
            tbCSVFile.Text = openFileDialog.FileName;
            loadCSVColumns();
        }

        void loadCSVColumns()
        {
            lbCSVCol.Items.Clear();
            crtl.LoadCSVFile(tbCSVFile.Text, tbCSVDelimiter.Text == "" ? ' ' : tbCSVDelimiter.Text[0]);
            string[] Columns = crtl.GetCSVHeader();
            if (Columns != null)
                foreach (string Column in Columns)
                {
                    lbCSVCol.Items.Add(Column);
                }
        }

        private void tbCSVDelimiter_Leave(object sender, EventArgs e)
        {
            loadCSVColumns();
        }

        private void tbColumn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddCol();
        }

        void AddCol()
        {
            if (tbColumn.Text != "")
            {
                lbCol.Items.Add(tbColumn.Text);
                tbColumn.Text = "";
                tbColumn.Focus();
            }
        }

        void RemoveCol()
        {
            string selected = (string)lbCol.SelectedItem;
            if (selected != null)
            {
                lbCol.Items.Remove(selected);
            }
        }

        private void btColAdd_Click(object sender, EventArgs e)
        {
            AddCol();
        }

        private void lbCol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                RemoveCol();
        }

        string[,] GetMappings()
        {
            int counter = lbCol.Items.Count;
            if (lbCSVCol.Items.Count < counter)
                counter = lbCSVCol.Items.Count;

            string[,] mapping = new string[counter, 2];
            for (int i = 0; i < counter; i++)
            {
                mapping[i, 0] = lbCol.Items[i].ToString();
                mapping[i, 1] = lbCSVCol.Items[i].ToString();
            }
            return mapping;
        }

        void sort(ListBox lb, bool up)
        {
            if (lb != null && lb.SelectedIndex != -1)
            {
                int index = lb.SelectedIndex;
                if (up && index > 0)
                {
                    string RAM = lb.Items[index - 1].ToString();
                    lb.Items[index - 1] = lb.Items[index];
                    lb.Items[index] = RAM;
                    lb.SelectedIndex = index - 1;
                }
                else if (!up && index < lb.Items.Count - 1)
                {
                    string RAM = lb.Items[index + 1].ToString();
                    lb.Items[index + 1] = lb.Items[index];
                    lb.Items[index] = RAM;
                    lb.SelectedIndex = index + 1;
                }
            }
        }

        private void btColUp_Click(object sender, EventArgs e)
        {
            sort(lbCol, true);
        }

        private void btColDown_Click(object sender, EventArgs e)
        {
            sort(lbCol, false);
        }

        private void btCSVColUp_Click(object sender, EventArgs e)
        {
            sort(lbCSVCol, true);
        }

        private void btCSVColDown_Click(object sender, EventArgs e)
        {
            sort(lbCSVCol, false);
        }

        private void btLoadPreview_Click(object sender, EventArgs e)
        {
            LoadPreview(ADIFdefaultFieldsValues);
        }

        async void LoadPreview(List<KeyValuePair<string, string>> ADIFdefaultFieldsValues)
        {
            var progress = new Progress<int>(v => { toolStripProgressBar1.Value = v; });
            lbStatus.Text = "Loading ...";
            LoadPreviewLog(await Task.Run(() => crtl.ImportCSV(GetMappings(), progress, ADIFdefaultFieldsValues)));
            lbStatus.Text = "Loaded";
        }

        void LoadDGVColumns(List<string> cols, List<string> defaultcols)
        {
            dgvPreview.Columns.Clear();
            foreach (string Column in cols)
                dgvPreview.Columns.Add(Column.Replace(" ", ""), Column);
            foreach (string Column in defaultcols)
                dgvPreview.Columns.Add(Column.Replace(" ", ""), Column);
        }

        /// <summary>
        /// Load Preview in DGV
        /// </summary>
        /// <param name="log">Log to show</param>
        void LoadPreviewLog(Log log)
        {
            dgvPreview.Rows.Clear();
            if (log != null)
                try
                {
                    int Errorcounter = 0;

                    LoadDGVColumns(log.TableHeaders, log.GetDefaultTableHeaders());

                    foreach (QSO qso in log.QSOs)
                    {
                        try
                        {
                            int rowindex = dgvPreview.Rows.Add();
                            DataGridViewRow row = dgvPreview.Rows[rowindex];
                            foreach (KeyValuePair<string, string> field in qso.Fields)
                                row.Cells[field.Key.Replace(" ", "")].Value = field.Value;
                            if (log.DefaultFields != null)
                                foreach (KeyValuePair<string, string> defaultfield in log.DefaultFields)
                                    row.Cells[defaultfield.Key.Replace(" ", "")].Value = defaultfield.Value;
                        }
                        catch
                        {
                            Errorcounter++;
                        }
                    }
                    lbError.Text = "Errors: " + Errorcounter.ToString();
                }
                catch
                {
                    lbError.Text = "Error by loading";
                }
            else
                lbError.Text = "No data";
        }

        private void btSaveADIFCols_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();

            for (int i = 0; i < lbCol.Items.Count; i++)
            {
                lines.Add(lbCol.Items[i].ToString());
            }

            ADIFSettings adifSettings = new ADIFSettings();
            adifSettings.ADIFColumns = lines;
            adifSettings.ADIFDefaults = ADIFdefaultFieldsValues;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.ShowDialog();

            FileAccess.WriteJSONFile(saveFileDialog.FileName, Helper.GetJson(adifSettings));
        }

        private void btLoadADIFCols_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            openFileDialog.ShowDialog();
            ADIFSettings adifSettings = Helper.GetObject<ADIFSettings>(FileAccess.ReadJSONFile(openFileDialog.FileName));

            ADIFdefaultFieldsValues = adifSettings.ADIFDefaults;

            lbCol.Items.Clear();
            foreach (string col in adifSettings.ADIFColumns)
                lbCol.Items.Add(col);
        }

        private void btCreateADIF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ADIF Files|*.adi|All Files|*.*";
            saveFileDialog.ShowDialog();

            SaveLog(saveFileDialog.FileName, ADIFdefaultFieldsValues);
        }

        async void SaveLog(string Path, List<KeyValuePair<string, string>> ADIFdefaultFieldsValues)
        {
            var progress = new Progress<int>(v => { toolStripProgressBar1.Value = v; });
            lbStatus.Text = "Saving ...";
            crtl.SaveADIFFile(await Task.Run(() => crtl.ImportCSV(GetMappings(), progress, ADIFdefaultFieldsValues)), progress, Path);
            lbStatus.Text = "Saved";
        }

        private void btDefaultValues_Click(object sender, EventArgs e)
        {
            ADIFDefaultFields gui = new ADIFDefaultFields(ADIFdefaultFieldsValues);
            gui.ShowDialog();
            ADIFdefaultFieldsValues = gui.GetADIFDefaultFields();
            gui.Close();
        }
    }
}
