using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Abstract
{
    internal class Account
    {
        public string Username;
        public string Password;
        
       

        public Account()
        {
            
        }
        public Account(string username, string password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public void CheckLogin(string username , string password)
        {
            string enteredusername = "AdminEA18yr@";
            string enteredpassword = "AdminEA18yr@";
            
            if (username == null || password == null)
            {
                Console.WriteLine("Yanlisdr");
            }
            else
            {
                if (enteredusername == Username && enteredpassword == Password)
                {
                    Console.WriteLine("giris ugurludur");
                }
                else
                {
                    Console.WriteLine("Sifre yanlisdir");
                }
            }

        }
        
    }
    
}
