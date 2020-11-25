namespace MqttServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ServerIP = new System.Windows.Forms.Label();
            this.comb_ServerIP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ServerPort = new System.Windows.Forms.TextBox();
            this.btn_ServerStart = new System.Windows.Forms.Button();
            this.btn_ServerStop = new System.Windows.Forms.Button();
            this.btn_Publish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ServerIP
            // 
            this.lbl_ServerIP.AutoSize = true;
            this.lbl_ServerIP.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ServerIP.Location = new System.Drawing.Point(128, 92);
            this.lbl_ServerIP.Name = "lbl_ServerIP";
            this.lbl_ServerIP.Size = new System.Drawing.Size(99, 20);
            this.lbl_ServerIP.TabIndex = 0;
            this.lbl_ServerIP.Text = "ServerIp:";
            // 
            // comb_ServerIP
            // 
            this.comb_ServerIP.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_ServerIP.FormattingEnabled = true;
            this.comb_ServerIP.Location = new System.Drawing.Point(279, 84);
            this.comb_ServerIP.Name = "comb_ServerIP";
            this.comb_ServerIP.Size = new System.Drawing.Size(207, 28);
            this.comb_ServerIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ServerPort:";
            // 
            // tb_ServerPort
            // 
            this.tb_ServerPort.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_ServerPort.Location = new System.Drawing.Point(279, 144);
            this.tb_ServerPort.Name = "tb_ServerPort";
            this.tb_ServerPort.Size = new System.Drawing.Size(207, 30);
            this.tb_ServerPort.TabIndex = 3;
            this.tb_ServerPort.Text = "1883";
            // 
            // btn_ServerStart
            // 
            this.btn_ServerStart.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ServerStart.Location = new System.Drawing.Point(585, 78);
            this.btn_ServerStart.Name = "btn_ServerStart";
            this.btn_ServerStart.Size = new System.Drawing.Size(108, 34);
            this.btn_ServerStart.TabIndex = 4;
            this.btn_ServerStart.Text = "Start";
            this.btn_ServerStart.UseVisualStyleBackColor = true;
            this.btn_ServerStart.Click += new System.EventHandler(this.btn_ServerStart_Click);
            // 
            // btn_ServerStop
            // 
            this.btn_ServerStop.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ServerStop.Location = new System.Drawing.Point(585, 143);
            this.btn_ServerStop.Name = "btn_ServerStop";
            this.btn_ServerStop.Size = new System.Drawing.Size(108, 34);
            this.btn_ServerStop.TabIndex = 5;
            this.btn_ServerStop.Text = "Stop";
            this.btn_ServerStop.UseVisualStyleBackColor = true;
            this.btn_ServerStop.Click += new System.EventHandler(this.btn_ServerStop_Click);
            // 
            // btn_Publish
            // 
            this.btn_Publish.Location = new System.Drawing.Point(322, 331);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Size = new System.Drawing.Size(85, 31);
            this.btn_Publish.TabIndex = 6;
            this.btn_Publish.Text = "Publish";
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Click += new System.EventHandler(this.btn_Publish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Publish);
            this.Controls.Add(this.btn_ServerStop);
            this.Controls.Add(this.btn_ServerStart);
            this.Controls.Add(this.tb_ServerPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comb_ServerIP);
            this.Controls.Add(this.lbl_ServerIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ServerIP;
        private System.Windows.Forms.ComboBox comb_ServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ServerPort;
        private System.Windows.Forms.Button btn_ServerStart;
        private System.Windows.Forms.Button btn_ServerStop;
        private System.Windows.Forms.Button btn_Publish;
    }
}

