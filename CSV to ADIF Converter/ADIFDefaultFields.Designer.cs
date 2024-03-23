namespace CSV_to_ADIF_Converter
{
    partial class ADIFDefaultFields
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADIFDefaultFields));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btSave = new System.Windows.Forms.Button();
            this.dgvADIFFields = new System.Windows.Forms.DataGridView();
            this.Fieldname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADIFFields)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvADIFFields, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(242, 419);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(163, 28);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dgvADIFFields
            // 
            this.dgvADIFFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvADIFFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvADIFFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fieldname,
            this.Value});
            this.dgvADIFFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvADIFFields.Location = new System.Drawing.Point(3, 3);
            this.dgvADIFFields.Name = "dgvADIFFields";
            this.dgvADIFFields.Size = new System.Drawing.Size(402, 410);
            this.dgvADIFFields.TabIndex = 1;
            // 
            // Fieldname
            // 
            this.Fieldname.HeaderText = "Fieldname";
            this.Fieldname.Name = "Fieldname";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // ADIFDefaultFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADIFDefaultFields";
            this.Text = "ADIF Default Fields";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvADIFFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dgvADIFFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fieldname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}