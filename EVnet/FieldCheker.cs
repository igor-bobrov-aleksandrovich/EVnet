using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EVnet
{
    public static class FieldCheker
    {
        public static bool CheckLogin(string login)
        {
            Regex rx = new Regex(@"^[a-zA-Z](.[a-zA-Z0-9_-]*)$");
            return rx.IsMatch(login);
        }
        public static bool CheckPassword(string password)
        {
            Regex rx = new Regex(@"^[a-zA-Z0-9]{8,30}$");
            return rx.IsMatch(password);
        }
        public static bool CheckEmail(string email)
        {
            Regex rx = new Regex(@"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)");
            return rx.IsMatch(email);
        }
    }
}
