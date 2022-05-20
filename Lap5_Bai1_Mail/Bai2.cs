using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;


namespace Lap5_Bai1_Mail
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            LoadListView();
        }

        //Tạo danh sách các mail nhận về
        List<MimeMessage> listMail = new List<MimeMessage>();
        void LoadListView()
        {
            //Thiết kế giao diện
            listView1.Clear();
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Thời gian", 200);
            listView1.View = View.Details;
        }

        //Đăng nhập và lấy hòm thư về
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Login.Enabled = false;
                using (var client = new ImapClient())
                {

                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(textBox_Email.Text, textBox_passWord.Text);


                    var message = client.Inbox;
                    message.Open(FolderAccess.ReadOnly);
                    int countMessage = message.Count();
                    for (int i = 0; i < countMessage; i++)
                    {
                        ListViewItem email = new ListViewItem();
                        var item = message.GetMessage(i);
                        ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(email, item.From.ToString());
                        ListViewItem.ListViewSubItem thoiGian = new ListViewItem.ListViewSubItem(email, item.Date.ToString());
                        email.SubItems.Add(from);
                        email.SubItems.Add(thoiGian);

                        listView1.Items.Add(email);

                        listMail.Add(item);
                        listView1.AutoArrange = true;

                    }
                };
            }
            catch
            {
                MessageBox.Show("Lỗi chứng thực tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Login.Enabled = true;
            }



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if(listView1.SelectedItems.Count == 1 )
            {

                int thuTu;
                thuTu = listView1.SelectedItems[0].Index;
                string mess = listMail[thuTu].TextBody;
                XemMail xmail = new XemMail();
                xmail.LoadNoiDungMail(mess);
                xmail.Show();
                
            }    
        }
    }
}
