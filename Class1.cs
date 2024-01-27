using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 210229027 Abdullah_Yilmaz
namespace _6012024
{
    internal class Class1
    {
        //kullanıcının username işlemlerinin uyumluluğunu test ediyor



        public bool mail(string mail)
        {
           
            foreach (char item in mail)
            {
                if(item == '@' && (char.IsLetter(mail[0]) || char.IsNumber(mail[0])))
                {
                    return true;
                }
                    
            }
            return false;
        }
        public bool username_control(string username)
        { bool sart1=false,sart2=false,sart3=false,sart4=false;
            if(username.Length>5&&username.Length<20)
                sart1=true;
           foreach(char c in username)
            {
                if(char.IsNumber(c))
                    sart2 = true;
                if(char.IsLetter(c))
                    sart3 = true;
            }

           try
            {
                if (char.IsLetter(username[0]))
                    sart4 = true;
                if (sart4 && sart1 && sart2 && sart3)
                {
                    return true;
                }
                else { return false; }
            }
            catch
            {
                return false;

            }
           

        }
        //kullanıcının password işlemlerinin uyumluluğunu test ediyor
 public       bool password_control(string username)
        {

            bool sart1 = false, sart2 = false, sart3 = false, sart4 = false;
            foreach (char a in username)
            {
                if (char.IsNumber(a))
                    sart1 = true;
                if (char.IsUpper(a))
                    sart2 = true;
                if (char.IsLower(a))
                    sart3 = true;
                if (a == 32)
                    sart1 = false;
                if (!char.IsLetter(a) || !char.IsNumber(a))
                    sart4 = true;
            }

            if (sart1 && sart2 && sart3 && sart4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
