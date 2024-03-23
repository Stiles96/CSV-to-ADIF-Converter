using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_to_ADIF_Converter
{
    public partial class ADIFDefaultFields : Form
    {
        List<KeyValuePair<string, string>> ADIFdefaultFieldsValues;
        public ADIFDefaultFields(List<KeyValuePair<string, string>> ADIFdefaultFieldsValues)
        {
            InitializeComponent();
            GenerateDGV(ADIFdefaultFieldsValues);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ADIFdefaultFieldsValues = new List<KeyValuePair<string, string>>();
            foreach (DataGridViewRow row in dgvADIFFields.Rows)
            {
                if (row.Cells[0].Value != null)
                    ADIFdefaultFieldsValues.Add(new KeyValuePair<string, string>(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()));
            }
            this.Hide();
        }

        public List<KeyValuePair<string, string>> GetADIFDefaultFields()
        {
            return ADIFdefaultFieldsValues;
        }

        void GenerateDGV(List<KeyValuePair<string, string>> ADIFdefaultFieldsValues)
        {
            if (ADIFdefaultFieldsValues != null)
            foreach (KeyValuePair<string, string> defaultField in ADIFdefaultFieldsValues)
            {
                dgvADIFFields.Rows.Add(new string[] { defaultField.Key, defaultField.Value });
            }
        }
    }
}
