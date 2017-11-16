using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580082A
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
        public MenuPage()
        {
            InitializeComponent();
            viewButton.Clicked += ViewButton_Clicked;
            stackButton.Clicked += StackButton_Clicked;
            gridButton.Clicked += GridButton_Clicked;
            absoluteButton.Clicked += AbsoluteButton_Clicked;
        }

        private void AbsoluteButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new AbsolutePage());
        }

        private void GridButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new GridPage());
        }

        private void StackButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new StackPage());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        private void ViewButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new MainPage());
            mp.Detail = np;
            mp.IsPresented = false;

        }
    }
}