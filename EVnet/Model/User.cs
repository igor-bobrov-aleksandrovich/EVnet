using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVnet.Model
{
    public class User
    {
        public int ID { get; private set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Avatar { get; set; }
        public virtual List<Notice> Notices { get; set; }

        public User()
        {
            ID = 0;
            Login = "";
            Email = "";
            Password = "";
            Avatar = new byte[0];
            Notices = new List<Notice>();
        }
        public User(int id, string login, string email, string password) 
        {
            ID = id;
            Login = login;
            Email = email;
            Password = password;
            Avatar = new byte[0];
            Notices = new List<Notice>();
        }
    }
}
