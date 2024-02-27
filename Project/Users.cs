using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Users
    {
        [Key]
        public int Id { get; set; }
        private string Login, Password, Email;

        public string login
        {
            get { return Login; }
            set { Login = value; }
        }
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public Users() { }

        public Users (string login, string password, string email)
        {
            this.Login = login;
            this.Password = password;
            this.Email =email;

        }
    

    }
}
