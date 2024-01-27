using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Runtime.Hosting;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Data;
// 210229027 Abdullah_Yilmaz

namespace _6012024
{
    internal class database
    {
        SQLiteConnection bag=new SQLiteConnection("Data Source="+Application.StartupPath+"\\data.db;Version=3;");
        SQLiteCommand komut = new SQLiteCommand();
       public database()
        {
            komut.Connection = bag;
        }
        public void hesapsil()
        {bag.Open();
            komut.CommandText = "delete from kullanici where username= '" + Form1.username + "'";
           komut.ExecuteNonQuery();bag.Close();

        }
        public void doğrulama(string mail,string telno)
        {
            bag.Open();
            komut.CommandText= "update kullanici set mail='"+mail+"',telno='"+telno+ "' where username ='"+Form1.username+"'";
            komut.ExecuteNonQuery();bag.Close();
        }
        public void ekle(string username,string password)
        {bag.Open();
           
            if (varmı(username)==false)
            {
                komut.CommandText = "insert into kullanici (username,password)values('" + username + "','" + password + "')";
                komut.ExecuteNonQuery();
            }
            bag.Close();

        }
        public void aracekle(string adı,string km,string fiyat,string hasarlar)
        {
            bag.Open();
            komut.CommandText = "INSERT INTO araclar (arac_adı, \"arac fiyatı\", km, hasarlar) VALUES (@AracAdi, @AracFiyati, @KM, @Hasarlar)";

            komut.Parameters.AddWithValue("@AracAdi", adı);
            komut.Parameters.AddWithValue("@AracFiyati", fiyat);
            komut.Parameters.AddWithValue("@KM", km);
            komut.Parameters.AddWithValue("@Hasarlar", hasarlar);


            komut.ExecuteNonQuery();bag.Close();
        }
       public bool giris(string username,string pass)
        {

            bag.Open();
            bool durum = false;
            komut.CommandText = "select * from kullanici  ";
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["username"].ToString() == username && oku["password"].ToString()==pass)
                    durum = true;

            }       oku.Close();
            bag.Close();
            return durum;
        }


      public  DataTable veri()
        {
            bag.Open();
            DataTable gonderveri=new DataTable();

            SQLiteDataAdapter gelenveri = new SQLiteDataAdapter("select * from araclar",bag);
            gelenveri.Fill(gonderveri);
            bag.Close();
            return gonderveri;
        }

        public bool varmı(string kullanıcı)
        {

            bool durum = false;
            komut.CommandText = "select username from kullanici  ";
            SQLiteDataReader oku= komut.ExecuteReader();
            while(oku.Read())
            {
                if (oku["username"].ToString()==kullanıcı)
                    durum = true;

            }oku.Close();
            return false;
        }
    }
}
