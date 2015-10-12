namespace SSS
{
    partial class RegisterGroupModal
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouptimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinGroupButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gROUPAGGREGATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS2G10_DBSSSDataSet = new SSS.IS2G10_DBSSSDataSet();
            this.gROUP_AGGREGATETableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.GROUP_AGGREGATETableAdapter();
            this.studentTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter();
            this.attendanceTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter();
            this.studenT_ACTIVITYTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPAGGREGATEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Available Groups to Join";
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
            this.groupnameDataGridViewTextBoxColumn,
            this.groupdayDataGridViewTextBoxColumn,
            this.grouptimeDataGridViewTextBoxColumn,
            this.groupCountDataGridViewTextBoxColumn,
            this.JoinGroupButtonColumn});
            this.dataGridView1.DataSource = this.gROUPAGGREGATEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 245);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupnameDataGridViewTextBoxColumn
            // 
            this.groupnameDataGridViewTextBoxColumn.DataPropertyName = "group_name";
            this.groupnameDataGridViewTextBoxColumn.HeaderText = "Group Name";
            this.groupnameDataGridViewTextBoxColumn.Name = "groupnameDataGridViewTextBoxColumn";
            // 
            // groupdayDataGridViewTextBoxColumn
            // 
            this.groupdayDataGridViewTextBoxColumn.DataPropertyName = "group_day";
            this.groupdayDataGridViewTextBoxColumn.HeaderText = "Group Day";
            this.groupdayDataGridViewTextBoxColumn.Name = "groupdayDataGridViewTextBoxColumn";
            // 
            // grouptimeDataGridViewTextBoxColumn
            // 
            this.grouptimeDataGridViewTextBoxColumn.DataPropertyName = "group_time";
            this.grouptimeDataGridViewTextBoxColumn.HeaderText = "Group Time";
            this.grouptimeDataGridViewTextBoxColumn.Name = "grouptimeDataGridViewTextBoxColumn";
            // 
            // groupCountDataGridViewTextBoxColumn
            // 
            this.groupCountDataGridViewTextBoxColumn.DataPropertyName = "GroupCount";
            this.groupCountDataGridViewTextBoxColumn.HeaderText = "Group Count";
            this.groupCountDataGridViewTextBoxColumn.Name = "groupCountDataGridViewTextBoxColumn";
            this.groupCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // JoinGroupButtonColumn
            // 
            this.JoinGroupButtonColumn.HeaderText = "Join Group";
            this.JoinGroupButtonColumn.Name = "JoinGroupButtonColumn";
            this.JoinGroupButtonColumn.Text = "Join Group";
            this.JoinGroupButtonColumn.ToolTipText = "Click this button to join this group";
            // 
            // gROUPAGGREGATEBindingSource
            // 
            this.gROUPAGGREGATEBindingSource.DataMember = "GROUP_AGGREGATE";
            this.gROUPAGGREGATEBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gROUP_AGGREGATETableAdapter
            // 
            this.gROUP_AGGREGATETableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // studenT_ACTIVITYTableAdapter1
            // 
            this.studenT_ACTIVITYTableAdapter1.ClearBeforeFill = true;
            // 
            // RegisterGroupModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 539);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterGroupModal";
            this.Text = "registerforactivitiesmodal";
            this.Load += new System.EventHandler(this.RegisterGroupModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPAGGREGATEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource gROUPAGGREGATEBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.GROUP_AGGREGATETableAdapter gROUP_AGGREGATETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grouptimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn JoinGroupButtonColumn;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter attendanceTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter studenT_ACTIVITYTableAdapter1;
    }
}