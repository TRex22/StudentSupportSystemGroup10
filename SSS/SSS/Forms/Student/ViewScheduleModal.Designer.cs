namespace SSS_Windows_Forms.Forms.Student
{
    partial class ViewScheduleModal
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
            this.iS2G10_DBSSSDataSet = new SSS_Library.IS2G10_DBSSSDataSet();
            this.gROUPTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouptimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule";
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gROUPTableAdapter
            // 
            this.gROUPTableAdapter.ClearBeforeFill = true;
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
            this.groupidDataGridViewTextBoxColumn,
            this.groupnameDataGridViewTextBoxColumn,
            this.groupdayDataGridViewTextBoxColumn,
            this.grouptimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gROUPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(134, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "Group Id";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            this.groupidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupnameDataGridViewTextBoxColumn
            // 
            this.groupnameDataGridViewTextBoxColumn.DataPropertyName = "group_name";
            this.groupnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.groupnameDataGridViewTextBoxColumn.Name = "groupnameDataGridViewTextBoxColumn";
            // 
            // groupdayDataGridViewTextBoxColumn
            // 
            this.groupdayDataGridViewTextBoxColumn.DataPropertyName = "group_day";
            this.groupdayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.groupdayDataGridViewTextBoxColumn.Name = "groupdayDataGridViewTextBoxColumn";
            // 
            // grouptimeDataGridViewTextBoxColumn
            // 
            this.grouptimeDataGridViewTextBoxColumn.DataPropertyName = "group_time";
            this.grouptimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.grouptimeDataGridViewTextBoxColumn.Name = "grouptimeDataGridViewTextBoxColumn";
            // 
            // gROUPBindingSource
            // 
            this.gROUPBindingSource.DataMember = "GROUP";
            this.gROUPBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // groupTableAdapter1
            // 
            this.groupTableAdapter1.ClearBeforeFill = true;
            // 
            // ViewScheduleModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 539);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewScheduleModal";
            this.Text = "ViewScheduleModal";
            this.Load += new System.EventHandler(this.ViewScheduleModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SSS_Library.IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter gROUPTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grouptimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gROUPBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.GROUPTableAdapter groupTableAdapter1;
    }
}