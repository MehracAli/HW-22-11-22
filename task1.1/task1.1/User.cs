using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._1
{
    internal class User
    {
        private string _username;
        public string Username;
        private string _password;
        public string Password;
        
//Constructor
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
//Methods
        #region Methods
        public void Login()
        {
            Console.Write("Login: ");
            string UserName = Console.ReadLine();
            Username = UserName;
            if (UserName.Length > 6)
            {
                EnterPassword();
                _username = UserName;
            }
            else
            {
                Console.WriteLine("Enter Valid Username");
                Login();
            }
        }

        public void EnterPassword()
        {
            Console.Write("Password: ");
            string Pswrd = Console.ReadLine();
            Password = Pswrd;
            
            char[] ValueChars = Pswrd.ToCharArray();
            string ToUp = Pswrd.ToUpper();
            char[] ToUpChars = ToUp.ToCharArray();
            int count = 0;

            for (int i = 0; i < ValueChars.Length; i++)
            {
                if (ValueChars[i] == ToUpChars[i])
                {
                    count++;
                }
            }
            if (count > 0)
            {
                _password = Pswrd;
            }
            else
            {
                Console.WriteLine("Enter Valid Password");
                EnterPassword();
            }
        }
        #endregion
    }
}
