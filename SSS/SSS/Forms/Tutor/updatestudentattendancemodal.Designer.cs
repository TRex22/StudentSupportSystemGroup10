namespace SSS
{
    partial class UpdateStudentAttendanceModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.student_activity_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPDATESTUDENTATTENDANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS2G10_DBSSSDataSet2 = new SSS.IS2G10_DBSSSDataSet();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tutoR_SESSION_GROUPTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.TUTOR_SESSION_GROUPTableAdapter();
            this.iS2G10_DBSSSDataSet = new SSS.IS2G10_DBSSSDataSet();
            this.tUTORSESSIONGROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studenT_ACTIVITYTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter();
            this.iS2G10_DBSSSDataSet1 = new SSS.IS2G10_DBSSSDataSet();
            this.aTTENDANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDANCETableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter();
            this.uPDATE_STUDENT_ATTENDANCETableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.UPDATE_STUDENT_ATTENDANCETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPDATESTUDENTATTENDANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORSESSIONGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 515);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.activityComboBox);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.groupComboBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 486);
            this.panel2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Select Activity";
            // 
            // activityComboBox
            // 
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.Location = new System.Drawing.Point(336, 128);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(225, 21);
            this.activityComboBox.TabIndex = 10;
            this.activityComboBox.SelectedIndexChanged += new System.EventHandler(this.activityComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.attendanceDataGridViewCheckBoxColumn,
            this.student_activity_id});
            this.dataGridView1.DataSource = this.uPDATESTUDENTATTENDANCEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(183, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 207);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student Id";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // attendanceDataGridViewCheckBoxColumn
            // 
            this.attendanceDataGridViewCheckBoxColumn.DataPropertyName = "Attendance";
            this.attendanceDataGridViewCheckBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewCheckBoxColumn.Name = "attendanceDataGridViewCheckBoxColumn";
            // 
            // student_activity_id
            // 
            this.student_activity_id.DataPropertyName = "student_activity_id";
            this.student_activity_id.HeaderText = "student_activity_id";
            this.student_activity_id.Name = "student_activity_id";
            this.student_activity_id.Visible = false;
            // 
            // uPDATESTUDENTATTENDANCEBindingSource
            // 
            this.uPDATESTUDENTATTENDANCEBindingSource.DataMember = "UPDATE_STUDENT_ATTENDANCE";
            this.uPDATESTUDENTATTENDANCEBindingSource.DataSource = this.iS2G10_DBSSSDataSet2;
            // 
            // iS2G10_DBSSSDataSet2
            // 
            this.iS2G10_DBSSSDataSet2.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(128, 128);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupComboBox.TabIndex = 8;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Select Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Select students who have attended";
            // 
            // tutoR_SESSION_GROUPTableAdapter1
            // 
            this.tutoR_SESSION_GROUPTableAdapter1.ClearBeforeFill = true;
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUTORSESSIONGROUPBindingSource
            // 
            this.tUTORSESSIONGROUPBindingSource.DataMember = "TUTOR_SESSION_GROUP";
            this.tUTORSESSIONGROUPBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // studenT_ACTIVITYTableAdapter1
            // 
            this.studenT_ACTIVITYTableAdapter1.ClearBeforeFill = true;
            // 
            // iS2G10_DBSSSDataSet1
            // 
            this.iS2G10_DBSSSDataSet1.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTTENDANCEBindingSource
            // 
            this.aTTENDANCEBindingSource.DataMember = "ATTENDANCE";
            this.aTTENDANCEBindingSource.DataSource = this.iS2G10_DBSSSDataSet1;
            // 
            // aTTENDANCETableAdapter
            // 
            this.aTTENDANCETableAdapter.ClearBeforeFill = true;
            // 
            // uPDATE_STUDENT_ATTENDANCETableAdapter
            // 
            this.uPDATE_STUDENT_ATTENDANCETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Update Student Attendance";
            // 
            // UpdateStudentAttendanceModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 539);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateStudentAttendanceModal";
            this.Text = "updatestudentattendancemodal";
            this.Load += new System.EventHandler(this.UpdateStudentAttendanceModal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPDATESTUDENTATTENDANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORSESSIONGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label7;
        private IS2G10_DBSSSDataSetTableAdapters.TUTOR_SESSION_GROUPTableAdapter tutoR_SESSION_GROUPTableAdapter1;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource tUTORSESSIONGROUPBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox activityComboBox;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter studenT_ACTIVITYTableAdapter1;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet1;
        private System.Windows.Forms.BindingSource aTTENDANCEBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter aTTENDANCETableAdapter;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet2;
        private System.Windows.Forms.BindingSource uPDATESTUDENTATTENDANCEBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.UPDATE_STUDENT_ATTENDANCETableAdapter uPDATE_STUDENT_ATTENDANCETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attendanceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_activity_id;
        private System.Windows.Forms.Label label1;
    }
}