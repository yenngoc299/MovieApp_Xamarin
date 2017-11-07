using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using MovieApp.Model;
using MovieApp.View.DetailView;

namespace MovieApp.View.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Masterpage : ContentPage
    {
        public ListView ListView { get { return listview; } }

        public List<MasterMenuItem> items;

        public Masterpage()
        {
            InitializeComponent();
            SetItems();

        }

        void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("InforScreen1","icon.pgn",Color.White,typeof(InforScreen1)));
            items.Add(new MasterMenuItem("InforScreen2", "icon.pgn", Color.White, typeof(InforScreen2)));
            ListView.ItemsSource = items;
        }
    }
}
