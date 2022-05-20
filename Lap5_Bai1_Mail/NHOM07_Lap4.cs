using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap5_Bai1_Mail
{
    public partial class NHOM07_Lap4 : Form
    {
        public NHOM07_Lap4()
        {
            InitializeComponent();
        }

        private void btnBAI1_Click(object sender, EventArgs e)
        {
            Bai1 b = new Bai1();
            b.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai2 b = new Bai2();
            b.Show();
        }
    }
}
