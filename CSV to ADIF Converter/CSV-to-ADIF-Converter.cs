using CSV_to_ADIF_Converter_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_to_ADIF_Converter
{
    public partial class CSVADIFConverterGUI : Form
    {
        Logic crtl;
        List<string> columns = new List<string>();
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
                columns.Add(tbColumn.Text);
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
                columns.Remove(selected);
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
    }
}
