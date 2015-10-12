namespace SSS.Forms.Coordinator
{
    partial class SearchStudentModal
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentInformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sEARCHSTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS2G10_DBSSSDataSet = new SSS.IS2G10_DBSSSDataSet();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter();
            this.sEARCH_STUDENTTableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.SEARCH_STUDENTTableAdapter();
            this.groupTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter();
            this.studentIDtextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHSTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.studentfirstnameDataGridViewTextBoxColumn,
            this.studentlastnameDataGridViewTextBoxColumn,
            this.StudentInformation});
            this.dataGridView1.DataSource = this.sEARCHSTUDENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(147, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(468, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "Student Id";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentfirstnameDataGridViewTextBoxColumn
            // 
            this.studentfirstnameDataGridViewTextBoxColumn.DataPropertyName = "student_firstname";
            this.studentfirstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.studentfirstnameDataGridViewTextBoxColumn.Name = "studentfirstnameDataGridViewTextBoxColumn";
            this.studentfirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentlastnameDataGridViewTextBoxColumn
            // 
            this.studentlastnameDataGridViewTextBoxColumn.DataPropertyName = "student_lastname";
            this.studentlastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.studentlastnameDataGridViewTextBoxColumn.Name = "studentlastnameDataGridViewTextBoxColumn";
            this.studentlastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StudentInformation
            // 
            this.StudentInformation.HeaderText = "Student Information";
            this.StudentInformation.Name = "StudentInformation";
            this.StudentInformation.ReadOnly = true;
            // 
            // sEARCHSTUDENTBindingSource
            // 
            this.sEARCHSTUDENTBindingSource.DataMember = "SEARCH_STUDENT";
            this.sEARCHSTUDENTBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(110, 36);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupComboBox.TabIndex = 14;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Select Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Students:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search for Students";
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // sEARCH_STUDENTTableAdapter
            // 
            this.sEARCH_STUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter1
            // 
            this.groupTableAdapter1.ClearBeforeFill = true;
            // 
            // studentIDtextBox1
            // 
            this.studentIDtextBox1.Location = new System.Drawing.Point(6, 55);
            this.studentIDtextBox1.Name = "studentIDtextBox1";
            this.studentIDtextBox1.Size = new System.Drawing.Size(100, 20);
            this.studentIDtextBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Student ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Filter by Group";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.groupComboBox);
            this.groupBox1.Location = new System.Drawing.Point(475, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 92);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.studentIDtextBox1);
            this.groupBox2.Location = new System.Drawing.Point(78, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 92);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Field";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(168, 55);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchStudentModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 539);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchStudentModal";
            this.Text = "SearchStudentModal";
            this.Load += new System.EventHandler(this.SearchStudentModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHSTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.BindingSource sEARCHSTUDENTBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.SEARCH_STUDENTTableAdapter sEARCH_STUDENTTableAdapter;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter groupTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn StudentInformation;
        private System.Windows.Forms.TextBox studentIDtextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchButton;
    }
}