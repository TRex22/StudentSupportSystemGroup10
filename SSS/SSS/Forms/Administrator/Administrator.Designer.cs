namespace SSS_Windows_Forms.Forms.Administrator
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel8 = new System.Windows.Forms.Panel();
            this.menuStrip9 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip10 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCoordinatorName = new System.Windows.Forms.Label();
            this.tmrSecond = new System.Windows.Forms.Timer(this.components);
            this.iS2G10_DBSSSDataSet = new SSS_Library.IS2G10_DBSSSDataSet();
            this.sSS_COORDINATORTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter();
            this.searchCoordinatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.coordinatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCoordinatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCoordinatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSSCOORDINATORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8.SuspendLayout();
            this.menuStrip9.SuspendLayout();
            this.menuStrip10.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sSSCOORDINATORBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.menuStrip9);
            this.panel8.Location = new System.Drawing.Point(3, 507);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 31);
            this.panel8.TabIndex = 9;
            // 
            // menuStrip9
            // 
            this.menuStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip9.Location = new System.Drawing.Point(0, 0);
            this.menuStrip9.Name = "menuStrip9";
            this.menuStrip9.Size = new System.Drawing.Size(235, 27);
            this.menuStrip9.TabIndex = 0;
            this.menuStrip9.Text = "menuStrip9";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuStrip10
            // 
            this.menuStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem});
            this.menuStrip10.Location = new System.Drawing.Point(0, 0);
            this.menuStrip10.Name = "menuStrip10";
            this.menuStrip10.Size = new System.Drawing.Size(241, 27);
            this.menuStrip10.TabIndex = 10;
            this.menuStrip10.Text = "menuStrip10";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblCoordinatorName);
            this.panel2.Location = new System.Drawing.Point(3, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 23);
            this.panel2.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(890, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 1;
            // 
            // lblCoordinatorName
            // 
            this.lblCoordinatorName.AutoSize = true;
            this.lblCoordinatorName.Location = new System.Drawing.Point(5, 6);
            this.lblCoordinatorName.Name = "lblCoordinatorName";
            this.lblCoordinatorName.Size = new System.Drawing.Size(0, 13);
            this.lblCoordinatorName.TabIndex = 0;
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
            // sSS_COORDINATORTableAdapter
            // 
            this.sSS_COORDINATORTableAdapter.ClearBeforeFill = true;
            // 
            // searchCoordinatorToolStripMenuItem
            // 
            this.searchCoordinatorToolStripMenuItem.Name = "searchCoordinatorToolStripMenuItem";
            this.searchCoordinatorToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.searchCoordinatorToolStripMenuItem.Text = "Search Coordinator";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 71);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 663);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(3, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1019, 547);
            this.panel4.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(252, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(762, 539);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.menuStrip1);
            this.panel6.Controls.Add(this.menuStrip2);
            this.panel6.Controls.Add(this.menuStrip5);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.menuStrip10);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(243, 539);
            this.panel6.TabIndex = 1;
            // 
            // menuStrip5
            // 
            this.menuStrip5.Font = new System.Drawing.Font("Calibri", 12F);
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordinatorToolStripMenuItem});
            this.menuStrip5.Location = new System.Drawing.Point(0, 27);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(241, 27);
            this.menuStrip5.TabIndex = 27;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // coordinatorToolStripMenuItem
            // 
            this.coordinatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerCoordinatorToolStripMenuItem,
            this.updateCoordinatorToolStripMenuItem,
            this.searchCoordinatorToolStripMenuItem});
            this.coordinatorToolStripMenuItem.Name = "coordinatorToolStripMenuItem";
            this.coordinatorToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.coordinatorToolStripMenuItem.Text = "Coordinator";
            // 
            // registerCoordinatorToolStripMenuItem
            // 
            this.registerCoordinatorToolStripMenuItem.Name = "registerCoordinatorToolStripMenuItem";
            this.registerCoordinatorToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.registerCoordinatorToolStripMenuItem.Text = "Register Coordinator";
            // 
            // updateCoordinatorToolStripMenuItem
            // 
            this.updateCoordinatorToolStripMenuItem.Name = "updateCoordinatorToolStripMenuItem";
            this.updateCoordinatorToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.updateCoordinatorToolStripMenuItem.Text = "Update Coordinator";
            // 
            // sSSCOORDINATORBindingSource
            // 
            this.sSSCOORDINATORBindingSource.DataMember = "SSS_COORDINATOR";
            this.sSSCOORDINATORBindingSource.DataSource = this.iS2G10_DBSSSDataSet;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 54);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(241, 27);
            this.menuStrip2.TabIndex = 31;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 23);
            this.toolStripMenuItem1.Text = "Branding";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 81);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(241, 27);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemSettingsToolStripMenuItem
            // 
            this.systemSettingsToolStripMenuItem.Name = "systemSettingsToolStripMenuItem";
            this.systemSettingsToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.systemSettingsToolStripMenuItem.Text = "System Settings";
            this.systemSettingsToolStripMenuItem.Click += new System.EventHandler(this.systemSettingsToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 667);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.menuStrip9.ResumeLayout(false);
            this.menuStrip9.PerformLayout();
            this.menuStrip10.ResumeLayout(false);
            this.menuStrip10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iS2G10_DBSSSDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sSSCOORDINATORBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MenuStrip menuStrip9;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip10;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCoordinatorName;
        private System.Windows.Forms.Timer tmrSecond;
        private SSS_Library.IS2G10_DBSSSDataSet iS2G10_DBSSSDataSet;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter sSS_COORDINATORTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem searchCoordinatorToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem coordinatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCoordinatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCoordinatorToolStripMenuItem;
        private System.Windows.Forms.BindingSource sSSCOORDINATORBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemSettingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}