using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("auto@ipentec.net", "自動送信メール");
            msg.To.Add(new MailAddress("@gmail.com", "SampleMan"));//送信先gmail
            msg.Subject = "メッセージ件名";
            msg.Body = "メール本文です。";

            SmtpClient sc = new SmtpClient();

            sc.Host = "smtp.gmail.com";
            sc.Port = 587;
            sc.Credentials = new System.Net.NetworkCredential("@gmail.com", "アプリログインパスワード");//googleでアプリパスワードの設定を行う必要あり
            sc.EnableSsl = true;

            sc.Send(msg);
            msg.Dispose();


        }
    }
}
