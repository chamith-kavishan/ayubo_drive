namespace AyuboDrive
{
    partial class dayTour
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonHireCal = new System.Windows.Forms.Button();
            this.buttonRentCal = new System.Windows.Forms.Button();
            this.buttonRates = new System.Windows.Forms.Button();
            this.buttonVehicleTypes = new System.Windows.Forms.Button();
            this.buttonVehicleType = new System.Windows.Forms.Button();
            this.buttonVehicles = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVehicle = new System.Windows.Forms.TextBox();
            this.labelVehicleType = new System.Windows.Forms.Label();
            this.comboBoxPackage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStartKm = new System.Windows.Forms.TextBox();
            this.textBoxEndKm = new System.Windows.Forms.TextBox();
            this.labelBaseHire = new System.Windows.Forms.Label();
            this.labelWaitingCharge = new System.Windows.Forms.Label();
            this.labelExtraKmCharge = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonHireCal);
            this.panel1.Controls.Add(this.buttonRentCal);
            this.panel1.Controls.Add(this.buttonRates);
            this.panel1.Controls.Add(this.buttonVehicleTypes);
            this.panel1.Controls.Add(this.buttonVehicleType);
            this.panel1.Controls.Add(this.buttonVehicles);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 767);
            this.panel1.TabIndex = 7;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonSettings.Image = global::AyuboDrive.Properties.Resources.settings;
            this.buttonSettings.Location = new System.Drawing.Point(0, 730);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(186, 42);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonHireCal
            // 
            this.buttonHireCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHireCal.FlatAppearance.BorderSize = 0;
            this.buttonHireCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHireCal.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHireCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonHireCal.Image = global::AyuboDrive.Properties.Resources.carsharing;
            this.buttonHireCal.Location = new System.Drawing.Point(0, 396);
            this.buttonHireCal.Name = "buttonHireCal";
            this.buttonHireCal.Size = new System.Drawing.Size(186, 42);
            this.buttonHireCal.TabIndex = 1;
            this.buttonHireCal.Text = "Hire Calculator";
            this.buttonHireCal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonHireCal.UseVisualStyleBackColor = true;
            this.buttonHireCal.Click += new System.EventHandler(this.buttonHireCal_Click);
            // 
            // buttonRentCal
            // 
            this.buttonRentCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRentCal.FlatAppearance.BorderSize = 0;
            this.buttonRentCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRentCal.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRentCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonRentCal.Image = global::AyuboDrive.Properties.Resources.car;
            this.buttonRentCal.Location = new System.Drawing.Point(0, 354);
            this.buttonRentCal.Name = "buttonRentCal";
            this.buttonRentCal.Size = new System.Drawing.Size(186, 42);
            this.buttonRentCal.TabIndex = 1;
            this.buttonRentCal.Text = "Rent Calculator";
            this.buttonRentCal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRentCal.UseVisualStyleBackColor = true;
            this.buttonRentCal.Click += new System.EventHandler(this.buttonRentCal_Click);
            // 
            // buttonRates
            // 
            this.buttonRates.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRates.FlatAppearance.BorderSize = 0;
            this.buttonRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRates.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonRates.Image = global::AyuboDrive.Properties.Resources.rating;
            this.buttonRates.Location = new System.Drawing.Point(0, 312);
            this.buttonRates.Name = "buttonRates";
            this.buttonRates.Size = new System.Drawing.Size(186, 42);
            this.buttonRates.TabIndex = 1;
            this.buttonRates.Text = "Rates";
            this.buttonRates.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRates.UseVisualStyleBackColor = true;
            this.buttonRates.Click += new System.EventHandler(this.buttonRates_Click);
            // 
            // buttonVehicleTypes
            // 
            this.buttonVehicleTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehicleTypes.FlatAppearance.BorderSize = 0;
            this.buttonVehicleTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleTypes.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonVehicleTypes.Image = global::AyuboDrive.Properties.Resources.box;
            this.buttonVehicleTypes.Location = new System.Drawing.Point(0, 270);
            this.buttonVehicleTypes.Name = "buttonVehicleTypes";
            this.buttonVehicleTypes.Size = new System.Drawing.Size(186, 42);
            this.buttonVehicleTypes.TabIndex = 1;
            this.buttonVehicleTypes.Text = "Packages";
            this.buttonVehicleTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonVehicleTypes.UseVisualStyleBackColor = true;
            this.buttonVehicleTypes.Click += new System.EventHandler(this.buttonVehicleTypes_Click);
            // 
            // buttonVehicleType
            // 
            this.buttonVehicleType.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehicleType.FlatAppearance.BorderSize = 0;
            this.buttonVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleType.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonVehicleType.Image = global::AyuboDrive.Properties.Resources.traffic_jam;
            this.buttonVehicleType.Location = new System.Drawing.Point(0, 228);
            this.buttonVehicleType.Name = "buttonVehicleType";
            this.buttonVehicleType.Size = new System.Drawing.Size(186, 42);
            this.buttonVehicleType.TabIndex = 1;
            this.buttonVehicleType.Text = "Vehicle Type";
            this.buttonVehicleType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonVehicleType.UseVisualStyleBackColor = true;
            this.buttonVehicleType.Click += new System.EventHandler(this.buttonVehicleType_Click);
            // 
            // buttonVehicles
            // 
            this.buttonVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehicles.FlatAppearance.BorderSize = 0;
            this.buttonVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicles.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonVehicles.Image = global::AyuboDrive.Properties.Resources.car__1_;
            this.buttonVehicles.Location = new System.Drawing.Point(0, 186);
            this.buttonVehicles.Name = "buttonVehicles";
            this.buttonVehicles.Size = new System.Drawing.Size(186, 42);
            this.buttonVehicles.TabIndex = 1;
            this.buttonVehicles.Text = "Vehicles";
            this.buttonVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonVehicles.UseVisualStyleBackColor = true;
            this.buttonVehicles.Click += new System.EventHandler(this.buttonVehicles_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonDashboard.Image = global::AyuboDrive.Properties.Resources.home;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 144);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(186, 42);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelUsername.Location = new System.Drawing.Point(42, 100);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(103, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AyuboDrive.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(221, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hire Calculator - Day Tour";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonBack.Location = new System.Drawing.Point(902, 37);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(186, 42);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Back";
            this.buttonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(225, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Please enter the following details to calculate the rent value.";
            // 
            // textBoxVehicle
            // 
            this.textBoxVehicle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVehicle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxVehicle.Location = new System.Drawing.Point(491, 214);
            this.textBoxVehicle.Name = "textBoxVehicle";
            this.textBoxVehicle.Size = new System.Drawing.Size(321, 23);
            this.textBoxVehicle.TabIndex = 52;
            this.textBoxVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelVehicleType.Location = new System.Drawing.Point(263, 209);
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(119, 28);
            this.labelVehicleType.TabIndex = 51;
            this.labelVehicleType.Text = "Vehicle No.";
            this.labelVehicleType.Click += new System.EventHandler(this.labelVehicleType_Click);
            // 
            // comboBoxPackage
            // 
            this.comboBoxPackage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPackage.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPackage.FormattingEnabled = true;
            this.comboBoxPackage.Location = new System.Drawing.Point(491, 260);
            this.comboBoxPackage.Name = "comboBoxPackage";
            this.comboBoxPackage.Size = new System.Drawing.Size(321, 31);
            this.comboBoxPackage.TabIndex = 55;
            this.comboBoxPackage.SelectedIndexChanged += new System.EventHandler(this.comboBoxPackage_SelectedIndexChanged);
            this.comboBoxPackage.Click += new System.EventHandler(this.comboBoxPackage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(263, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 54;
            this.label5.Text = "Package";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CalendarForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dateTimePickerStartTime.CalendarMonthBackground = System.Drawing.Color.IndianRed;
            this.dateTimePickerStartTime.CalendarTitleBackColor = System.Drawing.Color.IndianRed;
            this.dateTimePickerStartTime.CalendarTitleForeColor = System.Drawing.Color.IndianRed;
            this.dateTimePickerStartTime.CalendarTrailingForeColor = System.Drawing.Color.IndianRed;
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(491, 312);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(321, 22);
            this.dateTimePickerStartTime.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(263, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 56;
            this.label4.Text = "Start Time";
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CalendarForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dateTimePickerEndTime.CalendarMonthBackground = System.Drawing.Color.IndianRed;
            this.dateTimePickerEndTime.CalendarTitleBackColor = System.Drawing.Color.IndianRed;
            this.dateTimePickerEndTime.CalendarTitleForeColor = System.Drawing.Color.IndianRed;
            this.dateTimePickerEndTime.CalendarTrailingForeColor = System.Drawing.Color.IndianRed;
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(491, 354);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(321, 22);
            this.dateTimePickerEndTime.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(263, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 58;
            this.label6.Text = "End Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(263, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 28);
            this.label7.TabIndex = 60;
            this.label7.Text = "Sart Km Reading";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(263, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 28);
            this.label8.TabIndex = 62;
            this.label8.Text = "End Km Reading";
            // 
            // textBoxStartKm
            // 
            this.textBoxStartKm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxStartKm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartKm.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxStartKm.Location = new System.Drawing.Point(491, 400);
            this.textBoxStartKm.Name = "textBoxStartKm";
            this.textBoxStartKm.Size = new System.Drawing.Size(321, 23);
            this.textBoxStartKm.TabIndex = 63;
            this.textBoxStartKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEndKm
            // 
            this.textBoxEndKm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxEndKm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEndKm.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxEndKm.Location = new System.Drawing.Point(491, 448);
            this.textBoxEndKm.Name = "textBoxEndKm";
            this.textBoxEndKm.Size = new System.Drawing.Size(321, 23);
            this.textBoxEndKm.TabIndex = 64;
            this.textBoxEndKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBaseHire
            // 
            this.labelBaseHire.AutoSize = true;
            this.labelBaseHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaseHire.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelBaseHire.Location = new System.Drawing.Point(224, 538);
            this.labelBaseHire.Name = "labelBaseHire";
            this.labelBaseHire.Size = new System.Drawing.Size(182, 25);
            this.labelBaseHire.TabIndex = 65;
            this.labelBaseHire.Text = "Base hire charge:";
            // 
            // labelWaitingCharge
            // 
            this.labelWaitingCharge.AutoSize = true;
            this.labelWaitingCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaitingCharge.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelWaitingCharge.Location = new System.Drawing.Point(225, 592);
            this.labelWaitingCharge.Name = "labelWaitingCharge";
            this.labelWaitingCharge.Size = new System.Drawing.Size(164, 25);
            this.labelWaitingCharge.TabIndex = 66;
            this.labelWaitingCharge.Text = "Waiting charge:";
            // 
            // labelExtraKmCharge
            // 
            this.labelExtraKmCharge.AutoSize = true;
            this.labelExtraKmCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraKmCharge.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelExtraKmCharge.Location = new System.Drawing.Point(225, 640);
            this.labelExtraKmCharge.Name = "labelExtraKmCharge";
            this.labelExtraKmCharge.Size = new System.Drawing.Size(179, 25);
            this.labelExtraKmCharge.TabIndex = 67;
            this.labelExtraKmCharge.Text = "Extra Km charge:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelTotal.Location = new System.Drawing.Point(225, 689);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(168, 25);
            this.labelTotal.TabIndex = 68;
            this.labelTotal.Text = "Total hire value:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonCalculate.Location = new System.Drawing.Point(824, 530);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(186, 42);
            this.buttonCalculate.TabIndex = 69;
            this.buttonCalculate.Text = "Calculate Hire";
            this.buttonCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.Image = global::AyuboDrive.Properties.Resources.icons8_macos_minimize_902;
            this.button1.Location = new System.Drawing.Point(1105, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.Image = global::AyuboDrive.Properties.Resources.icons8_macos_close_901;
            this.button2.Location = new System.Drawing.Point(1147, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 38);
            this.button2.TabIndex = 72;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dayTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1188, 767);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelExtraKmCharge);
            this.Controls.Add(this.labelWaitingCharge);
            this.Controls.Add(this.labelBaseHire);
            this.Controls.Add(this.textBoxEndKm);
            this.Controls.Add(this.textBoxStartKm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPackage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVehicle);
            this.Controls.Add(this.labelVehicleType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dayTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dayTour";
            this.Load += new System.EventHandler(this.dayTour_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonHireCal;
        private System.Windows.Forms.Button buttonRentCal;
        private System.Windows.Forms.Button buttonRates;
        private System.Windows.Forms.Button buttonVehicleTypes;
        private System.Windows.Forms.Button buttonVehicleType;
        private System.Windows.Forms.Button buttonVehicles;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVehicle;
        private System.Windows.Forms.Label labelVehicleType;
        private System.Windows.Forms.ComboBox comboBoxPackage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStartKm;
        private System.Windows.Forms.TextBox textBoxEndKm;
        private System.Windows.Forms.Label labelBaseHire;
        private System.Windows.Forms.Label labelWaitingCharge;
        private System.Windows.Forms.Label labelExtraKmCharge;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}