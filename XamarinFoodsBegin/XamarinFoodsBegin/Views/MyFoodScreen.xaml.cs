using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFoodsBegin.Models;
using XamarinFoodsBegin.ViewModel;

namespace XamarinFoodsBegin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFoodScreen : ContentPage
    {
       // public ObservableCollection<Food> FoodList = new ObservableCollection<Food>();

        public MyFoodScreen()
        {
            InitializeComponent();
            BindingContext = new MyListPageViewModel();

           
         


        }
        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            Food myDetails = new Food();
            myDetails = e.Item as Food;
            await Navigation.PushAsync(new MySelectedFood(myDetails));

        }
    }
}