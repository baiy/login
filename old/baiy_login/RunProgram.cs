using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baiyLogin
{
    class RunProgram
    {
        public static void RunFtp(string host, string username, string password, string port, string protocol) 
        {
            string Arguments = GetPath()
                                .FtpCmd
                                .Replace("{protocol}", protocol)
                                .Replace("{username}", username)
                                .Replace("{password}", password)
                                .Replace("{host}", host)
                                .Replace("{port}", port);
            command.startcmd2(GetPath().FtpPath, Arguments);
        }

        public static void RunMstsc(string host, string username, string password, string port)
        {
            command.startmmstsc(host, username, password, port);
        }

        public static void RunSsh(string host, string username, string password, string port)
        {
            string Arguments = GetPath()
                                .SshCmd
                                .Replace("{username}", username)
                                .Replace("{password}", password)
                                .Replace("{host}", host)
                                .Replace("{port}", port);
            command.startcmd2(GetPath().SshPath, Arguments);
        }

        private static DataConfig GetPath() 
        {
            Config con = new Config();
            con.ReaderConfig();
            return con.config;

        }
    }
}
