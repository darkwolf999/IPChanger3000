namespace IPChanger
{
    partial class Main
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
            this.buttonSetStatic = new System.Windows.Forms.Button();
            this.buttonSetDHCP = new System.Windows.Forms.Button();
            this.listBoxConnections = new System.Windows.Forms.ListBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxMask = new System.Windows.Forms.TextBox();
            this.textBoxGate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDNS2 = new System.Windows.Forms.TextBox();
            this.textBoxDNS1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelMask = new System.Windows.Forms.Label();
            this.labelGate = new System.Windows.Forms.Label();
            this.labelDNS1 = new System.Windows.Forms.Label();
            this.labelDNS2 = new System.Windows.Forms.Label();
            this.textBoxShowIP = new System.Windows.Forms.TextBox();
            this.textBoxShowMask = new System.Windows.Forms.TextBox();
            this.textBoxShowGate = new System.Windows.Forms.TextBox();
            this.textBoxShowDNS1 = new System.Windows.Forms.TextBox();
            this.textBoxShowDNS2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRebootAdapter = new System.Windows.Forms.Button();
            this.buttonRebootAll = new System.Windows.Forms.Button();
            this.buttonDisableAdapter = new System.Windows.Forms.Button();
            this.buttonEnableAdapter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetStatic
            // 
            this.buttonSetStatic.Location = new System.Drawing.Point(151, 22);
            this.buttonSetStatic.Name = "buttonSetStatic";
            this.buttonSetStatic.Size = new System.Drawing.Size(65, 58);
            this.buttonSetStatic.TabIndex = 0;
            this.buttonSetStatic.Text = "STATIC";
            this.buttonSetStatic.UseVisualStyleBackColor = true;
            this.buttonSetStatic.Click += new System.EventHandler(this.buttonSetStatic_Click);
            // 
            // buttonSetDHCP
            // 
            this.buttonSetDHCP.Location = new System.Drawing.Point(151, 86);
            this.buttonSetDHCP.Name = "buttonSetDHCP";
            this.buttonSetDHCP.Size = new System.Drawing.Size(65, 60);
            this.buttonSetDHCP.TabIndex = 1;
            this.buttonSetDHCP.Text = "DHCP";
            this.buttonSetDHCP.UseVisualStyleBackColor = true;
            this.buttonSetDHCP.Click += new System.EventHandler(this.buttonSetDHCP_Click);
            // 
            // listBoxConnections
            // 
            this.listBoxConnections.FormattingEnabled = true;
            this.listBoxConnections.Location = new System.Drawing.Point(6, 19);
            this.listBoxConnections.Name = "listBoxConnections";
            this.listBoxConnections.Size = new System.Drawing.Size(203, 134);
            this.listBoxConnections.TabIndex = 3;
            this.listBoxConnections.SelectedIndexChanged += new System.EventHandler(this.listBoxConnections_SelectedIndexChanged);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(45, 22);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 4;
            this.textBoxIP.Text = "192.168.1.150";
            // 
            // textBoxMask
            // 
            this.textBoxMask.Location = new System.Drawing.Point(45, 48);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(100, 20);
            this.textBoxMask.TabIndex = 5;
            this.textBoxMask.Text = "255.255.255.0";
            // 
            // textBoxGate
            // 
            this.textBoxGate.Location = new System.Drawing.Point(45, 74);
            this.textBoxGate.Name = "textBoxGate";
            this.textBoxGate.Size = new System.Drawing.Size(100, 20);
            this.textBoxGate.TabIndex = 6;
            this.textBoxGate.Text = "192.168.1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDNS2);
            this.groupBox1.Controls.Add(this.textBoxDNS1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSetStatic);
            this.groupBox1.Controls.Add(this.buttonSetDHCP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMask);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxGate);
            this.groupBox1.Location = new System.Drawing.Point(165, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 163);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Static Parameters";
            // 
            // textBoxDNS2
            // 
            this.textBoxDNS2.Enabled = false;
            this.textBoxDNS2.Location = new System.Drawing.Point(45, 126);
            this.textBoxDNS2.Name = "textBoxDNS2";
            this.textBoxDNS2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNS2.TabIndex = 25;
            // 
            // textBoxDNS1
            // 
            this.textBoxDNS1.Enabled = false;
            this.textBoxDNS1.Location = new System.Drawing.Point(45, 100);
            this.textBoxDNS1.Name = "textBoxDNS1";
            this.textBoxDNS1.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNS1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "DNS1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "DNS2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.listBoxConnections);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 161);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сonnection choice";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(6, 25);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 12;
            this.labelIP.Text = "IP";
            // 
            // labelMask
            // 
            this.labelMask.AutoSize = true;
            this.labelMask.Location = new System.Drawing.Point(6, 51);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(33, 13);
            this.labelMask.TabIndex = 13;
            this.labelMask.Text = "Mask";
            // 
            // labelGate
            // 
            this.labelGate.AutoSize = true;
            this.labelGate.Location = new System.Drawing.Point(6, 77);
            this.labelGate.Name = "labelGate";
            this.labelGate.Size = new System.Drawing.Size(30, 13);
            this.labelGate.TabIndex = 14;
            this.labelGate.Text = "Gate";
            // 
            // labelDNS1
            // 
            this.labelDNS1.AutoSize = true;
            this.labelDNS1.Location = new System.Drawing.Point(6, 103);
            this.labelDNS1.Name = "labelDNS1";
            this.labelDNS1.Size = new System.Drawing.Size(36, 13);
            this.labelDNS1.TabIndex = 15;
            this.labelDNS1.Text = "DNS1";
            // 
            // labelDNS2
            // 
            this.labelDNS2.AutoSize = true;
            this.labelDNS2.Location = new System.Drawing.Point(6, 129);
            this.labelDNS2.Name = "labelDNS2";
            this.labelDNS2.Size = new System.Drawing.Size(36, 13);
            this.labelDNS2.TabIndex = 16;
            this.labelDNS2.Text = "DNS2";
            // 
            // textBoxShowIP
            // 
            this.textBoxShowIP.Enabled = false;
            this.textBoxShowIP.Location = new System.Drawing.Point(47, 22);
            this.textBoxShowIP.Name = "textBoxShowIP";
            this.textBoxShowIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxShowIP.TabIndex = 17;
            // 
            // textBoxShowMask
            // 
            this.textBoxShowMask.Enabled = false;
            this.textBoxShowMask.Location = new System.Drawing.Point(47, 48);
            this.textBoxShowMask.Name = "textBoxShowMask";
            this.textBoxShowMask.Size = new System.Drawing.Size(100, 20);
            this.textBoxShowMask.TabIndex = 18;
            // 
            // textBoxShowGate
            // 
            this.textBoxShowGate.Enabled = false;
            this.textBoxShowGate.Location = new System.Drawing.Point(47, 74);
            this.textBoxShowGate.Name = "textBoxShowGate";
            this.textBoxShowGate.Size = new System.Drawing.Size(100, 20);
            this.textBoxShowGate.TabIndex = 19;
            // 
            // textBoxShowDNS1
            // 
            this.textBoxShowDNS1.Enabled = false;
            this.textBoxShowDNS1.Location = new System.Drawing.Point(47, 100);
            this.textBoxShowDNS1.Name = "textBoxShowDNS1";
            this.textBoxShowDNS1.Size = new System.Drawing.Size(100, 20);
            this.textBoxShowDNS1.TabIndex = 20;
            // 
            // textBoxShowDNS2
            // 
            this.textBoxShowDNS2.Enabled = false;
            this.textBoxShowDNS2.Location = new System.Drawing.Point(47, 126);
            this.textBoxShowDNS2.Name = "textBoxShowDNS2";
            this.textBoxShowDNS2.Size = new System.Drawing.Size(100, 20);
            this.textBoxShowDNS2.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.labelIP);
            this.groupBox3.Controls.Add(this.textBoxShowDNS2);
            this.groupBox3.Controls.Add(this.labelMask);
            this.groupBox3.Controls.Add(this.textBoxShowDNS1);
            this.groupBox3.Controls.Add(this.labelGate);
            this.groupBox3.Controls.Add(this.textBoxShowGate);
            this.groupBox3.Controls.Add(this.labelDNS1);
            this.groupBox3.Controls.Add(this.textBoxShowMask);
            this.groupBox3.Controls.Add(this.labelDNS2);
            this.groupBox3.Controls.Add(this.textBoxShowIP);
            this.groupBox3.Location = new System.Drawing.Point(234, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 161);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Settings";
            // 
            // buttonRebootAdapter
            // 
            this.buttonRebootAdapter.Location = new System.Drawing.Point(8, 19);
            this.buttonRebootAdapter.Name = "buttonRebootAdapter";
            this.buttonRebootAdapter.Size = new System.Drawing.Size(63, 55);
            this.buttonRebootAdapter.TabIndex = 23;
            this.buttonRebootAdapter.Text = "REBOOT";
            this.buttonRebootAdapter.UseVisualStyleBackColor = true;
            this.buttonRebootAdapter.Click += new System.EventHandler(this.buttonRebootAdapter_Click);
            // 
            // buttonRebootAll
            // 
            this.buttonRebootAll.Location = new System.Drawing.Point(77, 19);
            this.buttonRebootAll.Name = "buttonRebootAll";
            this.buttonRebootAll.Size = new System.Drawing.Size(63, 55);
            this.buttonRebootAll.TabIndex = 24;
            this.buttonRebootAll.Text = "REBOOT ALL";
            this.buttonRebootAll.UseVisualStyleBackColor = true;
            this.buttonRebootAll.Click += new System.EventHandler(this.buttonRebootAll_Click);
            // 
            // buttonDisableAdapter
            // 
            this.buttonDisableAdapter.Location = new System.Drawing.Point(8, 19);
            this.buttonDisableAdapter.Name = "buttonDisableAdapter";
            this.buttonDisableAdapter.Size = new System.Drawing.Size(63, 55);
            this.buttonDisableAdapter.TabIndex = 25;
            this.buttonDisableAdapter.Text = "DISABLE";
            this.buttonDisableAdapter.UseVisualStyleBackColor = true;
            this.buttonDisableAdapter.Click += new System.EventHandler(this.buttonDisableAdapter_Click);
            // 
            // buttonEnableAdapter
            // 
            this.buttonEnableAdapter.Location = new System.Drawing.Point(77, 19);
            this.buttonEnableAdapter.Name = "buttonEnableAdapter";
            this.buttonEnableAdapter.Size = new System.Drawing.Size(63, 55);
            this.buttonEnableAdapter.TabIndex = 26;
            this.buttonEnableAdapter.Text = "ENABLE";
            this.buttonEnableAdapter.UseVisualStyleBackColor = true;
            this.buttonEnableAdapter.Click += new System.EventHandler(this.buttonEnableAdapter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonRebootAdapter);
            this.groupBox4.Controls.Add(this.buttonRebootAll);
            this.groupBox4.Location = new System.Drawing.Point(13, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 80);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reboot Adapters";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonEnableAdapter);
            this.groupBox5.Controls.Add(this.buttonDisableAdapter);
            this.groupBox5.Location = new System.Drawing.Point(13, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 80);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Disable/Enable Adapters";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(397, 345);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "IPChanger3000";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetStatic;
        private System.Windows.Forms.Button buttonSetDHCP;
        public System.Windows.Forms.ListBox listBoxConnections;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxMask;
        private System.Windows.Forms.TextBox textBoxGate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelMask;
        private System.Windows.Forms.Label labelGate;
        private System.Windows.Forms.Label labelDNS1;
        private System.Windows.Forms.Label labelDNS2;
        private System.Windows.Forms.TextBox textBoxShowIP;
        private System.Windows.Forms.TextBox textBoxShowMask;
        private System.Windows.Forms.TextBox textBoxShowGate;
        private System.Windows.Forms.TextBox textBoxShowDNS1;
        private System.Windows.Forms.TextBox textBoxShowDNS2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDNS2;
        private System.Windows.Forms.TextBox textBoxDNS1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRebootAdapter;
        private System.Windows.Forms.Button buttonRebootAll;
        private System.Windows.Forms.Button buttonDisableAdapter;
        private System.Windows.Forms.Button buttonEnableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

