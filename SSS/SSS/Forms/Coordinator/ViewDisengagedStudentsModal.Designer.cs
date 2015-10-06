namespace SSS.Forms.Coordinator
{
    partial class ViewDisengagedStudentsModal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dISENGAGEDSTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS2G10_DBSSSDataSet = new SSS.IS2G10_DBSSSDataSet();
            this.dISENGAGEDSTUDENTSAGGREGATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dISENGAGED_STUDENTSTableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTSTableAdapter();
            this.dISENGAGED_STUDENTS_AGGREGATETableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTS_AGGREGATETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dISENGAGEDSTUDENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISENGAGEDSTUDENTSAGGREGATEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dISENGAGEDSTUDENTSBindingSource
            // 
            this.dISENGAGEDSTUDENTSBindingSource.DataMember = "DISENGAGED_STUDENTS";
            this.dISENGAGEDSTUDENTSBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dISENGAGEDSTUDENTSAGGREGATEBindingSource
            // 
            this.dISENGAGEDSTUDENTSAGGREGATEBindingSource.DataMember = "DISENGAGED_STUDENTS_AGGREGATE";
            this.dISENGAGEDSTUDENTSAGGREGATEBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DisengagedStudents";
            reportDataSource1.Value = this.dISENGAGEDSTUDENTSBindingSource;
            reportDataSource2.Name = "DisengagedStudentsAggregate";
            reportDataSource2.Value = this.dISENGAGEDSTUDENTSAGGREGATEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS.Reports.Coordinator.StudentEngagement.ViewDisengagedStudentsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(753, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // dISENGAGED_STUDENTSTableAdapter
            // 
            this.dISENGAGED_STUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // dISENGAGED_STUDENTS_AGGREGATETableAdapter
            // 
            this.dISENGAGED_STUDENTS_AGGREGATETableAdapter.ClearBeforeFill = true;
            // 
            // ViewDisengagedStudentsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 539);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDisengagedStudentsModal";
            this.Text = "ViewDisengagedStudentsModal";
            this.Load += new System.EventHandler(this.ViewDisengagedStudentsModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dISENGAGEDSTUDENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISENGAGEDSTUDENTSAGGREGATEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource dISENGAGEDSTUDENTSBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTSTableAdapter dISENGAGED_STUDENTSTableAdapter;
        private System.Windows.Forms.BindingSource dISENGAGEDSTUDENTSAGGREGATEBindingSource;
        private IS2G10_DBSSSDataSetTableAdapters.DISENGAGED_STUDENTS_AGGREGATETableAdapter dISENGAGED_STUDENTS_AGGREGATETableAdapter;
    }
}