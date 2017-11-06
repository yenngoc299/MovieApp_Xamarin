using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MovieApp.View.DetailView;

namespace MovieApp.View.Menu
{
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
        }
        async void Selectedscreen1(object seder, EventArgs e)
        {
            await Navigation.PushAsync(new InforScreen1());
        }
    }
}
