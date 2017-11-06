using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieApp.View;
using MovieApp.Data;

namespace MovieApp
{
    public partial class App : Application
    {

        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static UserDatabaseController UserDatabase
        {
            get
            {
                if (userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();

                }
                return userDatabase;
            }

        }
        public static TokenDatabaseController  TokenUserDatabase
        {
            get
            {
                if(tokenDatabase == null)
                {
                    userDatabase = new UserDatabaseController();

                }
                return tokenDatabase;
            }

        }

        public static RestService RestService
        {
            get
            {
                if(RestService == null)
                {
                    RestService = new RestService();
                }
                return RestService;
            }
        }
    }
}
