namespace SSS.Forms.Coordinator
{
    partial class SearchTutorModal
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TutorInformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.isAssignedGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.tutoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEARCHTUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS2G10_DBSSSDataSet = new SSS.IS2G10_DBSSSDataSet();
            this.sEARCH_TUTORTableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.SEARCH_TUTORTableAdapter();
            this.groupTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter();
            this.tutorTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHTUTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search for Tutors";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(266, 151);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupComboBox.TabIndex = 21;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Select Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tutors:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tutoridDataGridViewTextBoxColumn,
            this.tutorfirstnameDataGridViewTextBoxColumn,
            this.tutorlastnameDataGridViewTextBoxColumn,
            this.TutorInformation});
            this.dataGridView1.DataSource = this.sEARCHTUTORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(98, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TutorInformation
            // 
            this.TutorInformation.HeaderText = "Tutor Information";
            this.TutorInformation.Name = "TutorInformation";
            this.TutorInformation.ReadOnly = true;
            // 
            // isAssignedGroupCheckBox
            // 
            this.isAssignedGroupCheckBox.AutoSize = true;
            this.isAssignedGroupCheckBox.Location = new System.Drawing.Point(56, 150);
            this.isAssignedGroupCheckBox.Name = "isAssignedGroupCheckBox";
            this.isAssignedGroupCheckBox.Size = new System.Drawing.Size(140, 17);
            this.isAssignedGroupCheckBox.TabIndex = 24;
            this.isAssignedGroupCheckBox.Text = "Filter by Assigned Group";
            this.isAssignedGroupCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.isAssignedGroupCheckBox.UseVisualStyleBackColor = true;
            this.isAssignedGroupCheckBox.CheckedChanged += new System.EventHandler(this.isAssigned_CheckedChanged);
            // 
            // tutoridDataGridViewTextBoxColumn
            // 
            this.tutoridDataGridViewTextBoxColumn.DataPropertyName = "tutor_id";
            this.tutoridDataGridViewTextBoxColumn.HeaderText = "Tutor Id";
            this.tutoridDataGridViewTextBoxColumn.Name = "tutoridDataGridViewTextBoxColumn";
            this.tutoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorfirstnameDataGridViewTextBoxColumn
            // 
            this.tutorfirstnameDataGridViewTextBoxColumn.DataPropertyName = "tutor_firstname";
            this.tutorfirstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.tutorfirstnameDataGridViewTextBoxColumn.Name = "tutorfirstnameDataGridViewTextBoxColumn";
            this.tutorfirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorlastnameDataGridViewTextBoxColumn
            // 
            this.tutorlastnameDataGridViewTextBoxColumn.DataPropertyName = "tutor_lastname";
            this.tutorlastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.tutorlastnameDataGridViewTextBoxColumn.Name = "tutorlastnameDataGridViewTextBoxColumn";
            this.tutorlastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEARCHTUTORBindingSource
            // 
            this.sEARCHTUTORBindingSource.DataMember = "SEARCH_TUTOR";
            this.sEARCHTUTORBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEARCH_TUTORTableAdapter
            // 
            this.sEARCH_TUTORTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter1
            // 
            this.groupTableAdapter1.ClearBeforeFill = true;
            // 
            // tutorTableAdapter1
            // 
            this.tutorTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchTutorModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 501);
            this.ControlBox = false;
            this.Controls.Add(this.isAssignedGroupCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchTutorModal";
            this.Text = "SearchTutorModal";
            this.Load += new System.EventHandler(this.SearchTutorModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHTUTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sEARCHTUTORBindingSource;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private IS2G10_DBSSSDataSetTableAdapters.SEARCH_TUTORTableAdapter sEARCH_TUTORTableAdapter;
        private IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter groupTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter tutorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn TutorInformation;
        private System.Windows.Forms.CheckBox isAssignedGroupCheckBox;
    }
}