using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baiyLogin
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private void form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetConfig();
                Api api = new Api();
                DataApi db = api.get();
                SetData(db);                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void SetConfig_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            string url = textapiurl.Text;
            string key = Textencryptkey.Text;
            string ftp = textBoxftppath.Text;
            string ssh = textBoxsshpath.Text;
            string ftpcmd = textBoxftpcmd.Text;
            string sshcmd = textBoxsshcmd.Text;
            config.WriteConfig(url, key, ftp, ssh, ftpcmd, sshcmd);
            MessageBox.Show("配置写入成功 程序将自动重启");
            Application.Restart();
        }

        private void SetData(DataApi db)
        {
            SetFtpData(db.ftp);
            SetMstscData(db.mstsc);
            SetSshData(db.ssh);
        }

        private void SetConfig()
        {
            Config con = new Config();
            con.ReaderConfig();
            textapiurl.Text = con.config.ApiUrl;
            textBoxftppath.Text = con.config.FtpPath;
            textBoxsshpath.Text = con.config.SshPath;
            textBoxftpcmd.Text = con.config.FtpCmd;
            textBoxsshcmd.Text = con.config.SshCmd;
    
        }

        private void SetFtpData(List<DataFtp> ftp) 
        {
            string[] lists= {};
            for (int i = 0; i < ftp.Count();i++ )
            {
                dataGridViewftp.Rows.Add(ftp[i].host, ftp[i].username, ftp[i].port, ftp[i].protocol, ftp[i].remarks, ftp[i].password);
            }
        }

        private void SetMstscData(List<DataMstsc> ftp)
        {
            string[] lists = { };
            for (int i = 0; i < ftp.Count(); i++)
            {
                dataGridViewmstsc.Rows.Add(ftp[i].host, ftp[i].username, ftp[i].port, ftp[i].remarks, ftp[i].password);
            }
        }

        private void SetSshData(List<DataSsh> ftp)
        {
            string[] lists = { };
            for (int i = 0; i < ftp.Count(); i++)
            {
                dataGridViewssh.Rows.Add(ftp[i].host, ftp[i].username, ftp[i].port, ftp[i].remarks, ftp[i].password);
            }
        }

        private void SelectFtpPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.exe)|*.exe";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                textBoxftppath.Text = file;                
            }
        }

        private void SelectSshPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.exe)|*.exe";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                textBoxsshpath.Text = file;
            }
        }

        private void dataGridViewmstsc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RunProgram.RunMstsc(
                    dataGridViewmstsc.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    dataGridViewmstsc.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridViewmstsc.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    dataGridViewmstsc.Rows[e.RowIndex].Cells[2].Value.ToString()
                );
        }

        private void dataGridViewssh_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RunProgram.RunSsh(
                    dataGridViewssh.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    dataGridViewssh.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridViewssh.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    dataGridViewssh.Rows[e.RowIndex].Cells[2].Value.ToString()
                );

        }

        private void dataGridViewftp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RunProgram.RunFtp(
                   dataGridViewftp.Rows[e.RowIndex].Cells[0].Value.ToString(),
                   dataGridViewftp.Rows[e.RowIndex].Cells[1].Value.ToString(),
                   dataGridViewftp.Rows[e.RowIndex].Cells[5].Value.ToString(),
                   dataGridViewftp.Rows[e.RowIndex].Cells[2].Value.ToString(),
                   dataGridViewftp.Rows[e.RowIndex].Cells[3].Value.ToString()
               );
        }

        private void buttonftplink_Click(object sender, EventArgs e)
        {
            RunProgram.RunFtp(
                  textBoxftphost.Text,
                  textBoxftpusername.Text,
                  textBoxftppassword.Text,
                  textBoxftpport.Text,
                  comboBoxftpprotocol.Text                   
               );
        }

        private void buttonmstsclink_Click(object sender, EventArgs e)
        {
            RunProgram.RunMstsc(
                  textBoxmstschost.Text,
                  textBoxmstscusername.Text,
                  textBoxmstscpassword.Text,
                  textBoxmstscport.Text
               );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RunProgram.RunSsh(
                  textBoxsshhost.Text,
                  textBoxsshusername.Text,
                  textBoxsshpassword.Text,
                  textBoxsshport.Text
               );
        }
    }
}
