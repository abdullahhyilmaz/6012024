using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6012024
{
    public partial class kullanıcı : Form
    {
        public kullanıcı()
        {
            InitializeComponent();
        }
        database veri=new database();
        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayarlar ac= new ayarlar();
            ac.ShowDialog();
        }

        private void doğrulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dogrulama ac= new dogrulama();
            ac.ShowDialog();
        }

        private void kullanıcı_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veri.veri();
                }

        private void doğrulamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dogrulama ac = new dogrulama();
            ac.ShowDialog();

        }

        private void hesabıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayarlar ac = new ayarlar();
            ac.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracekle ac = new aracekle();
            ac.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
