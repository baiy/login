using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace install
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                set_config();
                set_reg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void set_reg()
        {
            var reg = "Windows Registry Editor Version 5.00
            [HKEY_CLASSES_ROOT\baiy]
            @="URL: baiy Application DevLogin"
            "URL Protocol"=""
            [HKEY_CLASSES_ROOT\baiy\DefaultIcon]
            @="E:\\net\\DevLogin\\DevLogin\\bin\\Debug\\DevLogin.exe,1"
            [HKEY_CLASSES_ROOT\baiy\shell]
            [HKEY_CLASSES_ROOT\baiy\shell\open]
            [HKEY_CLASSES_ROOT\baiy\shell\open\command]
            @="\"E:\\net\\DevLogin\\DevLogin\\bin\\Debug\\DevLogin.exe\" \"%1\""";

            
            
        }


        private void set_config() {
            var decryptionkey = textBox1.Text;
            var statisticsurl = textBox2.Text;
            if(decryptionkey == "" || statisticsurl == ""){
                throw new Exception("配置不能为空");
            }
            var config = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><configuration><appSettings>";
            config += "<add key=\"decryptionkey\" value=\""+decryptionkey+"\" />";
            config += "<add key=\"statisticsurl\" value=\""+statisticsurl+"\" />";
            config += "</appSettings></configuration>";
            System.IO.File.WriteAllText(@"app.config", config, Encoding.UTF8);
        }
    }
}
