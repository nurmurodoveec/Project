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
        public string Login, Password, Email;
        public Users() { }

        public Users (string login, string password, string email)
        {
            this.Login = login;
            this.Password = password;
            this.Email =email;

        }
    

    }
}
