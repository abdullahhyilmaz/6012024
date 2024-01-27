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
    public partial class aracekle : Form
    {
        public aracekle()
        {
            InitializeComponent();
        }
        database veri=new database();
        private void button1_Click(object sender, EventArgs e)
        {
            veri.aracekle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MessageBox.Show("Veriler eklendi");
        }
    }
}
