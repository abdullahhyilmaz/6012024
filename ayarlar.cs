using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 210229027 Abdullah_Yilmaz

namespace _6012024
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }
        database veri=new database();
        private void button1_Click(object sender, EventArgs e)
        {
            veri.hesapsil();
            Application.Restart();
        }
    }
}
