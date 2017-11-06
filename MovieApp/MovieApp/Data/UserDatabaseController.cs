using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Model;
using Xamarin.Forms;

namespace MovieApp.Data
{
    public class UserDatabaseController
    {
        static object loker = new object();
        SQLiteConnection database;

        public UserDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
        }

        public User GetUser() 
        {
            lock (loker)
                
            {
                if(database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else 
                {
                    return database.Table<User>().First();
                }
            }
        }

        public int SaveUser(User user)
        {
            lock(loker)
            {
                if(user.ID != 0)
                {
                    database.Update(user);
                    return user.ID;
                }
                else
                {
                    return database.Insert(user);
                }

            }
           
        }

        public int DeleteUser(int id)
        {
            lock(loker)
            {
                return database.Delete<User>(id);
            }
        }
    }
}
