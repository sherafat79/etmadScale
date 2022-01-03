namespace etmadScale
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtshowReadData = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.serialPortInput = new System.IO.Ports.SerialPort(this.components);
            this.txtmode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShowData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPortName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(369, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(244, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(125, 164);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(108, 37);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "قطع اتصال";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(7, 164);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 37);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "اتصال به ترازو";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBaudRate.FormattingEnabled = true;
            this.txtBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "3600",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.txtBaudRate.Location = new System.Drawing.Point(7, 55);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(157, 27);
            this.txtBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "baudRate :";
            // 
            // txtPortName
            // 
            this.txtPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPortName.FormattingEnabled = true;
            this.txtPortName.Location = new System.Drawing.Point(6, 18);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(158, 27);
            this.txtPortName.TabIndex = 1;
            this.txtPortName.DropDown += new System.EventHandler(this.txtPortName_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "پورت : ";
            // 
            // txtshowReadData
            // 
            this.txtshowReadData.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtshowReadData.Font = new System.Drawing.Font("IRANSansWeb", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshowReadData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtshowReadData.Location = new System.Drawing.Point(12, 12);
            this.txtshowReadData.Multiline = true;
            this.txtshowReadData.Name = "txtshowReadData";
            this.txtshowReadData.ReadOnly = true;
            this.txtshowReadData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtshowReadData.Size = new System.Drawing.Size(351, 207);
            this.txtshowReadData.TabIndex = 1;
            this.txtshowReadData.Text = "READY TO CONNECT";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 25);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtmode
            // 
            this.txtmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmode.FormattingEnabled = true;
            this.txtmode.Items.AddRange(new object[] {
            "ترمینال",
            "وزن در لحظه "});
            this.txtmode.Location = new System.Drawing.Point(6, 96);
            this.txtmode.Name = "txtmode";
            this.txtmode.Size = new System.Drawing.Size(158, 27);
            this.txtmode.TabIndex = 16;
            this.txtmode.SelectedIndexChanged += new System.EventHandler(this.txtmode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "حالت نمایش:";
            // 
            // lblShowData
            // 
            this.lblShowData.AutoSize = true;
            this.lblShowData.BackColor = System.Drawing.Color.Black;
            this.lblShowData.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowData.ForeColor = System.Drawing.Color.Red;
            this.lblShowData.Location = new System.Drawing.Point(85, 85);
            this.lblShowData.Name = "lblShowData";
            this.lblShowData.Size = new System.Drawing.Size(180, 48);
            this.lblShowData.TabIndex = 17;
            this.lblShowData.Text = "----------";
            this.lblShowData.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "شرکت فنی مهندسی پیشروتک صدرا یزد";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 253);
            this.Controls.Add(this.lblShowData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtshowReadData);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "etemad scale monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtshowReadData;
        private System.Windows.Forms.Button btnClear;
        private System.IO.Ports.SerialPort serialPortInput;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox txtmode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShowData;
        private System.Windows.Forms.Label label5;
    }
}

