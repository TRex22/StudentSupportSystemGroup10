namespace SSS_Windows_Forms.Forms.Tutor
{
    partial class SearchActivitiesModal
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
            this.button1 = new System.Windows.Forms.Button();
            this.studentactivityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivitynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivitypointvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivityweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivitydescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTACTIVITYDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studenT_ACTIVITYTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter();
            this.activitY_FULL_DATATableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ACTIVITY_FULL_DATATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTACTIVITYDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentactivityidDataGridViewTextBoxColumn,
            this.studentactivitynameDataGridViewTextBoxColumn,
            this.studentactivitypointvalueDataGridViewTextBoxColumn,
            this.studentactivityweekDataGridViewTextBoxColumn,
            this.studentactivitydescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDENTACTIVITYDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(675, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Activity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentactivityidDataGridViewTextBoxColumn
            // 
            this.studentactivityidDataGridViewTextBoxColumn.DataPropertyName = "student_activity_id";
            this.studentactivityidDataGridViewTextBoxColumn.HeaderText = "student_activity_id";
            this.studentactivityidDataGridViewTextBoxColumn.Name = "studentactivityidDataGridViewTextBoxColumn";
            this.studentactivityidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentactivitynameDataGridViewTextBoxColumn
            // 
            this.studentactivitynameDataGridViewTextBoxColumn.DataPropertyName = "student_activity_name";
            this.studentactivitynameDataGridViewTextBoxColumn.HeaderText = "student_activity_name";
            this.studentactivitynameDataGridViewTextBoxColumn.Name = "studentactivitynameDataGridViewTextBoxColumn";
            this.studentactivitynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentactivitypointvalueDataGridViewTextBoxColumn
            // 
            this.studentactivitypointvalueDataGridViewTextBoxColumn.DataPropertyName = "student_activity_pointvalue";
            this.studentactivitypointvalueDataGridViewTextBoxColumn.HeaderText = "student_activity_pointvalue";
            this.studentactivitypointvalueDataGridViewTextBoxColumn.Name = "studentactivitypointvalueDataGridViewTextBoxColumn";
            this.studentactivitypointvalueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentactivityweekDataGridViewTextBoxColumn
            // 
            this.studentactivityweekDataGridViewTextBoxColumn.DataPropertyName = "student_activity_week";
            this.studentactivityweekDataGridViewTextBoxColumn.HeaderText = "student_activity_week";
            this.studentactivityweekDataGridViewTextBoxColumn.Name = "studentactivityweekDataGridViewTextBoxColumn";
            this.studentactivityweekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentactivitydescriptionDataGridViewTextBoxColumn
            // 
            this.studentactivitydescriptionDataGridViewTextBoxColumn.DataPropertyName = "student_activity_description";
            this.studentactivitydescriptionDataGridViewTextBoxColumn.HeaderText = "student_activity_description";
            this.studentactivitydescriptionDataGridViewTextBoxColumn.Name = "studentactivitydescriptionDataGridViewTextBoxColumn";
            this.studentactivitydescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUDENTACTIVITYDataTableBindingSource
            // 
            this.sTUDENTACTIVITYDataTableBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSet.STUDENT_ACTIVITYDataTable);
            // 
            // studenT_ACTIVITYTableAdapter1
            // 
            this.studenT_ACTIVITYTableAdapter1.ClearBeforeFill = true;
            // 
            // activitY_FULL_DATATableAdapter1
            // 
            this.activitY_FULL_DATATableAdapter1.ClearBeforeFill = true;
            // 
            // SearchActivitiesModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 539);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchActivitiesModal";
            this.ShowIcon = false;
            this.Text = "SearchActivitiesModal";
            this.Load += new System.EventHandler(this.SearchActivitiesModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTACTIVITYDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivitynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivitypointvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivityweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivitydescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sTUDENTACTIVITYDataTableBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter studenT_ACTIVITYTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ACTIVITY_FULL_DATATableAdapter activitY_FULL_DATATableAdapter1;
    }
}