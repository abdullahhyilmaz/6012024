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
    public partial class dogrulama : Form
    {
        public dogrulama()
        {
            InitializeComponent();
        }
        Class1 veridogrula=new Class1();
        database veri=new database();
        private void button1_Click(object sender, EventArgs e)
        {
            if(veridogrula.mail(textBox2.Text))
            {
                veri.doğrulama(textBox1.Text, textBox2.Text);

                MessageBox.Show("Veri Doğrulandı");

            }
        }
    }
}
