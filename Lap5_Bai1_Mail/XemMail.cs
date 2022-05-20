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
    public partial class XemMail : Form
    {
        public XemMail()
        {
            InitializeComponent();
            
        }

        public void LoadNoiDungMail( string body)
        {
            textBox1.Text = body;
        }
    }
}
