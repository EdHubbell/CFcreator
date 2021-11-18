namespace XC_Common
{
    partial class ucLEDDriverDiagnostics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipGreen = new System.Windows.Forms.NumericUpDown();
            this.ipBlue = new System.Windows.Forms.NumericUpDown();
            this.ipRedPct = new System.Windows.Forms.NumericUpDown();
            this.btnSetBlue = new System.Windows.Forms.Button();
            this.btnSetGreen = new System.Windows.Forms.Button();
            this.btnSetRed = new System.Windows.Forms.Button();
            this.btnSetBlueOnly = new System.Windows.Forms.Button();
            this.btnSetGreenOnly = new System.Windows.Forms.Button();
            this.btnSetRedOnly = new System.Windows.Forms.Button();
            this.btnInitDriver = new System.Windows.Forms.Button();
            this.cboRedCurrent = new System.Windows.Forms.ComboBox();
            this.cboGreenCurrent = new System.Windows.Forms.ComboBox();
            this.cboBlueCurrent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSendRawHexToAddress = new System.Windows.Forms.GroupBox();
            this.btnSendHexValue = new System.Windows.Forms.Button();
            this.txtRawHexValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRawHexAddress = new System.Windows.Forms.ComboBox();
            this.txtBinaryIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHexIn = new System.Windows.Forms.TextBox();
            this.txtHexOut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBinaryOut = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBitsRed = new System.Windows.Forms.TextBox();
            this.txtBitsGreen = new System.Windows.Forms.TextBox();
            this.txtBitsBlue = new System.Windows.Forms.TextBox();
            this.txtHexRed = new System.Windows.Forms.TextBox();
            this.txtHexGreen = new System.Windows.Forms.TextBox();
            this.txtHexBlue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnInitArduinoDriver = new System.Windows.Forms.Button();
            this.btnReadVfs = new System.Windows.Forms.Button();
            this.txtVfs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ipGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipRedPct)).BeginInit();
            this.gbSendRawHexToAddress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipGreen
            // 
            this.ipGreen.DecimalPlaces = 2;
            this.ipGreen.Location = new System.Drawing.Point(146, 187);
            this.ipGreen.Name = "ipGreen";
            this.ipGreen.Size = new System.Drawing.Size(56, 23);
            this.ipGreen.TabIndex = 24;
            this.ipGreen.ValueChanged += new System.EventHandler(this.ipGreen_ValueChanged);
            // 
            // ipBlue
            // 
            this.ipBlue.DecimalPlaces = 2;
            this.ipBlue.Location = new System.Drawing.Point(278, 187);
            this.ipBlue.Name = "ipBlue";
            this.ipBlue.Size = new System.Drawing.Size(56, 23);
            this.ipBlue.TabIndex = 23;
            this.ipBlue.ValueChanged += new System.EventHandler(this.ipBlue_ValueChanged);
            // 
            // ipRedPct
            // 
            this.ipRedPct.DecimalPlaces = 2;
            this.ipRedPct.Location = new System.Drawing.Point(14, 187);
            this.ipRedPct.Name = "ipRedPct";
            this.ipRedPct.Size = new System.Drawing.Size(56, 23);
            this.ipRedPct.TabIndex = 22;
            this.ipRedPct.ValueChanged += new System.EventHandler(this.ipRedPct_ValueChanged);
            // 
            // btnSetBlue
            // 
            this.btnSetBlue.Location = new System.Drawing.Point(278, 133);
            this.btnSetBlue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSetBlue.Name = "btnSetBlue";
            this.btnSetBlue.Size = new System.Drawing.Size(126, 30);
            this.btnSetBlue.TabIndex = 21;
            this.btnSetBlue.Text = "Set Blue (#XP56)";
            this.btnSetBlue.UseVisualStyleBackColor = true;
            this.btnSetBlue.Click += new System.EventHandler(this.BtnSetBlue_Click);
            // 
            // btnSetGreen
            // 
            this.btnSetGreen.Location = new System.Drawing.Point(146, 133);
            this.btnSetGreen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSetGreen.Name = "btnSetGreen";
            this.btnSetGreen.Size = new System.Drawing.Size(126, 30);
            this.btnSetGreen.TabIndex = 20;
            this.btnSetGreen.Text = "Set Green (#XP55)";
            this.btnSetGreen.UseVisualStyleBackColor = true;
            this.btnSetGreen.Click += new System.EventHandler(this.BtnSetGreen_Click);
            // 
            // btnSetRed
            // 
            this.btnSetRed.Location = new System.Drawing.Point(14, 132);
            this.btnSetRed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSetRed.Name = "btnSetRed";
            this.btnSetRed.Size = new System.Drawing.Size(126, 30);
            this.btnSetRed.TabIndex = 19;
            this.btnSetRed.Text = "Set Red (#XP54)";
            this.btnSetRed.UseVisualStyleBackColor = true;
            this.btnSetRed.Click += new System.EventHandler(this.BtnSetRed_Click);
            // 
            // btnSetBlueOnly
            // 
            this.btnSetBlueOnly.Location = new System.Drawing.Point(278, 96);
            this.btnSetBlueOnly.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSetBlueOnly.Name = "btnSetBlueOnly";
            this.btnSetBlueOnly.Size = new System.Drawing.Size(126, 30);
            this.btnSetBlueOnly.TabIndex = 18;
            this.btnSetBlueOnly.Text = "Set Blue Only";
            this.btnSetBlueOnly.UseVisualStyleBackColor = true;
            this.btnSetBlueOnly.Click += new System.EventHandler(this.BtnSetBlueOnly_Click);
            // 
            // btnSetGreenOnly
            // 
            this.btnSetGreenOnly.Location = new System.Drawing.Point(146, 96);
            this.btnSetGreenOnly.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSetGreenOnly.Name = "btnSetGreenOnly";
            this.btnSetGreenOnly.Size = new System.Drawing.Size(126, 30);
            this.btnSetGreenOnly.TabIndex = 17;
            this.btnSetGreenOnly.Text = "Set Green Only";
            this.btnSetGreenOnly.UseVisualStyleBackColor = true;
            this.btnSetGreenOnly.Click += new System.EventHandler(this.BtnSetGreenOnly_Click);
            // 
            // btnSetRedOnly
            // 
            this.btnSetRedOnly.Location = new System.Drawing.Point(14, 96);
            this.btnSetRedOnly.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSetRedOnly.Name = "btnSetRedOnly";
            this.btnSetRedOnly.Size = new System.Drawing.Size(126, 30);
            this.btnSetRedOnly.TabIndex = 16;
            this.btnSetRedOnly.Text = "Set Red Only";
            this.btnSetRedOnly.UseVisualStyleBackColor = true;
            this.btnSetRedOnly.Click += new System.EventHandler(this.BtnSetRedOnly_Click);
            // 
            // btnInitDriver
            // 
            this.btnInitDriver.Location = new System.Drawing.Point(14, 14);
            this.btnInitDriver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInitDriver.Name = "btnInitDriver";
            this.btnInitDriver.Size = new System.Drawing.Size(126, 74);
            this.btnInitDriver.TabIndex = 15;
            this.btnInitDriver.Text = "Intitalize Driver";
            this.btnInitDriver.UseVisualStyleBackColor = true;
            this.btnInitDriver.Click += new System.EventHandler(this.BtnInitDriver_Click);
            // 
            // cboRedCurrent
            // 
            this.cboRedCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRedCurrent.FormattingEnabled = true;
            this.cboRedCurrent.Items.AddRange(new object[] {
            "1",
            "3",
            "10",
            "30"});
            this.cboRedCurrent.Location = new System.Drawing.Point(76, 187);
            this.cboRedCurrent.Name = "cboRedCurrent";
            this.cboRedCurrent.Size = new System.Drawing.Size(64, 23);
            this.cboRedCurrent.TabIndex = 29;
            this.cboRedCurrent.SelectedIndexChanged += new System.EventHandler(this.cboRedCurrent_SelectedIndexChanged);
            // 
            // cboGreenCurrent
            // 
            this.cboGreenCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGreenCurrent.FormattingEnabled = true;
            this.cboGreenCurrent.Items.AddRange(new object[] {
            "1",
            "3",
            "10",
            "30"});
            this.cboGreenCurrent.Location = new System.Drawing.Point(208, 186);
            this.cboGreenCurrent.Name = "cboGreenCurrent";
            this.cboGreenCurrent.Size = new System.Drawing.Size(64, 23);
            this.cboGreenCurrent.TabIndex = 31;
            this.cboGreenCurrent.SelectedIndexChanged += new System.EventHandler(this.cboGreenCurrent_SelectedIndexChanged);
            // 
            // cboBlueCurrent
            // 
            this.cboBlueCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBlueCurrent.FormattingEnabled = true;
            this.cboBlueCurrent.Items.AddRange(new object[] {
            "1",
            "3",
            "10",
            "30"});
            this.cboBlueCurrent.Location = new System.Drawing.Point(340, 186);
            this.cboBlueCurrent.Name = "cboBlueCurrent";
            this.cboBlueCurrent.Size = new System.Drawing.Size(64, 23);
            this.cboBlueCurrent.TabIndex = 33;
            this.cboBlueCurrent.SelectedIndexChanged += new System.EventHandler(this.cboBlueCurrent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Red uA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Green uA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Blue uA";
            // 
            // gbSendRawHexToAddress
            // 
            this.gbSendRawHexToAddress.Controls.Add(this.btnSendHexValue);
            this.gbSendRawHexToAddress.Controls.Add(this.txtRawHexValue);
            this.gbSendRawHexToAddress.Controls.Add(this.label5);
            this.gbSendRawHexToAddress.Controls.Add(this.label4);
            this.gbSendRawHexToAddress.Controls.Add(this.cboRawHexAddress);
            this.gbSendRawHexToAddress.Location = new System.Drawing.Point(146, 14);
            this.gbSendRawHexToAddress.Name = "gbSendRawHexToAddress";
            this.gbSendRawHexToAddress.Size = new System.Drawing.Size(258, 74);
            this.gbSendRawHexToAddress.TabIndex = 37;
            this.gbSendRawHexToAddress.TabStop = false;
            this.gbSendRawHexToAddress.Text = "Send Hex to Address";
            // 
            // btnSendHexValue
            // 
            this.btnSendHexValue.Location = new System.Drawing.Point(160, 16);
            this.btnSendHexValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSendHexValue.Name = "btnSendHexValue";
            this.btnSendHexValue.Size = new System.Drawing.Size(92, 53);
            this.btnSendHexValue.TabIndex = 34;
            this.btnSendHexValue.Text = "Send Hex Value";
            this.btnSendHexValue.UseVisualStyleBackColor = true;
            this.btnSendHexValue.Click += new System.EventHandler(this.btnSendHexValue_Click);
            // 
            // txtRawHexValue
            // 
            this.txtRawHexValue.Location = new System.Drawing.Point(85, 46);
            this.txtRawHexValue.Name = "txtRawHexValue";
            this.txtRawHexValue.Size = new System.Drawing.Size(69, 23);
            this.txtRawHexValue.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Hex Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address";
            // 
            // cboRawHexAddress
            // 
            this.cboRawHexAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRawHexAddress.FormattingEnabled = true;
            this.cboRawHexAddress.Items.AddRange(new object[] {
            "#XP52",
            "#XP53",
            "#XP54",
            "#XP55",
            "#XP56",
            "#XP57",
            "#XP58"});
            this.cboRawHexAddress.Location = new System.Drawing.Point(85, 17);
            this.cboRawHexAddress.Name = "cboRawHexAddress";
            this.cboRawHexAddress.Size = new System.Drawing.Size(69, 23);
            this.cboRawHexAddress.TabIndex = 30;
            // 
            // txtBinaryIn
            // 
            this.txtBinaryIn.Location = new System.Drawing.Point(8, 45);
            this.txtBinaryIn.Name = "txtBinaryIn";
            this.txtBinaryIn.Size = new System.Drawing.Size(114, 23);
            this.txtBinaryIn.TabIndex = 38;
            this.txtBinaryIn.Text = "0000000000000000";
            this.txtBinaryIn.TextChanged += new System.EventHandler(this.txtBinaryIn_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "16 Bit Input";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Hex";
            // 
            // txtHexIn
            // 
            this.txtHexIn.Location = new System.Drawing.Point(217, 45);
            this.txtHexIn.Name = "txtHexIn";
            this.txtHexIn.Size = new System.Drawing.Size(64, 23);
            this.txtHexIn.TabIndex = 41;
            this.txtHexIn.Text = "FFFF";
            this.txtHexIn.TextChanged += new System.EventHandler(this.txtHexIn_TextChanged);
            // 
            // txtHexOut
            // 
            this.txtHexOut.Location = new System.Drawing.Point(128, 45);
            this.txtHexOut.Name = "txtHexOut";
            this.txtHexOut.ReadOnly = true;
            this.txtHexOut.Size = new System.Drawing.Size(64, 23);
            this.txtHexOut.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Hex Input";
            // 
            // txtBinaryOut
            // 
            this.txtBinaryOut.Location = new System.Drawing.Point(284, 45);
            this.txtBinaryOut.Name = "txtBinaryOut";
            this.txtBinaryOut.ReadOnly = true;
            this.txtBinaryOut.Size = new System.Drawing.Size(114, 23);
            this.txtBinaryOut.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "16 Bit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBinaryIn);
            this.groupBox1.Controls.Add(this.txtBinaryOut);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHexIn);
            this.groupBox1.Controls.Add(this.txtHexOut);
            this.groupBox1.Location = new System.Drawing.Point(3, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 76);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Helper";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "Red %";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "Green %";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 49;
            this.label12.Text = "Blue %";
            // 
            // txtBitsRed
            // 
            this.txtBitsRed.Location = new System.Drawing.Point(14, 216);
            this.txtBitsRed.Name = "txtBitsRed";
            this.txtBitsRed.ReadOnly = true;
            this.txtBitsRed.Size = new System.Drawing.Size(126, 23);
            this.txtBitsRed.TabIndex = 50;
            // 
            // txtBitsGreen
            // 
            this.txtBitsGreen.Location = new System.Drawing.Point(146, 216);
            this.txtBitsGreen.Name = "txtBitsGreen";
            this.txtBitsGreen.ReadOnly = true;
            this.txtBitsGreen.Size = new System.Drawing.Size(126, 23);
            this.txtBitsGreen.TabIndex = 51;
            // 
            // txtBitsBlue
            // 
            this.txtBitsBlue.Location = new System.Drawing.Point(278, 216);
            this.txtBitsBlue.Name = "txtBitsBlue";
            this.txtBitsBlue.ReadOnly = true;
            this.txtBitsBlue.Size = new System.Drawing.Size(126, 23);
            this.txtBitsBlue.TabIndex = 52;
            // 
            // txtHexRed
            // 
            this.txtHexRed.Location = new System.Drawing.Point(76, 245);
            this.txtHexRed.Name = "txtHexRed";
            this.txtHexRed.ReadOnly = true;
            this.txtHexRed.Size = new System.Drawing.Size(64, 23);
            this.txtHexRed.TabIndex = 53;
            // 
            // txtHexGreen
            // 
            this.txtHexGreen.Location = new System.Drawing.Point(208, 245);
            this.txtHexGreen.Name = "txtHexGreen";
            this.txtHexGreen.ReadOnly = true;
            this.txtHexGreen.Size = new System.Drawing.Size(64, 23);
            this.txtHexGreen.TabIndex = 54;
            // 
            // txtHexBlue
            // 
            this.txtHexBlue.Location = new System.Drawing.Point(340, 245);
            this.txtHexBlue.Name = "txtHexBlue";
            this.txtHexBlue.ReadOnly = true;
            this.txtHexBlue.Size = new System.Drawing.Size(64, 23);
            this.txtHexBlue.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 15);
            this.label13.TabIndex = 56;
            this.label13.Text = "Hex";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(177, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 15);
            this.label14.TabIndex = 57;
            this.label14.Text = "Hex";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(309, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 15);
            this.label15.TabIndex = 58;
            this.label15.Text = "Hex";
            // 
            // btnInitArduinoDriver
            // 
            this.btnInitArduinoDriver.Location = new System.Drawing.Point(463, 23);
            this.btnInitArduinoDriver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInitArduinoDriver.Name = "btnInitArduinoDriver";
            this.btnInitArduinoDriver.Size = new System.Drawing.Size(164, 31);
            this.btnInitArduinoDriver.TabIndex = 59;
            this.btnInitArduinoDriver.Text = "Intitalize Arduino Driver";
            this.btnInitArduinoDriver.UseVisualStyleBackColor = true;
            this.btnInitArduinoDriver.Click += new System.EventHandler(this.btnInitArduinoDriver_Click);
            // 
            // btnReadVfs
            // 
            this.btnReadVfs.Location = new System.Drawing.Point(463, 64);
            this.btnReadVfs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReadVfs.Name = "btnReadVfs";
            this.btnReadVfs.Size = new System.Drawing.Size(164, 30);
            this.btnReadVfs.TabIndex = 60;
            this.btnReadVfs.Text = "ReadVfs";
            this.btnReadVfs.UseVisualStyleBackColor = true;
            this.btnReadVfs.Click += new System.EventHandler(this.btnReadVfs_Click);
            // 
            // txtVfs
            // 
            this.txtVfs.Location = new System.Drawing.Point(463, 102);
            this.txtVfs.Multiline = true;
            this.txtVfs.Name = "txtVfs";
            this.txtVfs.ReadOnly = true;
            this.txtVfs.Size = new System.Drawing.Size(164, 252);
            this.txtVfs.TabIndex = 61;
            // 
            // ucLEDDriverDiagnostics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtVfs);
            this.Controls.Add(this.btnReadVfs);
            this.Controls.Add(this.btnInitArduinoDriver);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtHexBlue);
            this.Controls.Add(this.txtHexGreen);
            this.Controls.Add(this.txtHexRed);
            this.Controls.Add(this.txtBitsBlue);
            this.Controls.Add(this.txtBitsGreen);
            this.Controls.Add(this.txtBitsRed);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSendRawHexToAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBlueCurrent);
            this.Controls.Add(this.cboGreenCurrent);
            this.Controls.Add(this.cboRedCurrent);
            this.Controls.Add(this.ipGreen);
            this.Controls.Add(this.ipBlue);
            this.Controls.Add(this.ipRedPct);
            this.Controls.Add(this.btnSetBlue);
            this.Controls.Add(this.btnSetGreen);
            this.Controls.Add(this.btnSetRed);
            this.Controls.Add(this.btnSetBlueOnly);
            this.Controls.Add(this.btnSetGreenOnly);
            this.Controls.Add(this.btnSetRedOnly);
            this.Controls.Add(this.btnInitDriver);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucLEDDriverDiagnostics";
            this.Size = new System.Drawing.Size(670, 417);
            this.Load += new System.EventHandler(this.ucLEDDriverDiagnostics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipRedPct)).EndInit();
            this.gbSendRawHexToAddress.ResumeLayout(false);
            this.gbSendRawHexToAddress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ipGreen;
        private System.Windows.Forms.NumericUpDown ipBlue;
        private System.Windows.Forms.NumericUpDown ipRedPct;
        private System.Windows.Forms.Button btnSetBlue;
        private System.Windows.Forms.Button btnSetGreen;
        private System.Windows.Forms.Button btnSetRed;
        private System.Windows.Forms.Button btnSetBlueOnly;
        private System.Windows.Forms.Button btnSetGreenOnly;
        private System.Windows.Forms.Button btnSetRedOnly;
        private System.Windows.Forms.Button btnInitDriver;
        private System.Windows.Forms.ComboBox cboRedCurrent;
        private System.Windows.Forms.ComboBox cboGreenCurrent;
        private System.Windows.Forms.ComboBox cboBlueCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSendRawHexToAddress;
        private System.Windows.Forms.Button btnSendHexValue;
        private System.Windows.Forms.TextBox txtRawHexValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRawHexAddress;
        private System.Windows.Forms.TextBox txtBinaryIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHexIn;
        private System.Windows.Forms.TextBox txtHexOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBinaryOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBitsRed;
        private System.Windows.Forms.TextBox txtBitsGreen;
        private System.Windows.Forms.TextBox txtBitsBlue;
        private System.Windows.Forms.TextBox txtHexRed;
        private System.Windows.Forms.TextBox txtHexGreen;
        private System.Windows.Forms.TextBox txtHexBlue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnInitArduinoDriver;
        private System.Windows.Forms.Button btnReadVfs;
        private System.Windows.Forms.TextBox txtVfs;
    }
}
