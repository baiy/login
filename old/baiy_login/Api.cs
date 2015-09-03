using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Web.Script.Serialization;

namespace baiyLogin
{
    class Api 
    {
        public string db_path = @"db.dat";
        public DataApi get()
        {         
            string db = GetDb();
            JavaScriptSerializer js = new JavaScriptSerializer();
            DataApi lists = js.Deserialize<DataApi>(db);
            return lists;
        }

        /// <summary>
        /// 判断配置文件是否存在
        /// </summary>
        /// <returns></returns>
        public Boolean ExistsDb()
        {
            return File.Exists(db_path);
        }

        /// <summary>
        /// 获取账号信息
        /// </summary>
        /// <returns>返回解密后的json格式内容</returns>
        public string GetDb()
        {
            Config con = new Config();
            con.ReaderConfig();
            string db = "";
            if(IsNet())
            {
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;
                Byte[] pageData = MyWebClient.DownloadData(con.config.ApiUrl);
                db = Encoding.UTF8.GetString(pageData);                
                StreamWriter sw = new StreamWriter(db_path, false);
                sw.WriteLine(db);
                sw.Close();
            }
            else
            {
                if (!ExistsDb())
                {
                    throw new Exception("请先连接网络 获取账号数据文件");
                }
                string[] str = File.ReadAllLines(db_path, System.Text.Encoding.Default);
                db = string.Join("",str);
            }

            return Encrypt.decode(db, con.config.EncryptKey);
        }

        /// <summary>
        /// 判断是否联网
        /// </summary>
        /// <returns></returns>
        public Boolean IsNet()
        {
            Ping p = new Ping();
            PingReply pr = p.Send("www.baidu.com");
            if (pr.Status != IPStatus.Success)
            {
                return false;
            }
            return true;
        }
    }
    
    
    /// <summary>
    /// api数据类型
    /// </summary>
    class DataApi
    {
        public List<DataFtp> ftp { get; set; }
        public List<DataMstsc> mstsc { get; set; }
        public List<DataSsh> ssh { get; set; }
        
    }

    /// <summary>
    /// FTP数据类型
    /// </summary>
    class DataFtp{
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string port { get; set; }
        public string protocol { get; set; }
        public string remarks { get; set; }
         
    }

    /// <summary>
    /// windows远程连接数据类型
    /// </summary>
    class DataMstsc{
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string port { get; set; }
        public string remarks { get; set; }
    }

    /// <summary>
    /// ssh数据类型
    /// </summary>
    class DataSsh{
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string port { get; set; }
        public string remarks { get; set; }
    }
}
