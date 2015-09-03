using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevLogin.library;
using System.Net;

namespace DevLogin
{
    public partial class Form1 : Form
    {
        string[] args = null;
        public Form1(string[] args)
        {
            InitializeComponent();
            this.args = args;
        }

        private void From_Load(object sender, EventArgs e)
        {
            try
            {
                //获取参数
                var parameter = GetArgs(args);

                //打开应用
                openapp(parameter);

                //发起统计
                statistics(parameter[3]);
            }
            catch (Exception ex)
            {
                statistics("", ex.Message);
                MessageBox.Show(ex.Message);
            }
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 打开应用
        /// </summary>
        private static void openapp(string[] parameter)
        {
            var path = @parameter[1];
            var arguments = @parameter[2];
            Command.startcmd(path, arguments, parameter[0]);
        }

        /// <summary>
        /// 获取参数并解码
        /// </summary>
        private static string[] GetArgs(string[] args)
        {
            if (args.Length < 1)
            {
                throw new Exception("参数错误 格式:[protocol]://[type]/[path](des)/[parameter](des)/attach(des)/");
            }
            var p = args[0].Split('/');
            var s = new String[4];
            s[0] = p[2];
            s[1] = des.decode(p[3], Config.Get("decryptionkey"));
            s[2] = des.decode(p[4], Config.Get("decryptionkey"));
            s[3] = des.decode(p[5], Config.Get("decryptionkey"));
            return s;
        }

        /// <summary>
        /// 请求统计URL
        /// </summary>
        private static void statistics(string attach = "", string msg = "ok")
        {
            var url = Config.Get("statisticsurl") + "?attach=" + attach + "&msg=" + msg;
            WebClient wc = new WebClient();
            wc.DownloadData(url);
        }
    }
}
