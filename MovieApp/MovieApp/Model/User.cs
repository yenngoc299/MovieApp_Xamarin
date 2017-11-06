using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MovieApp.Model
{
    public class User
    {
        [PrimaryKey]
        public int ID { get; set; }
        public String Username { get; set; }
        public string Password { get; set; }

        public User(){}
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
