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
    public partial class Form1 : Form
    {
        Class1 Class1 = new Class1();
        database veri=new database();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static string username;
        private void button1_Click(object sender, EventArgs e)
        {
                
                if (veri.giris(login_username.Text, login_password.Text))
            {
                username = login_username.Text;
                kullanıcı ac = new kullanıcı();
                ac.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            if(login_password!=null&&login_username!=null)
            {
                if (Class1.username_control(login_username.Text) && Class1.password_control(login_password.Text))
                {
                    veri.ekle(login_username.Text, login_password.Text);
                    MessageBox.Show("kullanıcı eklendi");
                }
            }else
            {
                MessageBox.Show("Lütfen Tüm alanları doldurun");
            }
           
        }
      

        private void login_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||char.IsNumber(e.KeyChar)||e.KeyChar==8)
            {e.Handled = false;

            }else { e.Handled = true; } 
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {

            login_password.UseSystemPasswordChar = login_showPass.Checked;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login_showPass.Checked = true;
        }
    }
}
