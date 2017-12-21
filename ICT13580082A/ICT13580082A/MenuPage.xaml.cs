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
            contentButton.Clicked += ContentButton_Clicked;
            navButton.Clicked += NavButton_Clicked;
            tabButton.Clicked += TabButton_Clicked;
            carouselButton.Clicked += CarouselButton_Clicked;

        }

        private void CarouselButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var cp = new CarouselPage();
            cp.Children.Add(new TabPage1());
            cp.Children.Add(new TabPage2());
            cp.Children.Add(new TabPage3());
            var tp = new NavigationPage(cp);
            mp.Detail = tp;
            mp.IsPresented = false;
        }

        private void TabButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());
            var np = new NavigationPage(tp);
            mp.Detail = np;
            mp.IsPresented = false;
        }

        private void NavButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new NavPage1());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        private void ContentButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new MyPage1());
            mp.Detail = np;
            mp.IsPresented = false;

        }

        private void AbsoluteButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new AbsolutePage());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        private void GridButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new GridPage());
            mp.Detail = np;
            mp.IsPresented = false;
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