namespace SSS
{
    partial class RegisterStudentModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudentModal));
            this.studentIdTxtBox = new System.Windows.Forms.TextBox();
            this.IdPassportTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.StudentProgrammeTxtBox = new System.Windows.Forms.TextBox();
            this.YearOfStudyComboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter();
            this.lblErrStdID = new System.Windows.Forms.Label();
            this.lblErrFName = new System.Windows.Forms.Label();
            this.lblErrLName = new System.Windows.Forms.Label();
            this.lblErrEmail = new System.Windows.Forms.Label();
            this.lblErrYoS = new System.Windows.Forms.Label();
            this.MobileTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.lblErrPassID = new System.Windows.Forms.Label();
            this.lblErrDoB = new System.Windows.Forms.Label();
            this.lblErrMobileNum = new System.Windows.Forms.Label();
            this.lblErrStdProg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIdTxtBox
            // 
            this.studentIdTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTxtBox.Location = new System.Drawing.Point(56, 86);
            this.studentIdTxtBox.Name = "studentIdTxtBox";
            this.studentIdTxtBox.Size = new System.Drawing.Size(209, 27);
            this.studentIdTxtBox.TabIndex = 0;
            this.studentIdTxtBox.Text = "Enter Student\'s student ID";
            this.studentIdTxtBox.Enter += new System.EventHandler(this.studentIdTxtBox_Enter);
            // 
            // IdPassportTxtBox
            // 
            this.IdPassportTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPassportTxtBox.Location = new System.Drawing.Point(393, 86);
            this.IdPassportTxtBox.Name = "IdPassportTxtBox";
            this.IdPassportTxtBox.Size = new System.Drawing.Size(216, 27);
            this.IdPassportTxtBox.TabIndex = 1;
            this.IdPassportTxtBox.Text = "Enter ID or Passport Number";
            this.IdPassportTxtBox.Enter += new System.EventHandler(this.IdPasswordTxtBox_Enter);
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(56, 170);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(209, 27);
            this.FirstNameTxtBox.TabIndex = 2;
            this.FirstNameTxtBox.Text = "Enter Student\'s First Name";
            this.FirstNameTxtBox.Enter += new System.EventHandler(this.FirstNameTxtBox_Enter);
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxtBox.Location = new System.Drawing.Point(59, 251);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(209, 27);
            this.LastNameTxtBox.TabIndex = 3;
            this.LastNameTxtBox.Text = "Enter Student\'s Last Name";
            this.LastNameTxtBox.Enter += new System.EventHandler(this.LastNameTxtBox_Enter);
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.HideSelection = false;
            this.EmailTxtBox.Location = new System.Drawing.Point(61, 337);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(209, 27);
            this.EmailTxtBox.TabIndex = 5;
            this.EmailTxtBox.Text = "Enter Student\'s Email Address";
            this.EmailTxtBox.Enter += new System.EventHandler(this.EmailTxtBox_Enter);
            // 
            // StudentProgrammeTxtBox
            // 
            this.StudentProgrammeTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentProgrammeTxtBox.Location = new System.Drawing.Point(399, 362);
            this.StudentProgrammeTxtBox.Name = "StudentProgrammeTxtBox";
            this.StudentProgrammeTxtBox.Size = new System.Drawing.Size(216, 27);
            this.StudentProgrammeTxtBox.TabIndex = 8;
            this.StudentProgrammeTxtBox.Text = "Enter Student\'s Programme";
            this.StudentProgrammeTxtBox.Enter += new System.EventHandler(this.StudentProgrammeTxtBox_Enter);
            // 
            // YearOfStudyComboBox1
            // 
            this.YearOfStudyComboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearOfStudyComboBox1.FormattingEnabled = true;
            this.YearOfStudyComboBox1.Items.AddRange(new object[] {
            "YOS1",
            "YOS2",
            "YOS3",
            "Postgraduate"});
            this.YearOfStudyComboBox1.Location = new System.Drawing.Point(59, 424);
            this.YearOfStudyComboBox1.Name = "YearOfStudyComboBox1";
            this.YearOfStudyComboBox1.Size = new System.Drawing.Size(209, 27);
            this.YearOfStudyComboBox1.TabIndex = 9;
            this.YearOfStudyComboBox1.Text = "Select Year Of Study";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(272, 86);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(277, 337);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(618, 273);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(274, 424);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(274, 251);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(271, 171);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(29, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(621, 362);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(29, 27);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 22;
            this.pictureBox9.TabStop = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(575, 449);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 23;
            this.SubmitButton.Text = "&Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Please enter student details";
            // 
            // dateOfBirthDateTimePicker1
            // 
            this.dateOfBirthDateTimePicker1.Location = new System.Drawing.Point(396, 178);
            this.dateOfBirthDateTimePicker1.Name = "dateOfBirthDateTimePicker1";
            this.dateOfBirthDateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateOfBirthDateTimePicker1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Year of Study";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Student Programme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mobile Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "ID or Passport Number";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // lblErrStdID
            // 
            this.lblErrStdID.AutoSize = true;
            this.lblErrStdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrStdID.ForeColor = System.Drawing.Color.Red;
            this.lblErrStdID.Location = new System.Drawing.Point(56, 116);
            this.lblErrStdID.Name = "lblErrStdID";
            this.lblErrStdID.Size = new System.Drawing.Size(48, 13);
            this.lblErrStdID.TabIndex = 35;
            this.lblErrStdID.Text = "label11";
            this.lblErrStdID.Visible = false;
            // 
            // lblErrFName
            // 
            this.lblErrFName.AutoSize = true;
            this.lblErrFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrFName.ForeColor = System.Drawing.Color.Red;
            this.lblErrFName.Location = new System.Drawing.Point(58, 201);
            this.lblErrFName.Name = "lblErrFName";
            this.lblErrFName.Size = new System.Drawing.Size(48, 13);
            this.lblErrFName.TabIndex = 36;
            this.lblErrFName.Text = "label12";
            this.lblErrFName.Visible = false;
            // 
            // lblErrLName
            // 
            this.lblErrLName.AutoSize = true;
            this.lblErrLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrLName.ForeColor = System.Drawing.Color.Red;
            this.lblErrLName.Location = new System.Drawing.Point(59, 281);
            this.lblErrLName.Name = "lblErrLName";
            this.lblErrLName.Size = new System.Drawing.Size(48, 13);
            this.lblErrLName.TabIndex = 37;
            this.lblErrLName.Text = "label13";
            this.lblErrLName.Visible = false;
            this.lblErrLName.Click += new System.EventHandler(this.lblErrLName_Click);
            // 
            // lblErrEmail
            // 
            this.lblErrEmail.AutoSize = true;
            this.lblErrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrEmail.Location = new System.Drawing.Point(59, 367);
            this.lblErrEmail.Name = "lblErrEmail";
            this.lblErrEmail.Size = new System.Drawing.Size(48, 13);
            this.lblErrEmail.TabIndex = 38;
            this.lblErrEmail.Text = "label14";
            this.lblErrEmail.Visible = false;
            this.lblErrEmail.Click += new System.EventHandler(this.lblErrEmail_Click);
            // 
            // lblErrYoS
            // 
            this.lblErrYoS.AutoSize = true;
            this.lblErrYoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrYoS.ForeColor = System.Drawing.Color.Red;
            this.lblErrYoS.Location = new System.Drawing.Point(59, 454);
            this.lblErrYoS.Name = "lblErrYoS";
            this.lblErrYoS.Size = new System.Drawing.Size(48, 13);
            this.lblErrYoS.TabIndex = 39;
            this.lblErrYoS.Text = "label15";
            this.lblErrYoS.Visible = false;
            this.lblErrYoS.Click += new System.EventHandler(this.lblErrYoS_Click);
            // 
            // MobileTxtBox
            // 
            this.MobileTxtBox.Location = new System.Drawing.Point(396, 280);
            this.MobileTxtBox.Mask = "(999)000 0000";
            this.MobileTxtBox.Name = "MobileTxtBox";
            this.MobileTxtBox.Size = new System.Drawing.Size(213, 20);
            this.MobileTxtBox.TabIndex = 40;
            // 
            // lblErrPassID
            // 
            this.lblErrPassID.AutoSize = true;
            this.lblErrPassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrPassID.ForeColor = System.Drawing.Color.Red;
            this.lblErrPassID.Location = new System.Drawing.Point(393, 115);
            this.lblErrPassID.Name = "lblErrPassID";
            this.lblErrPassID.Size = new System.Drawing.Size(48, 13);
            this.lblErrPassID.TabIndex = 41;
            this.lblErrPassID.Text = "label16";
            this.lblErrPassID.Visible = false;
            this.lblErrPassID.Click += new System.EventHandler(this.lblErrPassID_Click);
            // 
            // lblErrDoB
            // 
            this.lblErrDoB.AutoSize = true;
            this.lblErrDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrDoB.ForeColor = System.Drawing.Color.Red;
            this.lblErrDoB.Location = new System.Drawing.Point(396, 201);
            this.lblErrDoB.Name = "lblErrDoB";
            this.lblErrDoB.Size = new System.Drawing.Size(48, 13);
            this.lblErrDoB.TabIndex = 42;
            this.lblErrDoB.Text = "label17";
            this.lblErrDoB.Visible = false;
            this.lblErrDoB.Click += new System.EventHandler(this.lblErrDoB_Click);
            // 
            // lblErrMobileNum
            // 
            this.lblErrMobileNum.AutoSize = true;
            this.lblErrMobileNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMobileNum.ForeColor = System.Drawing.Color.Red;
            this.lblErrMobileNum.Location = new System.Drawing.Point(399, 303);
            this.lblErrMobileNum.Name = "lblErrMobileNum";
            this.lblErrMobileNum.Size = new System.Drawing.Size(48, 13);
            this.lblErrMobileNum.TabIndex = 43;
            this.lblErrMobileNum.Text = "label18";
            this.lblErrMobileNum.Visible = false;
            this.lblErrMobileNum.Click += new System.EventHandler(this.lblErrMobileNum_Click);
            // 
            // lblErrStdProg
            // 
            this.lblErrStdProg.AutoSize = true;
            this.lblErrStdProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrStdProg.ForeColor = System.Drawing.Color.Red;
            this.lblErrStdProg.Location = new System.Drawing.Point(402, 396);
            this.lblErrStdProg.Name = "lblErrStdProg";
            this.lblErrStdProg.Size = new System.Drawing.Size(48, 13);
            this.lblErrStdProg.TabIndex = 44;
            this.lblErrStdProg.Text = "label19";
            this.lblErrStdProg.Visible = false;
            this.lblErrStdProg.Click += new System.EventHandler(this.lblErrStdProg_Click);
            // 
            // RegisterStudentModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 500);
            this.Controls.Add(this.lblErrStdProg);
            this.Controls.Add(this.lblErrMobileNum);
            this.Controls.Add(this.lblErrDoB);
            this.Controls.Add(this.lblErrPassID);
            this.Controls.Add(this.MobileTxtBox);
            this.Controls.Add(this.lblErrYoS);
            this.Controls.Add(this.lblErrEmail);
            this.Controls.Add(this.lblErrLName);
            this.Controls.Add(this.lblErrFName);
            this.Controls.Add(this.lblErrStdID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateOfBirthDateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.YearOfStudyComboBox1);
            this.Controls.Add(this.StudentProgrammeTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.IdPassportTxtBox);
            this.Controls.Add(this.studentIdTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterStudentModal";
            this.Load += new System.EventHandler(this.RegisterStudentModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIdTxtBox;
        private System.Windows.Forms.TextBox IdPassportTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox StudentProgrammeTxtBox;
        private System.Windows.Forms.ComboBox YearOfStudyComboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label lblErrStdID;
        private System.Windows.Forms.Label lblErrFName;
        private System.Windows.Forms.Label lblErrLName;
        private System.Windows.Forms.Label lblErrEmail;
        private System.Windows.Forms.Label lblErrYoS;
        private System.Windows.Forms.MaskedTextBox MobileTxtBox;
        private System.Windows.Forms.Label lblErrPassID;
        private System.Windows.Forms.Label lblErrDoB;
        private System.Windows.Forms.Label lblErrMobileNum;
        private System.Windows.Forms.Label lblErrStdProg;
    }
}