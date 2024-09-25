using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostControl
{
    public class User
    {
        private int _id; 
        private string _name;
        private string _login;
        private string _password;
        private string _role;

        public string GetLogin()
        {
            return _login;
        }
        public string GetRole()
        {
            return _role;
        }
        public void SetLogin(string login)
        {
            _login = login;
        }
        public void SetRole(string role)
        {
            _role = role;
        }
        public void ChangePassword(string newPassword)
        {
            _password = newPassword;
        }
        public void ChangeLogin(string newLogin)
        {
            _login = newLogin;
        }



    }
}
