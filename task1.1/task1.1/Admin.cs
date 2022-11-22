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


        public void IsSuperAdminAndSection()
        {
            Login();
            Console.WriteLine(" ");
            Console.WriteLine($"IsSuperAdmin: {IsSuperAdmin}; Section: {Section}; Username: {Username}; Password: {Password}");
        }
    }
}
