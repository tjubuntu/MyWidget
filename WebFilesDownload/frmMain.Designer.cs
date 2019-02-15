namespace WebFilesDownload
{
    partial class frmMain
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
            this.lblDownloadUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.txtRule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bgwDownload = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDownloadUrl
            // 
            this.lblDownloadUrl.AutoSize = true;
            this.lblDownloadUrl.Location = new System.Drawing.Point(13, 13);
            this.lblDownloadUrl.Name = "lblDownloadUrl";
            this.lblDownloadUrl.Size = new System.Drawing.Size(59, 12);
            this.lblDownloadUrl.TabIndex = 0;
            this.lblDownloadUrl.Text = "下载路径:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(78, 10);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(450, 21);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://www.shuxue9.com/pep/gzbixiu2/ebook";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件类型：";
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(78, 37);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(100, 21);
            this.txtFileType.TabIndex = 3;
            this.txtFileType.Text = ".jpg";
            // 
            // txtRule
            // 
            this.txtRule.Location = new System.Drawing.Point(78, 64);
            this.txtRule.Name = "txtRule";
            this.txtRule.Size = new System.Drawing.Size(100, 21);
            this.txtRule.TabIndex = 5;
            this.txtRule.Text = "{0:d3}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "命名规则：";
            // 
            // bgwDownload
            // 
            this.bgwDownload.WorkerReportsProgress = true;
            this.bgwDownload.WorkerSupportsCancellation = true;
            this.bgwDownload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDownload_DoWork);
            this.bgwDownload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwDownload_ProgressChanged);
            this.bgwDownload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDownload_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "下载进度：";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(372, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "下载";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(453, 62);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(250, 37);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(278, 21);
            this.txtPath.TabIndex = 11;
            this.txtPath.Text = "E:\\Download\\人教版高中数学教材课本\\第二册";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "保存位置：";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(250, 64);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 21);
            this.txtStart.TabIndex = 26;
            this.txtStart.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "起始位置：";
            // 
            // lbMsg
            // 
            this.lbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMsg.FormattingEnabled = true;
            this.lbMsg.ItemHeight = 12;
            this.lbMsg.Location = new System.Drawing.Point(15, 105);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(513, 232);
            this.lbMsg.TabIndex = 27;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 345);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblDownloadUrl);
            this.Name = "frmMain";
            this.Text = "网站批量下载工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDownloadUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.TextBox txtRule;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bgwDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbMsg;
    }
}