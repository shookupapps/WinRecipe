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
   
    public partial class FavPage : PhoneApplicationPage
    {
        public ObservableCollection<MainRecipe> FB = new ObservableCollection<MainRecipe>();
        public FavPage()
        {
            InitializeComponent();
            FavDishBind();
        }
        public void FavDishBind()
        {
            FB.Add(new MainRecipe("Beijing", "/Assets/RecipeImages/beijing.jpg"));
            FB.Add(new MainRecipe("Chinese Bok Choys", "/Assets/RecipeImages/chinese-bok-choys.jpg"));
            FB.Add(new MainRecipe("Chinese Main Dish", "/Assets/RecipeImages/chinese-main-dish.jpg"));
            FB.Add(new MainRecipe("Chinese Rice", "/Assets/RecipeImages/chinese-rice.jpg"));
            FB.Add(new MainRecipe("Mongolian", "/Assets/RecipeImages/mongolian.jpg"));
            FB.Add(new MainRecipe("BeijTeriyaki", "/Assets/RecipeImages/teriyaki-sauce.jpg"));

            FB.Add(new MainRecipe("Teriyaki", "/Assets/RecipeImages/teriyaki-sauce.jpg"));
            FB.Add(new MainRecipe("Lasagne", "/Assets/RecipeImages/lasagne.jpg"));
            FB.Add(new MainRecipe("Italian Side Dish", "/Assets/RecipeImages/italian-side-dishes.jpg"));
            FB.Add(new MainRecipe("Italian Pasta", "/Assets/RecipeImages/italian-pasta.jpg"));
            FB.Add(new MainRecipe("Low Sugar", "/Assets/RecipeImages/italian-low-cholesterol.jpg"));
            FB.Add(new MainRecipe("Holiday", "/Assets/RecipeImages/italian-holiday-event.jpg"));
            FavDishList.DataContext = FB;

        }

        private void FavDishList_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SubDisgPage.xaml", UriKind.Relative));
        }

        private void Home_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}