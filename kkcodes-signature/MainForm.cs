using System;
using System.ComponentModel;
using System.Windows.Forms;
using mshtml;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text.RegularExpressions;

namespace kkcodes_signature
{
    [ComVisible(true)]
    public partial class MainForm : Form
    {
        // 定义常量
        private const string KKCODES_LOGIN_URL = "http://www.kkcodes.cc/user/login.php";  // KKCodes登录页面
        private const string KKCODES_SIGNATURE_URL = "http://www.kkcodes.cc/money.html";  // KKCodes签到页面
        private const int REFRESH_INTERVAL = 10 * 60 * 1000;                              // 每10分钟尝试签到1次

        private const string SIGNATURE_FAILD = "你玩我？你不是已经领取金币了嘛，明天再来吧!";
        private const string SIGNATURE_SUCCESS = "恭喜您！";
        
        // 定义全局变量
        private static int nTryCount = 0;           // 尝试签到次数
        private static int nSuccessCount = 0;       // 成功签到次数
        private static int nScore = 0;              // 签到总得分

        public MainForm()
        {
            // 初始化UI状态
            InitializeComponent();
            开始自动签名ToolStripMenuItem.Enabled = true;
            停止自动签名ToolStripMenuItem.Enabled = false;
            toolStripStatusLabelStatus.BackColor = Color.Red;

            nTryCount = nSuccessCount = nScore = 0;

            webBrowserKKCodes.Navigate(KKCODES_SIGNATURE_URL);

            Log log = new Log();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            webBrowserKKCodes.ObjectForScripting = this;
        }

        /// <summary>
        /// 通过对NewWindow事件的响应实现禁止在新窗口打开网页, 同时强制在本地打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowserKKCodes_NewWindow(object sender, CancelEventArgs e)
        {
            // 禁止在新窗口打开网页, 同时强制在本地打开
            string strUrl = (sender as WebBrowser).StatusText;
            webBrowserKKCodes.Navigate(strUrl);
            e.Cancel = true;
        }

        private void 检查登录状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // GetAlertContent("恭喜您！金币领取成功！金币增加：17543个");
            MessageBox.Show("这个功能还没做呢!");
        }

        private void 开始自动签名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 设定并开启定时器
            timerRefresh.Interval = REFRESH_INTERVAL;
            timerRefresh.Start();
                        
            // 调整按钮状态
            开始自动签名ToolStripMenuItem.Enabled = false;
            停止自动签名ToolStripMenuItem.Enabled = true;
            toolStripStatusLabelStatus.BackColor = Color.Green;
        }

        private void 停止自动签名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 停止定时器
            timerRefresh.Stop();

            // 调整按钮状态
            开始自动签名ToolStripMenuItem.Enabled = true;
            停止自动签名ToolStripMenuItem.Enabled = false;
            toolStripStatusLabelStatus.BackColor = Color.Red;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            string strFuncName = "Sign";
            ClickSignature(strFuncName);
        }

        /// <summary>
        /// 触发签名事件
        /// </summary>
        /// <param name="strFuncName">触发的JavaScript函数名称</param>
        private void ClickSignature(string strFuncName)
        {
            webBrowserKKCodes.Document.InvokeScript(strFuncName);
            ClickAlert();

            // 更新尝试签名的次数
            nTryCount++;
            toolStripStatusLabelTryCount.Text = "尝试签到次数: " + nTryCount.ToString();
        }

        /// <summary>
        /// 捕获Alert弹出的内容, 通过回调GetAlertContent方法获取
        /// </summary>
        private void ClickAlert()
        {
            IHTMLDocument2 iHtmlDocument = webBrowserKKCodes.Document.DomDocument as IHTMLDocument2;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("var _alert=window.alert;\n");
            stringBuilder.Append("window.alert=function(str){\n");
            stringBuilder.Append("window.external.GetAlertContent(str);}");

            iHtmlDocument.parentWindow.execScript(stringBuilder.ToString(), "JavaScript");
        }

        /// <summary>
        /// 捕获Alert弹出的内容
        /// </summary>
        /// <param name="strTemp">JavaScript回调, 传入Alert弹出的对话框内容</param>
        public void GetAlertContent(string strTemp)
        {
            // 把Alert结果写入日志
            Log log = new Log();
            log.AppendLog();
            log.WriteLog(strTemp);

            // 如果没有签到成功, 则直接退出
            string strSuccessMessage = strTemp.Substring(0, 4);
            if (!strSuccessMessage.Equals(SIGNATURE_SUCCESS))
                return ;

            // 如果签到成功, 更新签到成功计数, 并且获取签到得分进行更新
            nSuccessCount++;
            toolStripStatusLabelSuccessCount.Text = "成功签到次数: " + nSuccessCount.ToString();

            string strScore = Regex.Replace(strTemp, @"[^\d\d]", "");
            nScore += int.Parse(strScore);
            toolStripStatusLabelScore.Text = "签到得分: " + nScore.ToString();
        }
    }
}
