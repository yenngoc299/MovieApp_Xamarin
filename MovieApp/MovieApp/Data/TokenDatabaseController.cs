using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using MovieApp.Model;

namespace MovieApp.Data
{
    public class TokenDatabaseController
    {
        static object loker = new object();
        SQLiteConnection database;

        public TokenDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Token>();
        }

        public Token GetToken()
        {
            lock (loker)
                 
            {
                if (database.Table<Token>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Token>().First();
                }
            }
        }

        public int SaveToken(Token token)
        {
            lock (loker)
            {
                if (token.Id != 0)
                {
                    database.Update(token);
                    return token.Id;
                }
                else
                {
                    return database.Insert(token);
                }

            }

        }

        public int DeleteToken(int id)
        {
            lock (loker)
            {
                return database.Delete<Token>(id);
            }
        }
    }
}
