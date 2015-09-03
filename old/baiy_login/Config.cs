using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace baiyLogin
{
    class Config
    {
        private string path = @"config.ini";
        private string configkey = "jiamimiyao";
        public  DataConfig config;

        /// <summary>
        /// 读取配置文件
        /// </summary>
        public void ReaderConfig()
        {
            if (ExistsConfig())
            {
                string[] str = File.ReadAllLines(path, System.Text.Encoding.Default);
                string data = string.Join("", str);
                JavaScriptSerializer js = new JavaScriptSerializer();
                config = js.Deserialize<DataConfig>(data);
                config.EncryptKey = Encrypt.decode(config.EncryptKey, configkey);
            }
            else 
            {
                throw new Exception("没有获取到程序配置 请先在程序下方写入程序配置");
            }
        }
    
        /// <summary>
        /// 写入配置文件
        /// </summary>
        /// <param name="ApiUrl">api url</param>
        /// <param name="EncryptKey">通讯秘钥</param>
        public void WriteConfig(string ApiUrl, string EncryptKey, string FtpPath, string SshPath,string FtpCmd,string SshCmd) 
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            DataConfig team = new DataConfig()
            {
               ApiUrl = ApiUrl,
               FtpPath = FtpPath,
               SshPath = SshPath,
               FtpCmd  = FtpCmd,
               SshCmd = SshCmd,
               EncryptKey = Encrypt.encode(EncryptKey, configkey)//通讯秘钥二次加密
            };
            string json = js.Serialize(team);
            StreamWriter sw = new StreamWriter(path, false);
            sw.WriteLine(json);
            sw.Close();
        }

        /// <summary>
        /// 判断配置文件是否存在
        /// </summary>
        /// <returns></returns>
        public Boolean ExistsConfig()
        {
            return File.Exists(path);
        }

    }

    class DataConfig
    {
        public string EncryptKey { get; set; }
        public string ApiUrl { get; set; }
        public string FtpPath { get; set; }
        public string SshPath { get; set; }
        public string FtpCmd { get; set; }
        public string SshCmd { get; set; }
    }
}
