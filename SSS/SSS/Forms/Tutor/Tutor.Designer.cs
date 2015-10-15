namespace SSS_Windows_Forms
{
    partial class Tutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.updateStudentConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.updateTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip7 = new System.Windows.Forms.MenuStrip();
            this.createStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip8 = new System.Windows.Forms.MenuStrip();
            this.createTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip9 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTutorName = new System.Windows.Forms.Label();
            this.tmrSecond = new System.Windows.Forms.Timer(this.components);
            this.iS2G10_DBSSSDataSet = new SSS_Library.IS2G10_DBSSSDataSet();
            this.iS2G10DBSSSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUTORTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter();
            this.tUTORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            this.menuStrip7.SuspendLayout();
            this.menuStrip8.SuspendLayout();
            this.menuStrip9.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10DBSSSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 71);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Student Support System";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(1, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 547);
            this.panel4.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(252, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(753, 539);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.menuStrip1);
            this.panel6.Controls.Add(this.menuStrip3);
            this.panel6.Controls.Add(this.menuStrip4);
            this.panel6.Controls.Add(this.menuStrip5);
            this.panel6.Controls.Add(this.menuStrip6);
            this.panel6.Controls.Add(this.menuStrip7);
            this.panel6.Controls.Add(this.menuStrip8);
            this.panel6.Controls.Add(this.menuStrip9);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(243, 539);
            this.panel6.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.menuStrip2);
            this.panel8.Location = new System.Drawing.Point(3, 507);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 31);
            this.panel8.TabIndex = 9;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(235, 27);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Location = new System.Drawing.Point(0, 186);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(241, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip3.Location = new System.Drawing.Point(0, 162);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(241, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // menuStrip4
            // 
            this.menuStrip4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStudentConsultationToolStripMenuItem});
            this.menuStrip4.Location = new System.Drawing.Point(0, 135);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(241, 27);
            this.menuStrip4.TabIndex = 4;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // updateStudentConsultationToolStripMenuItem
            // 
            this.updateStudentConsultationToolStripMenuItem.Name = "updateStudentConsultationToolStripMenuItem";
            this.updateStudentConsultationToolStripMenuItem.Size = new System.Drawing.Size(207, 23);
            this.updateStudentConsultationToolStripMenuItem.Text = "Update Student Consultation";
            this.updateStudentConsultationToolStripMenuItem.Click += new System.EventHandler(this.updateStudentConsultationToolStripMenuItem_Click);
            // 
            // menuStrip5
            // 
            this.menuStrip5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStudentToolStripMenuItem});
            this.menuStrip5.Location = new System.Drawing.Point(0, 108);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(241, 27);
            this.menuStrip5.TabIndex = 5;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(199, 23);
            this.updateStudentToolStripMenuItem.Text = "Update Student Attendance";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // menuStrip6
            // 
            this.menuStrip6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateTutorToolStripMenuItem});
            this.menuStrip6.Location = new System.Drawing.Point(0, 81);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.Size = new System.Drawing.Size(241, 27);
            this.menuStrip6.TabIndex = 6;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // updateTutorToolStripMenuItem
            // 
            this.updateTutorToolStripMenuItem.Name = "updateTutorToolStripMenuItem";
            this.updateTutorToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.updateTutorToolStripMenuItem.Text = "Update Tutor";
            this.updateTutorToolStripMenuItem.Click += new System.EventHandler(this.updateTutorToolStripMenuItem_Click);
            // 
            // menuStrip7
            // 
            this.menuStrip7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStudentToolStripMenuItem});
            this.menuStrip7.Location = new System.Drawing.Point(0, 54);
            this.menuStrip7.Name = "menuStrip7";
            this.menuStrip7.Size = new System.Drawing.Size(241, 27);
            this.menuStrip7.TabIndex = 7;
            this.menuStrip7.Text = "menuStrip7";
            // 
            // createStudentToolStripMenuItem
            // 
            this.createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            this.createStudentToolStripMenuItem.Size = new System.Drawing.Size(154, 23);
            this.createStudentToolStripMenuItem.Text = "Update Consultation";
            this.createStudentToolStripMenuItem.Click += new System.EventHandler(this.createStudentToolStripMenuItem_Click);
            // 
            // menuStrip8
            // 
            this.menuStrip8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTutorToolStripMenuItem});
            this.menuStrip8.Location = new System.Drawing.Point(0, 27);
            this.menuStrip8.Name = "menuStrip8";
            this.menuStrip8.Size = new System.Drawing.Size(241, 27);
            this.menuStrip8.TabIndex = 8;
            this.menuStrip8.Text = "menuStrip8";
            // 
            // createTutorToolStripMenuItem
            // 
            this.createTutorToolStripMenuItem.Name = "createTutorToolStripMenuItem";
            this.createTutorToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.createTutorToolStripMenuItem.Text = "Update Activity";
            this.createTutorToolStripMenuItem.Click += new System.EventHandler(this.createTutorToolStripMenuItem_Click);
            // 
            // menuStrip9
            // 
            this.menuStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem});
            this.menuStrip9.Location = new System.Drawing.Point(0, 0);
            this.menuStrip9.Name = "menuStrip9";
            this.menuStrip9.Size = new System.Drawing.Size(241, 27);
            this.menuStrip9.TabIndex = 10;
            this.menuStrip9.Text = "menuStrip9";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblTutorName);
            this.panel2.Location = new System.Drawing.Point(5, 629);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 23);
            this.panel2.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(890, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 1;
            // 
            // lblTutorName
            // 
            this.lblTutorName.AutoSize = true;
            this.lblTutorName.Location = new System.Drawing.Point(5, 6);
            this.lblTutorName.Name = "lblTutorName";
            this.lblTutorName.Size = new System.Drawing.Size(0, 13);
            this.lblTutorName.TabIndex = 0;
            // 
            // tmrSecond
            // 
            this.tmrSecond.Enabled = true;
            this.tmrSecond.Interval = 1000;
            this.tmrSecond.Tick += new System.EventHandler(this.tmrSecond_Tick);
            // 
            // iS2G10_DBSSSDataSet
            // 
            this.iS2G10_DBSSSDataSet.DataSetName = "IS2G10_DBSSSDataSet";
            this.iS2G10_DBSSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iS2G10DBSSSDataSetBindingSource
            // 
            this.iS2G10DBSSSDataSetBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            this.iS2G10DBSSSDataSetBindingSource.Position = 0;
            // 
            // tUTORBindingSource
            // 
            this.tUTORBindingSource.DataMember = "TUTOR";
            this.tUTORBindingSource.DataSource = this.iS2G10DBSSSDataSetBindingSource;
            // 
            // tUTORTableAdapter
            // 
            this.tUTORTableAdapter.ClearBeforeFill = true;
            // 
            // tUTORBindingSource1
            // 
            this.tUTORBindingSource1.DataMember = "TUTOR";
            this.tUTORBindingSource1.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 667);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Tutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor";
            this.Load += new System.EventHandler(this.Tutor_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.menuStrip7.ResumeLayout(false);
            this.menuStrip7.PerformLayout();
            this.menuStrip8.ResumeLayout(false);
            this.menuStrip8.PerformLayout();
            this.menuStrip9.ResumeLayout(false);
            this.menuStrip9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10DBSSSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUTORBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem updateTutorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip7;
        private System.Windows.Forms.ToolStripMenuItem createStudentToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip8;
        private System.Windows.Forms.ToolStripMenuItem createTutorToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTutorName;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem updateStudentConsultationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip9;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.Timer tmrSecond;
        private System.Windows.Forms.BindingSource iS2G10DBSSSDataSetBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private System.Windows.Forms.BindingSource tUTORBindingSource;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter tUTORTableAdapter;
        private System.Windows.Forms.BindingSource tUTORBindingSource1;
    }
}