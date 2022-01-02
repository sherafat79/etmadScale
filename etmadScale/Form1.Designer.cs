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
            this.btnHold = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPortInput = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPortName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(384, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(404, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(151, 229);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(139, 37);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "قطع اتصال";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 229);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(139, 37);
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
            this.txtBaudRate.Location = new System.Drawing.Point(24, 152);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(282, 32);
            this.txtBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "baudRate :";
            // 
            // txtPortName
            // 
            this.txtPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPortName.FormattingEnabled = true;
            this.txtPortName.Location = new System.Drawing.Point(24, 46);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(282, 32);
            this.txtPortName.TabIndex = 1;
            this.txtPortName.DropDown += new System.EventHandler(this.txtPortName_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "پورت : ";
            // 
            // txtshowReadData
            // 
            this.txtshowReadData.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtshowReadData.Font = new System.Drawing.Font("IRANSansWeb", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshowReadData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtshowReadData.Location = new System.Drawing.Point(12, 27);
            this.txtshowReadData.Multiline = true;
            this.txtshowReadData.Name = "txtshowReadData";
            this.txtshowReadData.ReadOnly = true;
            this.txtshowReadData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtshowReadData.Size = new System.Drawing.Size(351, 169);
            this.txtshowReadData.TabIndex = 1;
            this.txtshowReadData.Text = "READY TO CONNECT";
            // 
            // btnHold
            // 
            this.btnHold.Enabled = false;
            this.btnHold.Location = new System.Drawing.Point(257, 241);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(106, 37);
            this.btnHold.TabIndex = 10;
            this.btnHold.Text = "HOLD";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnZero
            // 
            this.btnZero.Enabled = false;
            this.btnZero.Location = new System.Drawing.Point(132, 241);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(106, 37);
            this.btnZero.TabIndex = 11;
            this.btnZero.Text = "ZERO";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 37);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "شرکت فنی مهندسی پیشروتک صدرا یزد";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.txtshowReadData);
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
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPortInput;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

