using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinFoodsBegin.Models;

namespace XamarinFoodsBegin.ViewModel
{
    public class MyListPageViewModel
    {
        public ObservableCollection<Food> FoodList{get;set;}

    public MyListPageViewModel()
        {
            FoodList = new ObservableCollection<Food>();
            FoodList.Add(new Food { DisplayName = "Kaşar Dolması", Detail = "Kaşarla sunulur", Contains = "mkxmx mkamkl as",ImageURL= "https://image.shutterstock.com/image-photo/grilled-chicken-rice-spicy-chickpeas-600w-587607935.jpg" });
            FoodList.Add(new Food { DisplayName = "Zeyin  Dolması", Detail = "zeyt sunulur", Contains = "möxkkasmxklaklmx" ,ImageURL= "https://image.shutterstock.com/image-photo/succulent-thick-juicy-portions-grilled-600w-138421859.jpg" });
            FoodList.Add(new Food { DisplayName = "Peynir Dolması", Detail = "peynirle sunulur", Contains = "mkjknfdfjsdjfjdjnjnf",ImageURL= "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_640.jpg" });
            FoodList.Add(new Food { DisplayName = "Sana Dolması", Detail = "sanayla sunulur", Contains = "qüwwqpllpq,",ImageURL= "https://cdn.pixabay.com/photo/2016/03/10/18/44/top-view-1248955_1280.jpg" });

        }

    }

}
