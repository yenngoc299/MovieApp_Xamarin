using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovieApp.Model
{
    public class Constants
    {
        public static bool IsDev = true;

        public static Color BackgroundColor = Color.FromRgb(58, 153, 215);
        public static Color MainTextColor = Color.White;
        public static int LoginIconHeigh = 120;


        //-------login-----------
        public static string LoginUrl = "https://test.com/api/Auth/Login";
    }
}
