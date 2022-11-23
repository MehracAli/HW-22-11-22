﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._1
{
    internal class User
    {
        #region Username
        private protected string _username;
        public string Username
        {
            get 
            {
                return _username;
            }
            set 
            {
                Console.WriteLine("Enter Username: ");
                EnterUsername();
            }
        }
        #endregion

        #region Password
        private protected string _password;
        public string Password 
        {
            get 
            {
                return _password;
            }
            set 
            {
                Console.WriteLine("Enter Password:");
                EnterPassword();
            }
        }
        #endregion

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        #region Methods
        public void EnterUsername()
        {
            Console.Write("Login: ");
            string UserName = Console.ReadLine();
            _username = UserName;
            if (UserName.Length > 6)
            {
                _username = UserName;
            }
            else
            {
                Console.WriteLine("Enter Valid Username: ");
                EnterUsername();
            }
        }

        public void EnterPassword()
        {
            Console.Write("Password: ");
            string Pswrd = Console.ReadLine();
            _password = Pswrd;

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
