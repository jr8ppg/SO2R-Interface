namespace SO2RInterface
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.cSo2rDevice = new System.Windows.Forms.ComboBox();
            this.lSo2rDevice = new System.Windows.Forms.Label();
            this.lOtrsp = new System.Windows.Forms.Label();
            this.cOtrsp = new System.Windows.Forms.ComboBox();
            this.cKeyer = new System.Windows.Forms.ComboBox();
            this.lKeyer = new System.Windows.Forms.Label();
            this.bStartStop = new System.Windows.Forms.Button();
            this.cStart = new System.Windows.Forms.CheckBox();
            this.cMinimize = new System.Windows.Forms.CheckBox();
            this.cNoStereo = new System.Windows.Forms.CheckBox();
            this.cLatch = new System.Windows.Forms.CheckBox();
            this.cManual = new System.Windows.Forms.CheckBox();
            this.rRX2 = new System.Windows.Forms.RadioButton();
            this.rRX1 = new System.Windows.Forms.RadioButton();
            this.rStereo = new System.Windows.Forms.RadioButton();
            this.gRX = new System.Windows.Forms.GroupBox();
            this.gTX = new System.Windows.Forms.GroupBox();
            this.rTX2 = new System.Windows.Forms.RadioButton();
            this.rTX1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bBlendRatio0 = new System.Windows.Forms.Button();
            this.bBlendRatio50 = new System.Windows.Forms.Button();
            this.bBlendRatio100 = new System.Windows.Forms.Button();
            this.tbAfBlend = new System.Windows.Forms.TrackBar();
            this.gTX.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAfBlend)).BeginInit();
            this.SuspendLayout();
            // 
            // cSo2rDevice
            // 
            this.cSo2rDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSo2rDevice.FormattingEnabled = true;
            this.cSo2rDevice.Location = new System.Drawing.Point(98, 28);
            this.cSo2rDevice.Margin = new System.Windows.Forms.Padding(2);
            this.cSo2rDevice.Name = "cSo2rDevice";
            this.cSo2rDevice.Size = new System.Drawing.Size(68, 20);
            this.cSo2rDevice.TabIndex = 0;
            this.cSo2rDevice.SelectedIndexChanged += new System.EventHandler(this.CSo2rDevice_SelectedIndexChanged);
            // 
            // lSo2rDevice
            // 
            this.lSo2rDevice.AutoSize = true;
            this.lSo2rDevice.Location = new System.Drawing.Point(29, 30);
            this.lSo2rDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSo2rDevice.Name = "lSo2rDevice";
            this.lSo2rDevice.Size = new System.Drawing.Size(40, 12);
            this.lSo2rDevice.TabIndex = 1;
            this.lSo2rDevice.Text = "Device";
            // 
            // lOtrsp
            // 
            this.lOtrsp.AutoSize = true;
            this.lOtrsp.Location = new System.Drawing.Point(29, 62);
            this.lOtrsp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lOtrsp.Name = "lOtrsp";
            this.lOtrsp.Size = new System.Drawing.Size(42, 12);
            this.lOtrsp.TabIndex = 2;
            this.lOtrsp.Text = "OTRSP";
            // 
            // cOtrsp
            // 
            this.cOtrsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOtrsp.FormattingEnabled = true;
            this.cOtrsp.Location = new System.Drawing.Point(98, 58);
            this.cOtrsp.Margin = new System.Windows.Forms.Padding(2);
            this.cOtrsp.Name = "cOtrsp";
            this.cOtrsp.Size = new System.Drawing.Size(68, 20);
            this.cOtrsp.TabIndex = 1;
            this.cOtrsp.SelectedIndexChanged += new System.EventHandler(this.COtrsp_SelectedIndexChanged);
            // 
            // cKeyer
            // 
            this.cKeyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cKeyer.FormattingEnabled = true;
            this.cKeyer.Location = new System.Drawing.Point(98, 92);
            this.cKeyer.Margin = new System.Windows.Forms.Padding(2);
            this.cKeyer.Name = "cKeyer";
            this.cKeyer.Size = new System.Drawing.Size(68, 20);
            this.cKeyer.TabIndex = 3;
            this.cKeyer.SelectedIndexChanged += new System.EventHandler(this.CKeyer_SelectedIndexChanged);
            // 
            // lKeyer
            // 
            this.lKeyer.AutoSize = true;
            this.lKeyer.Location = new System.Drawing.Point(29, 93);
            this.lKeyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lKeyer.Name = "lKeyer";
            this.lKeyer.Size = new System.Drawing.Size(34, 12);
            this.lKeyer.TabIndex = 5;
            this.lKeyer.Text = "Keyer";
            // 
            // bStartStop
            // 
            this.bStartStop.Location = new System.Drawing.Point(32, 138);
            this.bStartStop.Margin = new System.Windows.Forms.Padding(2);
            this.bStartStop.Name = "bStartStop";
            this.bStartStop.Size = new System.Drawing.Size(65, 24);
            this.bStartStop.TabIndex = 6;
            this.bStartStop.Text = "Start";
            this.bStartStop.UseVisualStyleBackColor = true;
            this.bStartStop.Click += new System.EventHandler(this.BStartStop_Click);
            // 
            // cStart
            // 
            this.cStart.AutoSize = true;
            this.cStart.Location = new System.Drawing.Point(208, 28);
            this.cStart.Margin = new System.Windows.Forms.Padding(2);
            this.cStart.Name = "cStart";
            this.cStart.Size = new System.Drawing.Size(114, 16);
            this.cStart.TabIndex = 7;
            this.cStart.Text = "Start immediately";
            this.cStart.UseVisualStyleBackColor = true;
            this.cStart.CheckedChanged += new System.EventHandler(this.CStart_CheckedChanged);
            // 
            // cMinimize
            // 
            this.cMinimize.AutoSize = true;
            this.cMinimize.Location = new System.Drawing.Point(208, 58);
            this.cMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.cMinimize.Name = "cMinimize";
            this.cMinimize.Size = new System.Drawing.Size(124, 16);
            this.cMinimize.TabIndex = 8;
            this.cMinimize.Text = "Minimize on startup";
            this.cMinimize.UseVisualStyleBackColor = true;
            this.cMinimize.CheckedChanged += new System.EventHandler(this.CMinimize_CheckedChanged);
            // 
            // cNoStereo
            // 
            this.cNoStereo.AutoSize = true;
            this.cNoStereo.Location = new System.Drawing.Point(208, 92);
            this.cNoStereo.Margin = new System.Windows.Forms.Padding(2);
            this.cNoStereo.Name = "cNoStereo";
            this.cNoStereo.Size = new System.Drawing.Size(75, 16);
            this.cNoStereo.TabIndex = 9;
            this.cNoStereo.Text = "No Stereo";
            this.cNoStereo.UseVisualStyleBackColor = true;
            this.cNoStereo.CheckedChanged += new System.EventHandler(this.CNoStereo_CheckedChanged);
            // 
            // cLatch
            // 
            this.cLatch.AutoSize = true;
            this.cLatch.Location = new System.Drawing.Point(208, 124);
            this.cLatch.Margin = new System.Windows.Forms.Padding(2);
            this.cLatch.Name = "cLatch";
            this.cLatch.Size = new System.Drawing.Size(52, 16);
            this.cLatch.TabIndex = 10;
            this.cLatch.Text = "Latch";
            this.cLatch.UseVisualStyleBackColor = true;
            this.cLatch.CheckedChanged += new System.EventHandler(this.CLatch_CheckedChanged);
            // 
            // cManual
            // 
            this.cManual.AutoSize = true;
            this.cManual.Location = new System.Drawing.Point(208, 156);
            this.cManual.Margin = new System.Windows.Forms.Padding(2);
            this.cManual.Name = "cManual";
            this.cManual.Size = new System.Drawing.Size(93, 16);
            this.cManual.TabIndex = 11;
            this.cManual.Text = "Manual SO2R";
            this.cManual.UseVisualStyleBackColor = true;
            this.cManual.CheckedChanged += new System.EventHandler(this.CManual_CheckedChanged);
            // 
            // rRX2
            // 
            this.rRX2.AutoSize = true;
            this.rRX2.Location = new System.Drawing.Point(208, 190);
            this.rRX2.Margin = new System.Windows.Forms.Padding(2);
            this.rRX2.Name = "rRX2";
            this.rRX2.Size = new System.Drawing.Size(29, 16);
            this.rRX2.TabIndex = 15;
            this.rRX2.TabStop = true;
            this.rRX2.Text = "2";
            this.rRX2.UseVisualStyleBackColor = true;
            this.rRX2.CheckedChanged += new System.EventHandler(this.RRx_CheckedChanged);
            // 
            // rRX1
            // 
            this.rRX1.AutoSize = true;
            this.rRX1.Location = new System.Drawing.Point(166, 190);
            this.rRX1.Margin = new System.Windows.Forms.Padding(2);
            this.rRX1.Name = "rRX1";
            this.rRX1.Size = new System.Drawing.Size(29, 16);
            this.rRX1.TabIndex = 14;
            this.rRX1.TabStop = true;
            this.rRX1.Text = "1";
            this.rRX1.UseVisualStyleBackColor = true;
            this.rRX1.CheckedChanged += new System.EventHandler(this.RRx_CheckedChanged);
            // 
            // rStereo
            // 
            this.rStereo.AutoSize = true;
            this.rStereo.Location = new System.Drawing.Point(250, 190);
            this.rStereo.Margin = new System.Windows.Forms.Padding(2);
            this.rStereo.Name = "rStereo";
            this.rStereo.Size = new System.Drawing.Size(56, 16);
            this.rStereo.TabIndex = 16;
            this.rStereo.TabStop = true;
            this.rStereo.Text = "Stereo";
            this.rStereo.UseVisualStyleBackColor = true;
            this.rStereo.CheckedChanged += new System.EventHandler(this.RRx_CheckedChanged);
            // 
            // gRX
            // 
            this.gRX.Location = new System.Drawing.Point(158, 174);
            this.gRX.Margin = new System.Windows.Forms.Padding(2);
            this.gRX.Name = "gRX";
            this.gRX.Padding = new System.Windows.Forms.Padding(2);
            this.gRX.Size = new System.Drawing.Size(153, 41);
            this.gRX.TabIndex = 18;
            this.gRX.TabStop = false;
            this.gRX.Text = "RX";
            // 
            // gTX
            // 
            this.gTX.Controls.Add(this.rTX2);
            this.gTX.Controls.Add(this.rTX1);
            this.gTX.Location = new System.Drawing.Point(29, 174);
            this.gTX.Margin = new System.Windows.Forms.Padding(2);
            this.gTX.Name = "gTX";
            this.gTX.Padding = new System.Windows.Forms.Padding(2);
            this.gTX.Size = new System.Drawing.Size(87, 41);
            this.gTX.TabIndex = 19;
            this.gTX.TabStop = false;
            this.gTX.Text = "TX";
            // 
            // rTX2
            // 
            this.rTX2.AutoSize = true;
            this.rTX2.Location = new System.Drawing.Point(52, 16);
            this.rTX2.Margin = new System.Windows.Forms.Padding(2);
            this.rTX2.Name = "rTX2";
            this.rTX2.Size = new System.Drawing.Size(29, 16);
            this.rTX2.TabIndex = 1;
            this.rTX2.TabStop = true;
            this.rTX2.Text = "2";
            this.rTX2.UseVisualStyleBackColor = true;
            this.rTX2.CheckedChanged += new System.EventHandler(this.RTx_CheckedChanged);
            // 
            // rTX1
            // 
            this.rTX1.AutoSize = true;
            this.rTX1.Location = new System.Drawing.Point(9, 16);
            this.rTX1.Margin = new System.Windows.Forms.Padding(2);
            this.rTX1.Name = "rTX1";
            this.rTX1.Size = new System.Drawing.Size(29, 16);
            this.rTX1.TabIndex = 0;
            this.rTX1.TabStop = true;
            this.rTX1.Text = "1";
            this.rTX1.UseVisualStyleBackColor = true;
            this.rTX1.CheckedChanged += new System.EventHandler(this.RTx_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBlendRatio0);
            this.groupBox1.Controls.Add(this.bBlendRatio50);
            this.groupBox1.Controls.Add(this.bBlendRatio100);
            this.groupBox1.Controls.Add(this.tbAfBlend);
            this.groupBox1.Location = new System.Drawing.Point(29, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 80);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AF Blend";
            // 
            // bBlendRatio0
            // 
            this.bBlendRatio0.Location = new System.Drawing.Point(6, 53);
            this.bBlendRatio0.Name = "bBlendRatio0";
            this.bBlendRatio0.Size = new System.Drawing.Size(39, 20);
            this.bBlendRatio0.TabIndex = 3;
            this.bBlendRatio0.Tag = "0";
            this.bBlendRatio0.Text = "0%";
            this.bBlendRatio0.UseVisualStyleBackColor = true;
            this.bBlendRatio0.Click += new System.EventHandler(this.bBlendRatio_Click);
            // 
            // bBlendRatio50
            // 
            this.bBlendRatio50.Location = new System.Drawing.Point(121, 54);
            this.bBlendRatio50.Name = "bBlendRatio50";
            this.bBlendRatio50.Size = new System.Drawing.Size(39, 20);
            this.bBlendRatio50.TabIndex = 2;
            this.bBlendRatio50.Tag = "50";
            this.bBlendRatio50.Text = "50%";
            this.bBlendRatio50.UseVisualStyleBackColor = true;
            this.bBlendRatio50.Click += new System.EventHandler(this.bBlendRatio_Click);
            // 
            // bBlendRatio100
            // 
            this.bBlendRatio100.Location = new System.Drawing.Point(233, 54);
            this.bBlendRatio100.Name = "bBlendRatio100";
            this.bBlendRatio100.Size = new System.Drawing.Size(39, 20);
            this.bBlendRatio100.TabIndex = 1;
            this.bBlendRatio100.Tag = "100";
            this.bBlendRatio100.Text = "100%";
            this.bBlendRatio100.UseVisualStyleBackColor = true;
            this.bBlendRatio100.Click += new System.EventHandler(this.bBlendRatio_Click);
            // 
            // tbAfBlend
            // 
            this.tbAfBlend.LargeChange = 10;
            this.tbAfBlend.Location = new System.Drawing.Point(9, 18);
            this.tbAfBlend.Maximum = 100;
            this.tbAfBlend.Name = "tbAfBlend";
            this.tbAfBlend.Size = new System.Drawing.Size(263, 45);
            this.tbAfBlend.SmallChange = 5;
            this.tbAfBlend.TabIndex = 0;
            this.tbAfBlend.TickFrequency = 5;
            this.tbAfBlend.Value = 50;
            this.tbAfBlend.ValueChanged += new System.EventHandler(this.tbAfBlend_ValueChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gTX);
            this.Controls.Add(this.cManual);
            this.Controls.Add(this.cLatch);
            this.Controls.Add(this.cNoStereo);
            this.Controls.Add(this.cMinimize);
            this.Controls.Add(this.cStart);
            this.Controls.Add(this.bStartStop);
            this.Controls.Add(this.lKeyer);
            this.Controls.Add(this.cKeyer);
            this.Controls.Add(this.cOtrsp);
            this.Controls.Add(this.lOtrsp);
            this.Controls.Add(this.lSo2rDevice);
            this.Controls.Add(this.cSo2rDevice);
            this.Controls.Add(this.rStereo);
            this.Controls.Add(this.rRX2);
            this.Controls.Add(this.rRX1);
            this.Controls.Add(this.gRX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "SO2R Interface for SO2R Neo";
            this.gTX.ResumeLayout(false);
            this.gTX.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAfBlend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cSo2rDevice;
        private System.Windows.Forms.Label lSo2rDevice;
        private System.Windows.Forms.Label lOtrsp;
        private System.Windows.Forms.ComboBox cOtrsp;
        private System.Windows.Forms.ComboBox cKeyer;
        private System.Windows.Forms.Label lKeyer;
        private System.Windows.Forms.Button bStartStop;
        private System.Windows.Forms.CheckBox cStart;
        private System.Windows.Forms.CheckBox cMinimize;
        private System.Windows.Forms.CheckBox cNoStereo;
        private System.Windows.Forms.CheckBox cLatch;
        private System.Windows.Forms.CheckBox cManual;
        private System.Windows.Forms.RadioButton rRX2;
        private System.Windows.Forms.RadioButton rRX1;
        private System.Windows.Forms.RadioButton rStereo;
        private System.Windows.Forms.GroupBox gRX;
        private System.Windows.Forms.GroupBox gTX;
        private System.Windows.Forms.RadioButton rTX2;
        private System.Windows.Forms.RadioButton rTX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbAfBlend;
        private System.Windows.Forms.Button bBlendRatio0;
        private System.Windows.Forms.Button bBlendRatio50;
        private System.Windows.Forms.Button bBlendRatio100;
    }
}

