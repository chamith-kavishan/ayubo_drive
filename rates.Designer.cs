namespace AyuboDrive
{
    partial class FormRates
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVehicleNightParkRate = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxDriverOvernightRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExtraHourRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExtraKmRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPackage = new System.Windows.Forms.Label();
            this.comboBoxPackage = new System.Windows.Forms.ComboBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dataGridViewRates = new System.Windows.Forms.DataGridView();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRates)).BeginInit();
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
            this.panel1.TabIndex = 5;
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
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
            this.label2.Size = new System.Drawing.Size(113, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rates";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(373, 646);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Vehicle Night Park Rate";
            // 
            // textBoxVehicleNightParkRate
            // 
            this.textBoxVehicleNightParkRate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxVehicleNightParkRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVehicleNightParkRate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxVehicleNightParkRate.Location = new System.Drawing.Point(633, 651);
            this.textBoxVehicleNightParkRate.Name = "textBoxVehicleNightParkRate";
            this.textBoxVehicleNightParkRate.Size = new System.Drawing.Size(321, 23);
            this.textBoxVehicleNightParkRate.TabIndex = 41;
            this.textBoxVehicleNightParkRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVehicleNightParkRate.TextChanged += new System.EventHandler(this.textBoxPackageCost_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonDelete.Location = new System.Drawing.Point(884, 701);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(186, 42);
            this.buttonDelete.TabIndex = 40;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonUpdate.Location = new System.Drawing.Point(591, 701);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(186, 42);
            this.buttonUpdate.TabIndex = 39;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonInsert.Location = new System.Drawing.Point(293, 701);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(186, 42);
            this.buttonInsert.TabIndex = 38;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxDriverOvernightRate
            // 
            this.textBoxDriverOvernightRate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDriverOvernightRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDriverOvernightRate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxDriverOvernightRate.Location = new System.Drawing.Point(633, 605);
            this.textBoxDriverOvernightRate.Name = "textBoxDriverOvernightRate";
            this.textBoxDriverOvernightRate.Size = new System.Drawing.Size(321, 23);
            this.textBoxDriverOvernightRate.TabIndex = 37;
            this.textBoxDriverOvernightRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(373, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Driver Overnight Rate";
            // 
            // textBoxExtraHourRate
            // 
            this.textBoxExtraHourRate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxExtraHourRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExtraHourRate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxExtraHourRate.Location = new System.Drawing.Point(633, 563);
            this.textBoxExtraHourRate.Name = "textBoxExtraHourRate";
            this.textBoxExtraHourRate.Size = new System.Drawing.Size(321, 23);
            this.textBoxExtraHourRate.TabIndex = 35;
            this.textBoxExtraHourRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(373, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Extra Hour Rate";
            // 
            // textBoxExtraKmRate
            // 
            this.textBoxExtraKmRate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxExtraKmRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExtraKmRate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxExtraKmRate.Location = new System.Drawing.Point(633, 518);
            this.textBoxExtraKmRate.Name = "textBoxExtraKmRate";
            this.textBoxExtraKmRate.Size = new System.Drawing.Size(321, 23);
            this.textBoxExtraKmRate.TabIndex = 33;
            this.textBoxExtraKmRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(373, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Extra Km Rate";
            // 
            // labelPackage
            // 
            this.labelPackage.AutoSize = true;
            this.labelPackage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPackage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPackage.Location = new System.Drawing.Point(373, 466);
            this.labelPackage.Name = "labelPackage";
            this.labelPackage.Size = new System.Drawing.Size(89, 28);
            this.labelPackage.TabIndex = 31;
            this.labelPackage.Text = "Package";
            // 
            // comboBoxPackage
            // 
            this.comboBoxPackage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPackage.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPackage.FormattingEnabled = true;
            this.comboBoxPackage.Location = new System.Drawing.Point(633, 468);
            this.comboBoxPackage.Name = "comboBoxPackage";
            this.comboBoxPackage.Size = new System.Drawing.Size(321, 31);
            this.comboBoxPackage.TabIndex = 30;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelUsername.Location = new System.Drawing.Point(42, 100);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(103, 20);
            this.labelUsername.TabIndex = 43;
            this.labelUsername.Text = "User Name";
            // 
            // dataGridViewRates
            // 
            this.dataGridViewRates.AllowUserToAddRows = false;
            this.dataGridViewRates.AllowUserToDeleteRows = false;
            this.dataGridViewRates.AllowUserToResizeColumns = false;
            this.dataGridViewRates.AllowUserToResizeRows = false;
            this.dataGridViewRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewRates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRates.EnableHeadersVisualStyles = false;
            this.dataGridViewRates.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewRates.Location = new System.Drawing.Point(228, 151);
            this.dataGridViewRates.Name = "dataGridViewRates";
            this.dataGridViewRates.ReadOnly = true;
            this.dataGridViewRates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRates.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRates.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewRates.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRates.RowTemplate.Height = 24;
            this.dataGridViewRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRates.Size = new System.Drawing.Size(877, 287);
            this.dataGridViewRates.TabIndex = 44;
            this.dataGridViewRates.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRates_RowHeaderMouseClick);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonMinimize.Image = global::AyuboDrive.Properties.Resources.icons8_macos_minimize_902;
            this.buttonMinimize.Location = new System.Drawing.Point(1102, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(40, 38);
            this.buttonMinimize.TabIndex = 46;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonClose.Image = global::AyuboDrive.Properties.Resources.icons8_macos_close_901;
            this.buttonClose.Location = new System.Drawing.Point(1144, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 38);
            this.buttonClose.TabIndex = 45;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // FormRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1188, 767);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewRates);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVehicleNightParkRate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxDriverOvernightRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxExtraHourRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxExtraKmRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPackage);
            this.Controls.Add(this.comboBoxPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rates";
            this.Load += new System.EventHandler(this.FormRates_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRates)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVehicleNightParkRate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxDriverOvernightRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxExtraHourRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExtraKmRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPackage;
        private System.Windows.Forms.ComboBox comboBoxPackage;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DataGridView dataGridViewRates;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
    }
}