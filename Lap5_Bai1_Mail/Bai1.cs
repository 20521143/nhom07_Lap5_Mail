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

namespace Lap5_Bai1_Mail
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            using(SmtpClient smtpClient =new SmtpClient("127.0.0.1") )
            {
                string mailfrom = texb_From.Text.ToString().Trim();
                string mailto = texb_To.Text.ToString().Trim();
                string password = teb_PassWord.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using(MailMessage message =new MailMessage())
                {

                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = texb_Subject.Text;
                    message.IsBodyHtml = false;
                    message.Body = texb_Body.Text;
                    message.To.Add(mailto);
                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                }
            }
        }
    }
}
