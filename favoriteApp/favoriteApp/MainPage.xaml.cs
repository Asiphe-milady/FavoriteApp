using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace favoriteApp
{
    public partial class MainPage : ContentPage
    {
        public static NavigationPage FavApp { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            
            //NewMethod(navigationPage);

        }

        private void NewMethod(NavigationPage navigationPage)
        {
            throw new NotImplementedException();
        }

        private void OnEpisodesSwipeItemInvoked(object sender, EventArgs a)
        {

        }
    }
}