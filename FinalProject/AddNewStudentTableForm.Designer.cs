namespace FinalProject
{
    partial class AddNewStudentTableForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newStudentAndTasksDatabaseDataSet = new FinalProject.NewStudentAndTasksDatabaseDataSet();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.englishNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.airlineTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.housingTextBox = new System.Windows.Forms.TextBox();
            this.commentLBL = new System.Windows.Forms.Label();
            this.housingLBL = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.flightNumberTextBox = new System.Windows.Forms.TextBox();
            this.noHousingRadioButton = new System.Windows.Forms.RadioButton();
            this.yesHousingRadioButton = new System.Windows.Forms.RadioButton();
            this.DOB_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivalDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noTransportationRadioButton = new System.Windows.Forms.RadioButton();
            this.yesTransportationRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.arrivalTimeDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new FinalProject.NewStudentAndTasksDatabaseDataSetTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentAndTasksDatabaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(211, 42);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "Student";
            this.studentTableBindingSource.DataSource = this.newStudentAndTasksDatabaseDataSet;
            // 
            // newStudentAndTasksDatabaseDataSet
            // 
            this.newStudentAndTasksDatabaseDataSet.DataSetName = "NewStudentAndTasksDatabaseDataSet";
            this.newStudentAndTasksDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(444, 502);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(142, 73);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "First (Given) Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last (Family) Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(211, 93);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // englishNameTextBox
            // 
            this.englishNameTextBox.Location = new System.Drawing.Point(211, 143);
            this.englishNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.englishNameTextBox.Name = "englishNameTextBox";
            this.englishNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.englishNameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(91, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "English Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(144, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(99, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(131, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(656, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Airline:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(548, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Flight Number into SGF:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(211, 294);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(160, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(620, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Arrival Date:";
            // 
            // airlineTextBox
            // 
            this.airlineTextBox.Location = new System.Drawing.Point(725, 143);
            this.airlineTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.airlineTextBox.Name = "airlineTextBox";
            this.airlineTextBox.Size = new System.Drawing.Size(208, 22);
            this.airlineTextBox.TabIndex = 9;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(725, 330);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(208, 102);
            this.commentsTextBox.TabIndex = 16;
            // 
            // housingTextBox
            // 
            this.housingTextBox.Location = new System.Drawing.Point(727, 452);
            this.housingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.housingTextBox.Multiline = true;
            this.housingTextBox.Name = "housingTextBox";
            this.housingTextBox.Size = new System.Drawing.Size(206, 71);
            this.housingTextBox.TabIndex = 15;
            this.housingTextBox.Visible = false;
            // 
            // commentLBL
            // 
            this.commentLBL.AutoSize = true;
            this.commentLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentLBL.Location = new System.Drawing.Point(628, 333);
            this.commentLBL.Name = "commentLBL";
            this.commentLBL.Size = new System.Drawing.Size(78, 17);
            this.commentLBL.TabIndex = 27;
            this.commentLBL.Text = "Comments:";
            // 
            // housingLBL
            // 
            this.housingLBL.AutoSize = true;
            this.housingLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.housingLBL.Location = new System.Drawing.Point(484, 452);
            this.housingLBL.Name = "housingLBL";
            this.housingLBL.Size = new System.Drawing.Size(225, 17);
            this.housingLBL.TabIndex = 25;
            this.housingLBL.Text = "Temporary housing/hotel address:";
            this.housingLBL.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(489, 294);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(219, 17);
            this.label19.TabIndex = 23;
            this.label19.Text = "Do you need temporary housing?";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(476, 244);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(234, 17);
            this.label20.TabIndex = 22;
            this.label20.Text = "Do you need airport transportation?";
            // 
            // flightNumberTextBox
            // 
            this.flightNumberTextBox.Location = new System.Drawing.Point(725, 190);
            this.flightNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flightNumberTextBox.Name = "flightNumberTextBox";
            this.flightNumberTextBox.Size = new System.Drawing.Size(208, 22);
            this.flightNumberTextBox.TabIndex = 10;
            // 
            // noHousingRadioButton
            // 
            this.noHousingRadioButton.AutoSize = true;
            this.noHousingRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.noHousingRadioButton.Location = new System.Drawing.Point(87, 14);
            this.noHousingRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.noHousingRadioButton.Name = "noHousingRadioButton";
            this.noHousingRadioButton.Size = new System.Drawing.Size(47, 21);
            this.noHousingRadioButton.TabIndex = 14;
            this.noHousingRadioButton.TabStop = true;
            this.noHousingRadioButton.Text = "No";
            this.noHousingRadioButton.UseVisualStyleBackColor = true;
            this.noHousingRadioButton.CheckedChanged += new System.EventHandler(this.noHousingRadioButton_CheckedChanged);
            // 
            // yesHousingRadioButton
            // 
            this.yesHousingRadioButton.AutoSize = true;
            this.yesHousingRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yesHousingRadioButton.Location = new System.Drawing.Point(9, 14);
            this.yesHousingRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.yesHousingRadioButton.Name = "yesHousingRadioButton";
            this.yesHousingRadioButton.Size = new System.Drawing.Size(53, 21);
            this.yesHousingRadioButton.TabIndex = 13;
            this.yesHousingRadioButton.TabStop = true;
            this.yesHousingRadioButton.Text = "Yes";
            this.yesHousingRadioButton.UseVisualStyleBackColor = true;
            this.yesHousingRadioButton.CheckedChanged += new System.EventHandler(this.yesHousingRadioButton_CheckedChanged);
            // 
            // DOB_DateTimePicker
            // 
            this.DOB_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB_DateTimePicker.Location = new System.Drawing.Point(211, 194);
            this.DOB_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DOB_DateTimePicker.MaxDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DOB_DateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DOB_DateTimePicker.Name = "DOB_DateTimePicker";
            this.DOB_DateTimePicker.Size = new System.Drawing.Size(160, 22);
            this.DOB_DateTimePicker.TabIndex = 3;
            this.DOB_DateTimePicker.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // arrivalDateDateTimePicker
            // 
            this.arrivalDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrivalDateDateTimePicker.Location = new System.Drawing.Point(725, 42);
            this.arrivalDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.arrivalDateDateTimePicker.MinDate = new System.DateTime(2016, 5, 10, 0, 0, 0, 0);
            this.arrivalDateDateTimePicker.Name = "arrivalDateDateTimePicker";
            this.arrivalDateDateTimePicker.Size = new System.Drawing.Size(208, 22);
            this.arrivalDateDateTimePicker.TabIndex = 7;
            this.arrivalDateDateTimePicker.Value = new System.DateTime(2016, 5, 10, 0, 0, 0, 0);
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Identified"});
            this.genderComboBox.Location = new System.Drawing.Point(211, 248);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(160, 24);
            this.genderComboBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noTransportationRadioButton);
            this.groupBox1.Controls.Add(this.yesTransportationRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(725, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(208, 41);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // noTransportationRadioButton
            // 
            this.noTransportationRadioButton.AutoSize = true;
            this.noTransportationRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.noTransportationRadioButton.Location = new System.Drawing.Point(87, 16);
            this.noTransportationRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.noTransportationRadioButton.Name = "noTransportationRadioButton";
            this.noTransportationRadioButton.Size = new System.Drawing.Size(47, 21);
            this.noTransportationRadioButton.TabIndex = 12;
            this.noTransportationRadioButton.TabStop = true;
            this.noTransportationRadioButton.Text = "No";
            this.noTransportationRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesTransportationRadioButton
            // 
            this.yesTransportationRadioButton.AutoSize = true;
            this.yesTransportationRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yesTransportationRadioButton.Location = new System.Drawing.Point(9, 16);
            this.yesTransportationRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.yesTransportationRadioButton.Name = "yesTransportationRadioButton";
            this.yesTransportationRadioButton.Size = new System.Drawing.Size(53, 21);
            this.yesTransportationRadioButton.TabIndex = 11;
            this.yesTransportationRadioButton.TabStop = true;
            this.yesTransportationRadioButton.Text = "Yes";
            this.yesTransportationRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noHousingRadioButton);
            this.groupBox2.Controls.Add(this.yesHousingRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(725, 276);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(208, 40);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // arrivalTimeDateTimePicker1
            // 
            this.arrivalTimeDateTimePicker1.CustomFormat = "hh:mm tt";
            this.arrivalTimeDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTimeDateTimePicker1.Location = new System.Drawing.Point(725, 93);
            this.arrivalTimeDateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.arrivalTimeDateTimePicker1.Name = "arrivalTimeDateTimePicker1";
            this.arrivalTimeDateTimePicker1.ShowUpDown = true;
            this.arrivalTimeDateTimePicker1.Size = new System.Drawing.Size(208, 22);
            this.arrivalTimeDateTimePicker1.TabIndex = 8;
            this.arrivalTimeDateTimePicker1.Value = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(620, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Arrival Time:";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewStudentTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(1031, 580);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.arrivalTimeDateTimePicker1);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.arrivalDateDateTimePicker);
            this.Controls.Add(this.DOB_DateTimePicker);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.housingTextBox);
            this.Controls.Add(this.commentLBL);
            this.Controls.Add(this.housingLBL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.flightNumberTextBox);
            this.Controls.Add(this.airlineTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.englishNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewStudentTableForm";
            this.Text = "Student Table";
            this.Load += new System.EventHandler(this.AddNewStudentTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentAndTasksDatabaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox englishNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox airlineTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox housingTextBox;
        private System.Windows.Forms.Label commentLBL;
        private System.Windows.Forms.Label housingLBL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox flightNumberTextBox;
        private System.Windows.Forms.RadioButton noHousingRadioButton;
        private System.Windows.Forms.RadioButton yesHousingRadioButton;
        private System.Windows.Forms.DateTimePicker DOB_DateTimePicker;
        private System.Windows.Forms.DateTimePicker arrivalDateDateTimePicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton noTransportationRadioButton;
        private System.Windows.Forms.RadioButton yesTransportationRadioButton;
        private System.Windows.Forms.DateTimePicker arrivalTimeDateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private NewStudentAndTasksDatabaseDataSet newStudentAndTasksDatabaseDataSet;
        private NewStudentAndTasksDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}