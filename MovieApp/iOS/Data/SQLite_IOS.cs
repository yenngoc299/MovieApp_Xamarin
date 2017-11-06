  
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MovieApp.iOS;
using MovieApp.Data;
using Xamarin.Forms;
using MovieApp.iOS.Data;
using SQLite;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace MovieApp.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS(){}
        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath =Path.Combine(documentPath, "..","Library");
            var path = Path.Combine(libraryPath, fileName);

            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    } 


}




