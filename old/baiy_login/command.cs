using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace baiyLogin
{
    class command
    {
        public static string startcmd(string command)
        {
            Process p = new Process();  // 初始化新的进程
            p.StartInfo.FileName = "cmd.exe"; //创建CMD.EXE 进程
            p.StartInfo.RedirectStandardInput = true; //重定向输入
            p.StartInfo.RedirectStandardOutput = true;//重定向输出
            p.StartInfo.UseShellExecute = false; // 不调用系统的Shell
            p.StartInfo.RedirectStandardError = true; // 重定向Error
            p.StartInfo.CreateNoWindow = true; //不创建窗口
            p.Start(); // 启动进程
            p.StandardInput.WriteLine(command); // Cmd 命令
            p.StandardInput.WriteLine("exit"); // 退出
            string s = p.StandardOutput.ReadToEnd(); //将输出赋值给 S
            p.WaitForExit();  // 等待退出
            return s;
        }

        public static void startcmd2(string path, string Arguments)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = @path; //"输入完整的路径"
            process.StartInfo.Arguments = Arguments; //启动参数  
            process.Start();            
        }

        public static void startmmstsc(string host, string username, string password, string port) 
        {
            password = Encrypt.rdpencode(password);
            string data =   "screen mode id:i:2\n"
                             + "desktopwidth:i:1280\n"
                             + "desktopheight:i:800\n"
                             + "session bpp:i:16\n"
                             + "winposstr:s:0,3,0,0,800,600\n"
                             + "full address:s:" + host + ":" + port + "\n"
                             + "compression:i:1\n"
                             + "keyboardhook:i:2\n"
                             + "audiomode:i:0\n"
                             + "redirectdrives:i:1\n"
                             + "redirectprinters:i:0\n"
                             + "redirectcomports:i:0\n"
                             + "redirectsmartcards:i:1\n"
                             + "displayconnectionbar:i:1\n"
                             + "autoreconnection enabled:i:1\n"
                             + "username:s:" + username + "\n"
                             + "alternate shell:s:\n"
                             + "shell working directory:s:\n"
                             + "password 51:b:" + password + "\n"
                             + "disable wallpaper:i:1\n"
                             + "disable full window drag:i:1\n"
                             + "disable menu anims:i:1\n"
                             + "disable themes:i:0\n"
                             + "disable cursor setting:i:0\n"
                             + "bitmapcachepersistenable:i:1\n"
                             + "use multimon:i:0\n"
                             + "audiocapturemode:i:0\n"
                             + "videoplaybackmode:i:1\n"
                             + "connection type:i:2\n"
                             + "allow font smoothing:i:0\n"
                             + "allow desktop composition:i:0\n"
                             + "redirectclipboard:i:1\n"
                             + "redirectposdevices:i:0\n"
                             + "redirectdirectx:i:1\n"
                             + "drivestoredirect:s:\n"
                             + "authentication level:i:0\n"
                             + "prompt for credentials:i:0\n"
                             + "negotiate security layer:i:1\n"
                             + "remoteapplicationmode:i:0\n"
                             + "gatewayhostname:s:\n"
                             + "gatewayusagemethod:i:4\n"
                             + "gatewaycredentialssource:i:4\n"
                             + "gatewayprofileusagemethod:i:0\n"
                             + "promptcredentialonce:i:1\n"
                             + "use redirection server name:i:0\n";
            string path = System.IO.Path.GetTempPath();
            path = path + ((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000).ToString() + ".tmp";
            StreamWriter sw = new StreamWriter(path, false);
            sw.WriteLine(data);
            sw.Close();
            startcmd2("mstsc.exe", path);
        }
    }
}
