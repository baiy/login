using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DevLogin.library
{
    class Command
    {
        /// <summary>
        /// 启动程序
        /// </summary>
        /// <param name="path">程序完整路径</param>
        /// <param name="Arguments">程序参数</param>
        public static void startcmd(string path, string Arguments,string type)
        {
            //windows远程桌面
            if (type == "mstsc")
            {
                Arguments = get_mstsc_arguments(Arguments);
            }
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = @path;
            process.StartInfo.Arguments = Arguments;
            process.Start();
        }

        //{username}:{password}@{host}:{port}
        public static string get_mstsc_arguments(string Arguments)
        {
            var p = Arguments.Split('@');
            var p0 = p[0].Split(':');
            var p1 = p[1].Split(':');
            string host = p1[0];
            string username = p0[0];
            string password = p0[1];
            string port = p1[1];
            password = rdp.Encrypt(password).Replace("-", "");
            string data = "screen mode id:i:2\n"
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
            return path;
        }
    }
}
