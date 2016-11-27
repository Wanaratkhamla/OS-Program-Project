namespace GetHardwareInfo
{
    partial class frmMain
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabHardware = new System.Windows.Forms.TabPage();
            this.chkHardware = new System.Windows.Forms.CheckBox();
            this.cmbxOption = new System.Windows.Forms.ComboBox();
            this.lstDisplayHardware = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMemory = new System.Windows.Forms.TabPage();
            this.chkMemory = new System.Windows.Forms.CheckBox();
            this.cmbxMemory = new System.Windows.Forms.ComboBox();
            this.lstMemory = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.tabHardware.SuspendLayout();
            this.tabMemory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabHardware);
            this.MainTabControl.Controls.Add(this.tabMemory);
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(485, 396);
            this.MainTabControl.TabIndex = 0;
            // 
            // tabHardware
            // 
            this.tabHardware.Controls.Add(this.chkHardware);
            this.tabHardware.Controls.Add(this.cmbxOption);
            this.tabHardware.Controls.Add(this.lstDisplayHardware);
            this.tabHardware.Location = new System.Drawing.Point(4, 22);
            this.tabHardware.Name = "tabHardware";
            this.tabHardware.Padding = new System.Windows.Forms.Padding(3);
            this.tabHardware.Size = new System.Drawing.Size(477, 370);
            this.tabHardware.TabIndex = 0;
            this.tabHardware.Text = "Hardware Info";
            this.tabHardware.UseVisualStyleBackColor = true;
            // 
            // chkHardware
            // 
            this.chkHardware.AutoSize = true;
            this.chkHardware.Checked = true;
            this.chkHardware.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHardware.Location = new System.Drawing.Point(16, 18);
            this.chkHardware.Name = "chkHardware";
            this.chkHardware.Size = new System.Drawing.Size(162, 17);
            this.chkHardware.TabIndex = 2;
            this.chkHardware.Text = "Dont Display null Value items";
            this.chkHardware.UseVisualStyleBackColor = true;
            this.chkHardware.CheckedChanged += new System.EventHandler(this.chkHardware_CheckedChanged);
            // 
            // cmbxOption
            // 
            this.cmbxOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOption.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxOption.FormattingEnabled = true;
            this.cmbxOption.Items.AddRange(new object[] {
            "Win32_1394Controller",
            "Win32_1394ControllerDevice",
            "Win32_BaseBoard",
            "Win32_Battery",
            "Win32_BIOS",
            "Win32_Bus",
            "Win32_CDROMDrive",
            "Win32_CIMLogicalDeviceCIMDataFile",
            "Win32_DeviceBus",
            "Win32_DeviceMemoryAddress",
            "Win32_DeviceSettings",
            "Win32_DisplayConfiguration",
            "Win32_DisplayControllerConfiguration",
            "Win32_DMAChannel",
            "Win32_DriverVXD",
            "Win32_FloppyController",
            "Win32_FloppyDrive",
            "Win32_HeatPipe",
            "Win32_IDEController",
            "Win32_IDEControllerDevice",
            "Win32_InfraredDevice",
            "Win32_IRQResource",
            "Win32_Keyboard",
            "Win32_MotherboardDevice",
            "Win32_OnBoardDevice",
            "Win32_PCMCIAController",
            "Win32_PNPAllocatedResource",
            "Win32_PnPDevice",
            "Win32_PnPEntity",
            "Win32_PointingDevice",
            "Win32_PortableBattery",
            "Win32_PortConnector",
            "Win32_PortResource",
            "Win32_POTSModem",
            "Win32_POTSModemToSerialPort",
            "Win32_PowerManagementEvent",
            "Win32_Printer",
            "Win32_PrinterConfiguration",
            "Win32_PrinterController",
            "Win32_PrinterDriverDll",
            "Win32_PrinterSetting",
            "Win32_PrinterShare",
            "Win32_PrintJob",
            "Win32_Processor",
            "Win32_SCSIController",
            "Win32_SCSIControllerDevice",
            "Win32_SerialPort",
            "Win32_SerialPortConfiguration",
            "Win32_SerialPortSetting",
            "Win32_SMBIOSMemory",
            "Win32_SoundDevice",
            "Win32_TemperatureProbe",
            "Win32_USBController",
            "Win32_USBControllerDevice",
            "Win32_VideoConfiguration",
            "Win32_VideoController",
            "Win32_VideoSettings",
            "Win32_VoltageProbe"});
            this.cmbxOption.Location = new System.Drawing.Point(275, 14);
            this.cmbxOption.Name = "cmbxOption";
            this.cmbxOption.Size = new System.Drawing.Size(194, 21);
            this.cmbxOption.Sorted = true;
            this.cmbxOption.TabIndex = 1;
            this.cmbxOption.SelectedIndexChanged += new System.EventHandler(this.cmbxOption_SelectedIndexChanged);
            // 
            // lstDisplayHardware
            // 
            this.lstDisplayHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDisplayHardware.Location = new System.Drawing.Point(16, 41);
            this.lstDisplayHardware.Name = "lstDisplayHardware";
            this.lstDisplayHardware.Size = new System.Drawing.Size(453, 323);
            this.lstDisplayHardware.TabIndex = 0;
            this.lstDisplayHardware.UseCompatibleStateImageBehavior = false;
            this.lstDisplayHardware.View = System.Windows.Forms.View.Details;
            this.lstDisplayHardware.SelectedIndexChanged += new System.EventHandler(this.lstDisplayHardware_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 503;
            // 
            // tabMemory
            // 
            this.tabMemory.Controls.Add(this.chkMemory);
            this.tabMemory.Controls.Add(this.cmbxMemory);
            this.tabMemory.Controls.Add(this.lstMemory);
            this.tabMemory.Location = new System.Drawing.Point(4, 22);
            this.tabMemory.Name = "tabMemory";
            this.tabMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemory.Size = new System.Drawing.Size(477, 370);
            this.tabMemory.TabIndex = 7;
            this.tabMemory.Text = "Memory";
            this.tabMemory.UseVisualStyleBackColor = true;
            // 
            // chkMemory
            // 
            this.chkMemory.AutoSize = true;
            this.chkMemory.Checked = true;
            this.chkMemory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMemory.Location = new System.Drawing.Point(16, 18);
            this.chkMemory.Name = "chkMemory";
            this.chkMemory.Size = new System.Drawing.Size(162, 17);
            this.chkMemory.TabIndex = 9;
            this.chkMemory.Text = "Dont Display null Value items";
            this.chkMemory.UseVisualStyleBackColor = true;
            this.chkMemory.CheckedChanged += new System.EventHandler(this.chkMemory_CheckedChanged);
            // 
            // cmbxMemory
            // 
            this.cmbxMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMemory.FormattingEnabled = true;
            this.cmbxMemory.Items.AddRange(new object[] {
            "Win32_CacheMemory",
            "Win32_MemoryArray",
            "Win32_MemoryArrayLocation",
            "Win32_MemoryDevice",
            "Win32_MemoryDeviceArray",
            "Win32_MemoryDeviceLocation",
            "Win32_AssociatedProcessorMemory",
            "Win32_DeviceMemoryAddress",
            "Win32_LogicalMemoryConfiguration",
            "Win32_PerfRawData_PerfOS_Memory",
            "Win32_PhysicalMemory",
            "Win32_PhysicalMemoryArray",
            "Win32_PhysicalMemoryLocation",
            "Win32_SMBIOSMemory",
            "Win32_SystemLogicalMemoryConfiguration",
            "Win32_SystemMemoryResource"});
            this.cmbxMemory.Location = new System.Drawing.Point(274, 14);
            this.cmbxMemory.Name = "cmbxMemory";
            this.cmbxMemory.Size = new System.Drawing.Size(194, 21);
            this.cmbxMemory.TabIndex = 8;
            this.cmbxMemory.SelectedIndexChanged += new System.EventHandler(this.cmbxMemory_SelectedIndexChanged);
            // 
            // lstMemory
            // 
            this.lstMemory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18});
            this.lstMemory.Location = new System.Drawing.Point(16, 41);
            this.lstMemory.Name = "lstMemory";
            this.lstMemory.Size = new System.Drawing.Size(452, 318);
            this.lstMemory.TabIndex = 7;
            this.lstMemory.UseCompatibleStateImageBehavior = false;
            this.lstMemory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Name";
            this.columnHeader17.Width = 72;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Value";
            this.columnHeader18.Width = 503;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 370);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "Shutdown";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel Shutdown";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(65, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minute : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(79, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hour : ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox3.Location = new System.Drawing.Point(165, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(159, 31);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox2.Location = new System.Drawing.Point(165, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 31);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(88, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Day : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(165, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(160, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set a shutdown timer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 370);
            this.tabPage2.TabIndex = 9;
            this.tabPage2.Text = "Process";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.listView1.Location = new System.Drawing.Point(251, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(218, 332);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name Process";
            this.nameColumn.Width = 181;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(49, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "End Task Process";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "End Task";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox4.Location = new System.Drawing.Point(85, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 29);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "chrome";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(8, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "ชื่อโปรแกรม : ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 42);
            this.button4.TabIndex = 0;
            this.button4.Text = "Start Program";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(477, 370);
            this.tabPage3.TabIndex = 10;
            this.tabPage3.Text = "System Call";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(255, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Eject optical drive ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(29, 238);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 83);
            this.button8.TabIndex = 5;
            this.button8.Text = "Mute";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(29, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 80);
            this.button7.TabIndex = 4;
            this.button7.Text = "Volum Down";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(29, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 90);
            this.button6.TabIndex = 3;
            this.button6.Text = "Volum UP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(25, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "ปรับ Volume เสียง ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 503;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(187, 53);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(247, 90);
            this.button9.TabIndex = 7;
            this.button9.Text = "Eject";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(170, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = " Create WiFi Interface and Connect to the Internet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(170, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "SSID : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(170, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Password : ";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox5.Location = new System.Drawing.Point(212, 194);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(207, 29);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox6.Location = new System.Drawing.Point(238, 238);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(181, 29);
            this.textBox6.TabIndex = 12;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(174, 282);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(245, 39);
            this.button10.TabIndex = 13;
            this.button10.Text = "Start WiFi";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 396);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Operating System Program";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabHardware.ResumeLayout(false);
            this.tabHardware.PerformLayout();
            this.tabMemory.ResumeLayout(false);
            this.tabMemory.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabHardware;
        private System.Windows.Forms.ListView lstDisplayHardware;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cmbxOption;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tabMemory;
        private System.Windows.Forms.ComboBox cmbxMemory;
        private System.Windows.Forms.ListView lstMemory;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.CheckBox chkHardware;
        private System.Windows.Forms.CheckBox chkMemory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
    }
}