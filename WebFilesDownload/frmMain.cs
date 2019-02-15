using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebFilesDownload.Models;

namespace WebFilesDownload
{
    public partial class frmMain : Form
    {
        //文件数
        private int fileCount = 0;
        //文件命名规则
        private int fileRule = 0;
        //请求是否成功
        private bool success = false;
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 启动下载后台任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            fileCount = 1;
            fileRule = int.Parse(txtStart.Text);
            success = true;
            Action<string> clearMsg = (msg) =>
            {
                lbMsg.Items.Clear();
                lbMsg.Items.Add(msg);
            };
            lbMsg.Invoke(clearMsg, new object[] { "开始下载文件！" });
            bgwDownload.RunWorkerAsync();
        }
        /// <summary>
        /// 取消下载后台任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            lbMsg.Items.Add("停止下载文件！");
            bgwDownload.CancelAsync();
        }
        /// <summary>
        /// 后台任务执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            //检测是否取消当前任务
            if (!bgwDownload.CancellationPending)
            {
                while (success)
                {
                    FileEntity fe = new FileEntity();
                    string strRule = string.Format($"{txtRule.Text}", fileRule);
                    fe.fileUrl = $"{txtUrl.Text}/{strRule}{txtFileType.Text}";
                    fe.savePath = txtPath.Text;
                    fe.fileName = $"{strRule}{txtFileType.Text}";
                    //下载文件
                    HttpClient hc = new HttpClient();
                    HttpResponseMessage hrm = Task.Run(() => hc.GetAsync(fe.fileUrl)).Result;
                    long length = hc.MaxResponseContentBufferSize;
                    //检查是否请求成功
                    if (hrm.IsSuccessStatusCode)
                    {
                        byte[] btFile = hrm.Content.ReadAsByteArrayAsync().Result;
                        //检查文件大小
                        if (hrm.Content.Headers.ContentLength > 1)
                        {
                            //报告进度
                            bgwDownload.ReportProgress(fileCount, fe);
                            FileStream fsDownload = new FileStream($"{fe.savePath}\\{fe.fileName}", FileMode.Create);
                            fsDownload.Write(btFile, 0, btFile.Count());
                            fsDownload.Close();
                        }
                        else
                        {
                            success = false;
                        }
                    }
                    else
                    {
                        success = false;
                        break;
                    }
                    fileCount++;
                    fileRule++;
                }
                e.Result = "下载文件操作已完成！";
            }
            else
            {
                e.Result = "下载文件操作已取消！";
            }

        }
        /// <summary>
        /// 进度更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwDownload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            FileEntity fe = e.UserState as FileEntity;
            if (fe != null)
            {
                lbMsg.Items.Add($"开始下载文件{fe.fileName}！");
            }
        }
        /// <summary>
        /// 后台任务完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwDownload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbMsg.Items.Add(e.Result.ToString());
        }
    }

}
