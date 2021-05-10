
namespace Server
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxPort = new System.Windows.Forms.TextBox();
            this.txtboxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Port:";
            // 
            // txtboxPort
            // 
            this.txtboxPort.Location = new System.Drawing.Point(287, 36);
            this.txtboxPort.Name = "txtboxPort";
            this.txtboxPort.Size = new System.Drawing.Size(102, 27);
            this.txtboxPort.TabIndex = 15;
            this.txtboxPort.Text = "9999";
            // 
            // txtboxIP
            // 
            this.txtboxIP.Location = new System.Drawing.Point(73, 36);
            this.txtboxIP.Name = "txtboxIP";
            this.txtboxIP.Size = new System.Drawing.Size(162, 27);
            this.txtboxIP.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "IP:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(403, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 37);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(603, 280);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // txtboxMessage
            // 
            this.txtboxMessage.Location = new System.Drawing.Point(34, 368);
            this.txtboxMessage.Multiline = true;
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.Size = new System.Drawing.Size(477, 41);
            this.txtboxMessage.TabIndex = 21;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(529, 368);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 41);
            this.btnSend.TabIndex = 20;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(532, 26);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 37);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 421);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtboxMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPort);
            this.Controls.Add(this.txtboxIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxPort;
        private System.Windows.Forms.TextBox txtboxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox txtboxMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStop;
    }
}

