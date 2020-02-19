using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFoodsBegin.Views;

namespace XamarinFoodsBegin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyFoodScreen());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
