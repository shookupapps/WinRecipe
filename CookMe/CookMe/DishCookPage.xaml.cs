using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using CookMe.Binding;

namespace CookMe
{
    public partial class DishCookPage : PhoneApplicationPage
    {
        public ObservableCollection<MainRecipe> IN = new ObservableCollection<MainRecipe>();
        public DishCookPage()
        {
            InitializeComponent();
            IngBind();
        }
        public void IngBind()
        {
            IN.Add(new MainRecipe("Beijing yhdk kksyude jifjkks", "/Assets/RecipeImages/beijing.jpg"));
            IN.Add(new MainRecipe("Chinese Bok Choys the chopped mfruiua", "/Assets/RecipeImages/chinese-bok-choys.jpg"));
            IN.Add(new MainRecipe("Chinese Main Dish every day is mine", "/Assets/RecipeImages/chinese-main-dish.jpg"));
            IN.Add(new MainRecipe("Chinese Rice hreis opeeuc kifoa", "/Assets/RecipeImages/chinese-rice.jpg"));
            IN.Add(new MainRecipe("Mongolian nothsikdb ", "/Assets/RecipeImages/mongolian.jpg"));
            IN.Add(new MainRecipe("BeijTeriyaki jkjdpoe", "/Assets/RecipeImages/teriyaki-sauce.jpg"));

            IN.Add(new MainRecipe("Teriyaki hjsoid", "/Assets/RecipeImages/teriyaki-sauce.jpg"));
            IN.Add(new MainRecipe("Lasagne", "/Assets/RecipeImages/lasagne.jpg"));
            IN.Add(new MainRecipe("Italian Side Dish", "/Assets/RecipeImages/italian-side-dishes.jpg"));
            IN.Add(new MainRecipe("Italian Pasta", "/Assets/RecipeImages/italian-pasta.jpg"));
            IN.Add(new MainRecipe("Low Sugar", "/Assets/RecipeImages/italian-low-cholesterol.jpg"));
            IN.Add(new MainRecipe("Holiday", "/Assets/RecipeImages/italian-holiday-event.jpg"));
            ingreList.DataContext = IN;

        }
    }
}