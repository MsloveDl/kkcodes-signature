namespace kkcodes_signature
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.webBrowserKKCodes = new System.Windows.Forms.WebBrowser();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查登录状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始自动签名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止自动签名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTryCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSuccessCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserKKCodes
            // 
            this.webBrowserKKCodes.AllowWebBrowserDrop = false;
            this.webBrowserKKCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserKKCodes.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserKKCodes.Location = new System.Drawing.Point(0, 25);
            this.webBrowserKKCodes.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserKKCodes.Name = "webBrowserKKCodes";
            this.webBrowserKKCodes.ScriptErrorsSuppressed = true;
            this.webBrowserKKCodes.Size = new System.Drawing.Size(1101, 520);
            this.webBrowserKKCodes.TabIndex = 0;
            this.webBrowserKKCodes.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowserKKCodes_NewWindow);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1101, 25);
            this.menuStripMain.TabIndex = 1;
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检查登录状态ToolStripMenuItem,
            this.开始自动签名ToolStripMenuItem,
            this.停止自动签名ToolStripMenuItem});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 检查登录状态ToolStripMenuItem
            // 
            this.检查登录状态ToolStripMenuItem.Name = "检查登录状态ToolStripMenuItem";
            this.检查登录状态ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.检查登录状态ToolStripMenuItem.Text = "检查登录状态";
            this.检查登录状态ToolStripMenuItem.Click += new System.EventHandler(this.检查登录状态ToolStripMenuItem_Click);
            // 
            // 开始自动签名ToolStripMenuItem
            // 
            this.开始自动签名ToolStripMenuItem.Name = "开始自动签名ToolStripMenuItem";
            this.开始自动签名ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.开始自动签名ToolStripMenuItem.Text = "开始自动签名";
            this.开始自动签名ToolStripMenuItem.Click += new System.EventHandler(this.开始自动签名ToolStripMenuItem_Click);
            // 
            // 停止自动签名ToolStripMenuItem
            // 
            this.停止自动签名ToolStripMenuItem.Name = "停止自动签名ToolStripMenuItem";
            this.停止自动签名ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.停止自动签名ToolStripMenuItem.Text = "停止自动签名";
            this.停止自动签名ToolStripMenuItem.Click += new System.EventHandler(this.停止自动签名ToolStripMenuItem_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTryCount,
            this.toolStripStatusLabelSuccessCount,
            this.toolStripStatusLabelScore,
            this.toolStripStatusLabelStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 523);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1101, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTryCount
            // 
            this.toolStripStatusLabelTryCount.Name = "toolStripStatusLabelTryCount";
            this.toolStripStatusLabelTryCount.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabelTryCount.Text = "尝试签到次数: 0";
            // 
            // toolStripStatusLabelSuccessCount
            // 
            this.toolStripStatusLabelSuccessCount.Name = "toolStripStatusLabelSuccessCount";
            this.toolStripStatusLabelSuccessCount.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabelSuccessCount.Text = "成功签到次数: 0";
            // 
            // toolStripStatusLabelScore
            // 
            this.toolStripStatusLabelScore.Name = "toolStripStatusLabelScore";
            this.toolStripStatusLabelScore.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabelScore.Text = "签到得分: 0";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(828, 17);
            this.toolStripStatusLabelStatus.Spring = true;
            this.toolStripStatusLabelStatus.Text = "运行状态";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 545);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.webBrowserKKCodes);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "KK源码网自动签名工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserKKCodes;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查登录状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始自动签名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止自动签名ToolStripMenuItem;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTryCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSuccessCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelScore;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
    }
}

