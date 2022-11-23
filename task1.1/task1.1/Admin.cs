using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._1
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool isSuperAdmin, string section, string username, string password):base(username, password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }

        #region Methods
        public void FullInfo()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"IsSuperAdmin: {IsSuperAdmin}; Section: {Section}; Username: {_username}; Password: {_password}");
        }
        #endregion
    }
}
