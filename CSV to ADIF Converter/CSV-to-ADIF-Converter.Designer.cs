namespace CSV_to_ADIF_Converter
{
    partial class CSVADIFConverterGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSVADIFConverterGUI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btColUp = new System.Windows.Forms.Button();
            this.btColDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btCSVColUp = new System.Windows.Forms.Button();
            this.btCSVColDown = new System.Windows.Forms.Button();
            this.lbCol = new System.Windows.Forms.ListBox();
            this.lbCSVCol = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCSVFile = new System.Windows.Forms.TextBox();
            this.btOpenCSV = new System.Windows.Forms.Button();
            this.tbCSVDelimiter = new System.Windows.Forms.TextBox();
            this.tbCall = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbColumn = new System.Windows.Forms.TextBox();
            this.btColAdd = new System.Windows.Forms.Button();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btLoadADIFCols = new System.Windows.Forms.Button();
            this.btSaveADIFCols = new System.Windows.Forms.Button();
            this.btLoadPreview = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1403, 271);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbCol, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbCSVCol, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(844, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(556, 265);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADIF Columns";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "CSV Columns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvPreview, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1409, 588);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btColUp, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btColDown, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(247, 37);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(28, 225);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btColUp
            // 
            this.btColUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btColUp.Location = new System.Drawing.Point(3, 86);
            this.btColUp.Name = "btColUp";
            this.btColUp.Size = new System.Drawing.Size(22, 23);
            this.btColUp.TabIndex = 0;
            this.btColUp.Text = "▲";
            this.btColUp.UseVisualStyleBackColor = true;
            this.btColUp.Click += new System.EventHandler(this.btColUp_Click);
            // 
            // btColDown
            // 
            this.btColDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btColDown.Location = new System.Drawing.Point(3, 115);
            this.btColDown.Name = "btColDown";
            this.btColDown.Size = new System.Drawing.Size(22, 23);
            this.btColDown.TabIndex = 0;
            this.btColDown.Text = "▼";
            this.btColDown.UseVisualStyleBackColor = true;
            this.btColDown.Click += new System.EventHandler(this.btColDown_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btCSVColUp, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btCSVColDown, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(525, 37);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(28, 225);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btCSVColUp
            // 
            this.btCSVColUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btCSVColUp.Location = new System.Drawing.Point(3, 86);
            this.btCSVColUp.Name = "btCSVColUp";
            this.btCSVColUp.Size = new System.Drawing.Size(22, 23);
            this.btCSVColUp.TabIndex = 0;
            this.btCSVColUp.Text = "▲";
            this.btCSVColUp.UseVisualStyleBackColor = true;
            this.btCSVColUp.Click += new System.EventHandler(this.btCSVColUp_Click);
            // 
            // btCSVColDown
            // 
            this.btCSVColDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCSVColDown.Location = new System.Drawing.Point(3, 115);
            this.btCSVColDown.Name = "btCSVColDown";
            this.btCSVColDown.Size = new System.Drawing.Size(22, 23);
            this.btCSVColDown.TabIndex = 0;
            this.btCSVColDown.Text = "▼";
            this.btCSVColDown.UseVisualStyleBackColor = true;
            this.btCSVColDown.Click += new System.EventHandler(this.btCSVColDown_Click);
            // 
            // lbCol
            // 
            this.lbCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCol.FormattingEnabled = true;
            this.lbCol.Location = new System.Drawing.Point(3, 37);
            this.lbCol.Name = "lbCol";
            this.lbCol.Size = new System.Drawing.Size(238, 225);
            this.lbCol.TabIndex = 2;
            this.lbCol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbCol_KeyDown);
            // 
            // lbCSVCol
            // 
            this.lbCSVCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCSVCol.FormattingEnabled = true;
            this.lbCSVCol.Location = new System.Drawing.Point(281, 37);
            this.lbCSVCol.Name = "lbCSVCol";
            this.lbCSVCol.Size = new System.Drawing.Size(238, 225);
            this.lbCSVCol.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tbCSVFile, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btOpenCSV, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbCSVDelimiter, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tbCall, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.tbColumn, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.btColAdd, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.label7, 1, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 9;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(829, 222);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "CSV File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "CSV Delimiter:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "My Call:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCSVFile
            // 
            this.tbCSVFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCSVFile.Location = new System.Drawing.Point(123, 3);
            this.tbCSVFile.Name = "tbCSVFile";
            this.tbCSVFile.Size = new System.Drawing.Size(623, 20);
            this.tbCSVFile.TabIndex = 1;
            // 
            // btOpenCSV
            // 
            this.btOpenCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOpenCSV.Location = new System.Drawing.Point(752, 3);
            this.btOpenCSV.Name = "btOpenCSV";
            this.btOpenCSV.Size = new System.Drawing.Size(74, 21);
            this.btOpenCSV.TabIndex = 2;
            this.btOpenCSV.Text = "Browse";
            this.btOpenCSV.UseVisualStyleBackColor = true;
            this.btOpenCSV.Click += new System.EventHandler(this.btOpenCSV_Click);
            // 
            // tbCSVDelimiter
            // 
            this.tbCSVDelimiter.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbCSVDelimiter.Location = new System.Drawing.Point(123, 30);
            this.tbCSVDelimiter.Name = "tbCSVDelimiter";
            this.tbCSVDelimiter.Size = new System.Drawing.Size(51, 20);
            this.tbCSVDelimiter.TabIndex = 3;
            this.tbCSVDelimiter.Text = ";";
            this.tbCSVDelimiter.Leave += new System.EventHandler(this.tbCSVDelimiter_Leave);
            // 
            // tbCall
            // 
            this.tbCall.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbCall.Location = new System.Drawing.Point(123, 57);
            this.tbCall.Name = "tbCall";
            this.tbCall.Size = new System.Drawing.Size(169, 20);
            this.tbCall.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "ADIF Columns:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbColumn
            // 
            this.tbColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbColumn.Location = new System.Drawing.Point(123, 84);
            this.tbColumn.Name = "tbColumn";
            this.tbColumn.Size = new System.Drawing.Size(623, 20);
            this.tbColumn.TabIndex = 6;
            this.tbColumn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbColumn_KeyDown);
            // 
            // btColAdd
            // 
            this.btColAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btColAdd.Location = new System.Drawing.Point(752, 84);
            this.btColAdd.Name = "btColAdd";
            this.btColAdd.Size = new System.Drawing.Size(74, 21);
            this.btColAdd.TabIndex = 7;
            this.btColAdd.Text = "Add";
            this.btColAdd.UseVisualStyleBackColor = true;
            this.btColAdd.Click += new System.EventHandler(this.btColAdd_Click);
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreview.Location = new System.Drawing.Point(3, 280);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.Size = new System.Drawing.Size(1403, 271);
            this.dgvPreview.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(123, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(623, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Formats: #Time4: Time 4 chars HHmm - #Time6: Time 6 chars HHmmss - #Date: Date Fo" +
    "rmat yyyyMMdd - #Freq: Frequenz in Hz";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(835, 265);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.btLoadADIFCols, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btSaveADIFCols, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btLoadPreview, 4, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 231);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(829, 31);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // btLoadADIFCols
            // 
            this.btLoadADIFCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLoadADIFCols.Location = new System.Drawing.Point(3, 3);
            this.btLoadADIFCols.Name = "btLoadADIFCols";
            this.btLoadADIFCols.Size = new System.Drawing.Size(159, 25);
            this.btLoadADIFCols.TabIndex = 0;
            this.btLoadADIFCols.Text = "Load ADIF Columns";
            this.btLoadADIFCols.UseVisualStyleBackColor = true;
            // 
            // btSaveADIFCols
            // 
            this.btSaveADIFCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSaveADIFCols.Location = new System.Drawing.Point(168, 3);
            this.btSaveADIFCols.Name = "btSaveADIFCols";
            this.btSaveADIFCols.Size = new System.Drawing.Size(159, 25);
            this.btSaveADIFCols.TabIndex = 0;
            this.btSaveADIFCols.Text = "Save ADIF Columns";
            this.btSaveADIFCols.UseVisualStyleBackColor = true;
            // 
            // btLoadPreview
            // 
            this.btLoadPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLoadPreview.Location = new System.Drawing.Point(663, 3);
            this.btLoadPreview.Name = "btLoadPreview";
            this.btLoadPreview.Size = new System.Drawing.Size(163, 25);
            this.btLoadPreview.TabIndex = 1;
            this.btLoadPreview.Text = "Preview";
            this.btLoadPreview.UseVisualStyleBackColor = true;
            // 
            // CSVADIFConverterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 588);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CSVADIFConverterGUI";
            this.Text = "CSV to ADIF Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btColUp;
        private System.Windows.Forms.Button btColDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btCSVColUp;
        private System.Windows.Forms.Button btCSVColDown;
        private System.Windows.Forms.ListBox lbCol;
        private System.Windows.Forms.ListBox lbCSVCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCSVFile;
        private System.Windows.Forms.Button btOpenCSV;
        private System.Windows.Forms.TextBox tbCSVDelimiter;
        private System.Windows.Forms.TextBox tbCall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbColumn;
        private System.Windows.Forms.Button btColAdd;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btLoadADIFCols;
        private System.Windows.Forms.Button btSaveADIFCols;
        private System.Windows.Forms.Button btLoadPreview;
    }
}

