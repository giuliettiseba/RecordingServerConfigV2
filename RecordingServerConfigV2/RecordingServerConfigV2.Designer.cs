namespace RecordingServerConfigV2
{
    partial class RecordingServerConfigV2
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
            this.ButtonSave = new System.Windows.Forms.Button();
            this.buttonReloadConfig = new System.Windows.Forms.Button();
            this.buttonDefaulValues = new System.Windows.Forms.Button();
            this.buttonOptimumValues = new System.Windows.Forms.Button();
            this.buttonExtremeValues = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTestRecordingServer = new System.Windows.Forms.Button();
            this.textBoxRecordingServerWebServerPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRecordingServerWebServerAddress = new System.Windows.Forms.TextBox();
            this.textBoxRecordingServerWebApiPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRecordingServerWebApiAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_displayname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTestManagementServer = new System.Windows.Forms.Button();
            this.textBoxAuthorizationserveraddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMsServerWebApiPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMsServerWebApiAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDiskUtilizationHelp = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelMediaFileReadBuffer = new System.Windows.Forms.Label();
            this.textBoxChunkFileWriteBuffer = new System.Windows.Forms.TextBox();
            this.textBoxChunkFileReadBuffer = new System.Windows.Forms.TextBox();
            this.textBoxMediaFileWriteBuffer = new System.Windows.Forms.TextBox();
            this.textBoxMediaFileReadBuffer = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDiskUsageHelp = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxForceDeleteLimit = new System.Windows.Forms.TextBox();
            this.textBoxForceArchiveLimit = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonArchivingThreads = new System.Windows.Forms.Button();
            this.textBoxHighPriorityArchiveThreads = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxLowPriorityArchiveThreads = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxDeleteThreadPoolSize = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonPipelineSettingsHelp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxMaxActiveTimeForPipeline2 = new System.Windows.Forms.TextBox();
            this.textBoxMaxBytesinQueue = new System.Windows.Forms.TextBox();
            this.textBoxMaxFramesInQueue = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelOpenFile = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(521, 542);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonReloadConfig
            // 
            this.buttonReloadConfig.Location = new System.Drawing.Point(393, 542);
            this.buttonReloadConfig.Name = "buttonReloadConfig";
            this.buttonReloadConfig.Size = new System.Drawing.Size(90, 23);
            this.buttonReloadConfig.TabIndex = 2;
            this.buttonReloadConfig.Text = "Reload Config";
            this.buttonReloadConfig.UseVisualStyleBackColor = true;
            this.buttonReloadConfig.Click += new System.EventHandler(this.buttonReloadConfig_Click);
            // 
            // buttonDefaulValues
            // 
            this.buttonDefaulValues.Location = new System.Drawing.Point(27, 579);
            this.buttonDefaulValues.Name = "buttonDefaulValues";
            this.buttonDefaulValues.Size = new System.Drawing.Size(95, 23);
            this.buttonDefaulValues.TabIndex = 2;
            this.buttonDefaulValues.Text = "Default Values";
            this.buttonDefaulValues.UseVisualStyleBackColor = true;
            this.buttonDefaulValues.Click += new System.EventHandler(this.buttonDefaulValues_Click);
            // 
            // buttonOptimumValues
            // 
            this.buttonOptimumValues.Location = new System.Drawing.Point(135, 579);
            this.buttonOptimumValues.Name = "buttonOptimumValues";
            this.buttonOptimumValues.Size = new System.Drawing.Size(95, 23);
            this.buttonOptimumValues.TabIndex = 2;
            this.buttonOptimumValues.Text = "Optimum Values";
            this.buttonOptimumValues.UseVisualStyleBackColor = true;
            this.buttonOptimumValues.Click += new System.EventHandler(this.buttonOptimusValues_Click);
            // 
            // buttonExtremeValues
            // 
            this.buttonExtremeValues.Location = new System.Drawing.Point(243, 579);
            this.buttonExtremeValues.Name = "buttonExtremeValues";
            this.buttonExtremeValues.Size = new System.Drawing.Size(95, 23);
            this.buttonExtremeValues.TabIndex = 2;
            this.buttonExtremeValues.Text = "Extreme Values";
            this.buttonExtremeValues.UseVisualStyleBackColor = true;
            this.buttonExtremeValues.Click += new System.EventHandler(this.buttonExtremeValues_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTestRecordingServer);
            this.groupBox1.Controls.Add(this.textBoxRecordingServerWebServerPort);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxRecordingServerWebServerAddress);
            this.groupBox1.Controls.Add(this.textBoxRecordingServerWebApiPort);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxRecordingServerWebApiAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_displayname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recording Server";
            // 
            // buttonTestRecordingServer
            // 
            this.buttonTestRecordingServer.Location = new System.Drawing.Point(1, 179);
            this.buttonTestRecordingServer.Name = "buttonTestRecordingServer";
            this.buttonTestRecordingServer.Size = new System.Drawing.Size(295, 21);
            this.buttonTestRecordingServer.TabIndex = 12;
            this.buttonTestRecordingServer.Text = "Test";
            this.buttonTestRecordingServer.UseVisualStyleBackColor = true;
            this.buttonTestRecordingServer.Click += new System.EventHandler(this.buttonTestRecordingServer_Click);
            // 
            // textBoxRecordingServerWebServerPort
            // 
            this.textBoxRecordingServerWebServerPort.Location = new System.Drawing.Point(121, 93);
            this.textBoxRecordingServerWebServerPort.Name = "textBoxRecordingServerWebServerPort";
            this.textBoxRecordingServerWebServerPort.Size = new System.Drawing.Size(178, 20);
            this.textBoxRecordingServerWebServerPort.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Web Server Port ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Web Server Address";
            // 
            // textBoxRecordingServerWebServerAddress
            // 
            this.textBoxRecordingServerWebServerAddress.Location = new System.Drawing.Point(121, 67);
            this.textBoxRecordingServerWebServerAddress.Name = "textBoxRecordingServerWebServerAddress";
            this.textBoxRecordingServerWebServerAddress.Size = new System.Drawing.Size(178, 20);
            this.textBoxRecordingServerWebServerAddress.TabIndex = 25;
            // 
            // textBoxRecordingServerWebApiPort
            // 
            this.textBoxRecordingServerWebApiPort.Location = new System.Drawing.Point(121, 145);
            this.textBoxRecordingServerWebApiPort.Name = "textBoxRecordingServerWebApiPort";
            this.textBoxRecordingServerWebApiPort.Size = new System.Drawing.Size(178, 20);
            this.textBoxRecordingServerWebApiPort.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Web API Port";
            // 
            // textBoxRecordingServerWebApiAddress
            // 
            this.textBoxRecordingServerWebApiAddress.Location = new System.Drawing.Point(121, 119);
            this.textBoxRecordingServerWebApiAddress.Name = "textBoxRecordingServerWebApiAddress";
            this.textBoxRecordingServerWebApiAddress.Size = new System.Drawing.Size(178, 20);
            this.textBoxRecordingServerWebApiAddress.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Web API Address";
            // 
            // textBox_displayname
            // 
            this.textBox_displayname.Location = new System.Drawing.Point(121, 41);
            this.textBox_displayname.Name = "textBox_displayname";
            this.textBox_displayname.ReadOnly = true;
            this.textBox_displayname.Size = new System.Drawing.Size(178, 20);
            this.textBox_displayname.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Display Name";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(28, 15);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(272, 20);
            this.textBox_id.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTestManagementServer);
            this.groupBox2.Controls.Add(this.textBoxAuthorizationserveraddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxMsServerWebApiPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxMsServerWebApiAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(352, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 136);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Management Server ";
            // 
            // buttonTestManagementServer
            // 
            this.buttonTestManagementServer.Location = new System.Drawing.Point(5, 109);
            this.buttonTestManagementServer.Name = "buttonTestManagementServer";
            this.buttonTestManagementServer.Size = new System.Drawing.Size(295, 21);
            this.buttonTestManagementServer.TabIndex = 12;
            this.buttonTestManagementServer.Text = "Test";
            this.buttonTestManagementServer.UseVisualStyleBackColor = true;
            this.buttonTestManagementServer.Click += new System.EventHandler(this.buttonTestManagementServer_ClickAsync);
            // 
            // textBoxAuthorizationserveraddress
            // 
            this.textBoxAuthorizationserveraddress.Location = new System.Drawing.Point(119, 83);
            this.textBoxAuthorizationserveraddress.Name = "textBoxAuthorizationserveraddress";
            this.textBoxAuthorizationserveraddress.Size = new System.Drawing.Size(178, 20);
            this.textBoxAuthorizationserveraddress.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Authorization Server";
            // 
            // textBoxMsServerWebApiPort
            // 
            this.textBoxMsServerWebApiPort.Location = new System.Drawing.Point(119, 57);
            this.textBoxMsServerWebApiPort.Name = "textBoxMsServerWebApiPort";
            this.textBoxMsServerWebApiPort.Size = new System.Drawing.Size(178, 20);
            this.textBoxMsServerWebApiPort.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port";
            // 
            // textBoxMsServerWebApiAddress
            // 
            this.textBoxMsServerWebApiAddress.Location = new System.Drawing.Point(119, 28);
            this.textBoxMsServerWebApiAddress.Name = "textBoxMsServerWebApiAddress";
            this.textBoxMsServerWebApiAddress.Size = new System.Drawing.Size(178, 20);
            this.textBoxMsServerWebApiAddress.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDiskUtilizationHelp);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.labelMediaFileReadBuffer);
            this.groupBox3.Controls.Add(this.textBoxChunkFileWriteBuffer);
            this.groupBox3.Controls.Add(this.textBoxChunkFileReadBuffer);
            this.groupBox3.Controls.Add(this.textBoxMediaFileWriteBuffer);
            this.groupBox3.Controls.Add(this.textBoxMediaFileReadBuffer);
            this.groupBox3.Location = new System.Drawing.Point(345, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 146);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disk Utilization";
            // 
            // buttonDiskUtilizationHelp
            // 
            this.buttonDiskUtilizationHelp.Location = new System.Drawing.Point(6, 118);
            this.buttonDiskUtilizationHelp.Name = "buttonDiskUtilizationHelp";
            this.buttonDiskUtilizationHelp.Size = new System.Drawing.Size(295, 21);
            this.buttonDiskUtilizationHelp.TabIndex = 12;
            this.buttonDiskUtilizationHelp.Text = "Help";
            this.buttonDiskUtilizationHelp.UseVisualStyleBackColor = true;
            this.buttonDiskUtilizationHelp.Click += new System.EventHandler(this.buttonDiskUtilizationHelp_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Chunk File Writte Buffer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Chunk File Read Buffer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Media File Write Buffer";
            // 
            // labelMediaFileReadBuffer
            // 
            this.labelMediaFileReadBuffer.AutoSize = true;
            this.labelMediaFileReadBuffer.Location = new System.Drawing.Point(8, 17);
            this.labelMediaFileReadBuffer.Name = "labelMediaFileReadBuffer";
            this.labelMediaFileReadBuffer.Size = new System.Drawing.Size(115, 13);
            this.labelMediaFileReadBuffer.TabIndex = 7;
            this.labelMediaFileReadBuffer.Text = "Media File Read Buffer";
            // 
            // textBoxChunkFileWriteBuffer
            // 
            this.textBoxChunkFileWriteBuffer.Location = new System.Drawing.Point(133, 92);
            this.textBoxChunkFileWriteBuffer.Name = "textBoxChunkFileWriteBuffer";
            this.textBoxChunkFileWriteBuffer.Size = new System.Drawing.Size(169, 20);
            this.textBoxChunkFileWriteBuffer.TabIndex = 8;
            // 
            // textBoxChunkFileReadBuffer
            // 
            this.textBoxChunkFileReadBuffer.Location = new System.Drawing.Point(132, 66);
            this.textBoxChunkFileReadBuffer.Name = "textBoxChunkFileReadBuffer";
            this.textBoxChunkFileReadBuffer.Size = new System.Drawing.Size(169, 20);
            this.textBoxChunkFileReadBuffer.TabIndex = 9;
            // 
            // textBoxMediaFileWriteBuffer
            // 
            this.textBoxMediaFileWriteBuffer.Location = new System.Drawing.Point(133, 40);
            this.textBoxMediaFileWriteBuffer.Name = "textBoxMediaFileWriteBuffer";
            this.textBoxMediaFileWriteBuffer.Size = new System.Drawing.Size(169, 20);
            this.textBoxMediaFileWriteBuffer.TabIndex = 10;
            // 
            // textBoxMediaFileReadBuffer
            // 
            this.textBoxMediaFileReadBuffer.Location = new System.Drawing.Point(133, 14);
            this.textBoxMediaFileReadBuffer.Name = "textBoxMediaFileReadBuffer";
            this.textBoxMediaFileReadBuffer.Size = new System.Drawing.Size(169, 20);
            this.textBoxMediaFileReadBuffer.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDiskUsageHelp);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.textBoxForceDeleteLimit);
            this.groupBox4.Controls.Add(this.textBoxForceArchiveLimit);
            this.groupBox4.Location = new System.Drawing.Point(345, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 97);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disk Usage Monitor";
            // 
            // buttonDiskUsageHelp
            // 
            this.buttonDiskUsageHelp.Location = new System.Drawing.Point(6, 70);
            this.buttonDiskUsageHelp.Name = "buttonDiskUsageHelp";
            this.buttonDiskUsageHelp.Size = new System.Drawing.Size(295, 21);
            this.buttonDiskUsageHelp.TabIndex = 8;
            this.buttonDiskUsageHelp.Text = "Help";
            this.buttonDiskUsageHelp.UseVisualStyleBackColor = true;
            this.buttonDiskUsageHelp.Click += new System.EventHandler(this.buttonDiskUsageHelp_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "Force Delete Limit";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "Force Archive Limit";
            // 
            // textBoxForceDeleteLimit
            // 
            this.textBoxForceDeleteLimit.Location = new System.Drawing.Point(133, 42);
            this.textBoxForceDeleteLimit.Name = "textBoxForceDeleteLimit";
            this.textBoxForceDeleteLimit.Size = new System.Drawing.Size(169, 20);
            this.textBoxForceDeleteLimit.TabIndex = 6;
            // 
            // textBoxForceArchiveLimit
            // 
            this.textBoxForceArchiveLimit.Location = new System.Drawing.Point(132, 18);
            this.textBoxForceArchiveLimit.Name = "textBoxForceArchiveLimit";
            this.textBoxForceArchiveLimit.Size = new System.Drawing.Size(170, 20);
            this.textBoxForceArchiveLimit.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonArchivingThreads);
            this.groupBox5.Controls.Add(this.textBoxHighPriorityArchiveThreads);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.textBoxLowPriorityArchiveThreads);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBoxDeleteThreadPoolSize);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(27, 454);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 119);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Archiving Threads";
            // 
            // buttonArchivingThreads
            // 
            this.buttonArchivingThreads.Location = new System.Drawing.Point(5, 92);
            this.buttonArchivingThreads.Name = "buttonArchivingThreads";
            this.buttonArchivingThreads.Size = new System.Drawing.Size(295, 21);
            this.buttonArchivingThreads.TabIndex = 12;
            this.buttonArchivingThreads.Text = "Help";
            this.buttonArchivingThreads.UseVisualStyleBackColor = true;
            this.buttonArchivingThreads.Click += new System.EventHandler(this.buttonArchivingThreads_Click);
            // 
            // textBoxHighPriorityArchiveThreads
            // 
            this.textBoxHighPriorityArchiveThreads.Location = new System.Drawing.Point(156, 66);
            this.textBoxHighPriorityArchiveThreads.Name = "textBoxHighPriorityArchiveThreads";
            this.textBoxHighPriorityArchiveThreads.Size = new System.Drawing.Size(146, 20);
            this.textBoxHighPriorityArchiveThreads.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "High Priority Archive Threads";
            // 
            // textBoxLowPriorityArchiveThreads
            // 
            this.textBoxLowPriorityArchiveThreads.Location = new System.Drawing.Point(156, 40);
            this.textBoxLowPriorityArchiveThreads.Name = "textBoxLowPriorityArchiveThreads";
            this.textBoxLowPriorityArchiveThreads.Size = new System.Drawing.Size(146, 20);
            this.textBoxLowPriorityArchiveThreads.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Low Priority Archive Threads";
            // 
            // textBoxDeleteThreadPoolSize
            // 
            this.textBoxDeleteThreadPoolSize.Location = new System.Drawing.Point(156, 14);
            this.textBoxDeleteThreadPoolSize.Name = "textBoxDeleteThreadPoolSize";
            this.textBoxDeleteThreadPoolSize.Size = new System.Drawing.Size(146, 20);
            this.textBoxDeleteThreadPoolSize.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Delete Thread Pool Size";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonPipelineSettingsHelp);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.textBoxMaxActiveTimeForPipeline2);
            this.groupBox6.Controls.Add(this.textBoxMaxBytesinQueue);
            this.groupBox6.Controls.Add(this.textBoxMaxFramesInQueue);
            this.groupBox6.Location = new System.Drawing.Point(27, 326);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 122);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pipeline Settings";
            // 
            // buttonPipelineSettingsHelp
            // 
            this.buttonPipelineSettingsHelp.Location = new System.Drawing.Point(5, 93);
            this.buttonPipelineSettingsHelp.Name = "buttonPipelineSettingsHelp";
            this.buttonPipelineSettingsHelp.Size = new System.Drawing.Size(295, 21);
            this.buttonPipelineSettingsHelp.TabIndex = 12;
            this.buttonPipelineSettingsHelp.Text = "Help";
            this.buttonPipelineSettingsHelp.UseVisualStyleBackColor = true;
            this.buttonPipelineSettingsHelp.Click += new System.EventHandler(this.buttonPipelineSettingsHelp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Max Active Time For Pipeline2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 44);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Max Bytes in Queue";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(110, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "Max Frames in Queue";
            // 
            // textBoxMaxActiveTimeForPipeline2
            // 
            this.textBoxMaxActiveTimeForPipeline2.Location = new System.Drawing.Point(163, 67);
            this.textBoxMaxActiveTimeForPipeline2.Name = "textBoxMaxActiveTimeForPipeline2";
            this.textBoxMaxActiveTimeForPipeline2.Size = new System.Drawing.Size(138, 20);
            this.textBoxMaxActiveTimeForPipeline2.TabIndex = 7;
            // 
            // textBoxMaxBytesinQueue
            // 
            this.textBoxMaxBytesinQueue.Location = new System.Drawing.Point(163, 41);
            this.textBoxMaxBytesinQueue.Name = "textBoxMaxBytesinQueue";
            this.textBoxMaxBytesinQueue.Size = new System.Drawing.Size(137, 20);
            this.textBoxMaxBytesinQueue.TabIndex = 8;
            // 
            // textBoxMaxFramesInQueue
            // 
            this.textBoxMaxFramesInQueue.Location = new System.Drawing.Point(162, 17);
            this.textBoxMaxFramesInQueue.Name = "textBoxMaxFramesInQueue";
            this.textBoxMaxFramesInQueue.Size = new System.Drawing.Size(138, 20);
            this.textBoxMaxFramesInQueue.TabIndex = 9;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelOpenFile);
            this.groupBox7.Controls.Add(this.labelVersion);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Location = new System.Drawing.Point(31, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(630, 87);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Info";
            // 
            // labelOpenFile
            // 
            this.labelOpenFile.AutoSize = true;
            this.labelOpenFile.Location = new System.Drawing.Point(71, 23);
            this.labelOpenFile.Name = "labelOpenFile";
            this.labelOpenFile.Size = new System.Drawing.Size(52, 13);
            this.labelOpenFile.TabIndex = 2;
            this.labelOpenFile.Text = "Open File";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(71, 45);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Version";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "Version:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Open File:";
            // 
            // RecordingServerConfigV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 612);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExtremeValues);
            this.Controls.Add(this.buttonOptimumValues);
            this.Controls.Add(this.buttonDefaulValues);
            this.Controls.Add(this.buttonReloadConfig);
            this.Controls.Add(this.ButtonSave);
            this.Name = "RecordingServerConfigV2";
            this.Text = "RecordingServerConfigV2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button buttonReloadConfig;
        private System.Windows.Forms.Button buttonDefaulValues;
        private System.Windows.Forms.Button buttonOptimumValues;
        private System.Windows.Forms.Button buttonExtremeValues;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRecordingServerWebServerPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRecordingServerWebServerAddress;
        private System.Windows.Forms.TextBox textBoxRecordingServerWebApiPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRecordingServerWebApiAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_displayname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxAuthorizationserveraddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMsServerWebApiPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMsServerWebApiAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelMediaFileReadBuffer;
        private System.Windows.Forms.TextBox textBoxChunkFileWriteBuffer;
        private System.Windows.Forms.TextBox textBoxChunkFileReadBuffer;
        private System.Windows.Forms.TextBox textBoxMediaFileWriteBuffer;
        private System.Windows.Forms.TextBox textBoxMediaFileReadBuffer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxForceDeleteLimit;
        private System.Windows.Forms.TextBox textBoxForceArchiveLimit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxHighPriorityArchiveThreads;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxLowPriorityArchiveThreads;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxDeleteThreadPoolSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxMaxActiveTimeForPipeline2;
        private System.Windows.Forms.TextBox textBoxMaxBytesinQueue;
        private System.Windows.Forms.TextBox textBoxMaxFramesInQueue;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelOpenFile;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonDiskUsageHelp;
        private System.Windows.Forms.Button buttonDiskUtilizationHelp;
        private System.Windows.Forms.Button buttonArchivingThreads;
        private System.Windows.Forms.Button buttonPipelineSettingsHelp;
        private System.Windows.Forms.Button buttonTestManagementServer;
        private System.Windows.Forms.Button buttonTestRecordingServer;
    }
}

