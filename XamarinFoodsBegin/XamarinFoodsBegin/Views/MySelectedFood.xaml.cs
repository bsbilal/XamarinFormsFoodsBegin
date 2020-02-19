using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFoodsBegin.Models;

namespace XamarinFoodsBegin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MySelectedFood : ContentPage
    {
        public MySelectedFood(Food SelectedFood)
        {
            InitializeComponent();
            MyItemName.Text = SelectedFood.DisplayName;
            MyItemDetails.Text = SelectedFood.Detail;
            MyItemContains.Text = SelectedFood.Contains;
            MyFoodImage.Source = new UriImageSource()
            {
                Uri = new Uri(SelectedFood.ImageURL)
            };

            this.Title=$" {SelectedFood.DisplayName} tarifi";
        }
    }
}