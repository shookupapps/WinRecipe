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
    public partial class SubDisgPage : PhoneApplicationPage
    {
        public ObservableCollection<MainRecipe> SB = new ObservableCollection<MainRecipe>();
        public SubDisgPage()
        {
            InitializeComponent();
            SubDishBind();
        }
        public void SubDishBind()
        {
            SB.Add(new MainRecipe("Beijing", "/Assets/RecipeImages/beijing.jpg"));
            SB.Add(new MainRecipe("Chinese Bok Choys", "/Assets/RecipeImages/chinese-bok-choys.jpg"));
            SB.Add(new MainRecipe("Chinese Main Dish", "/Assets/RecipeImages/chinese-main-dish.jpg"));
            SB.Add(new MainRecipe("Chinese Rice", "/Assets/RecipeImages/chinese-rice.jpg"));
            SB.Add(new MainRecipe("Mongolian", "/Assets/RecipeImages/mongolian.jpg"));
            SB.Add(new MainRecipe("BeijTeriyaki", "/Assets/RecipeImages/teriyaki-sauce.jpg"));

            SB.Add(new MainRecipe("Teriyaki", "/Assets/RecipeImages/teriyaki-sauce.jpg"));
            SB.Add(new MainRecipe("Lasagne", "/Assets/RecipeImages/lasagne.jpg"));
            SB.Add(new MainRecipe("Italian Side Dish", "/Assets/RecipeImages/italian-side-dishes.jpg"));
            SB.Add(new MainRecipe("Italian Pasta", "/Assets/RecipeImages/italian-pasta.jpg"));
            SB.Add(new MainRecipe("Low Sugar", "/Assets/RecipeImages/italian-low-cholesterol.jpg"));
            SB.Add(new MainRecipe("Holiday", "/Assets/RecipeImages/italian-holiday-event.jpg"));
            SubDishList.DataContext = SB;

        }

        private void SubDishList_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DishCookPage.xaml", UriKind.Relative));
        }
    }
}