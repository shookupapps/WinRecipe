using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CookMe.Resources;
using System.Collections.ObjectModel;
using CookMe.Binding;


namespace CookMe
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public ObservableCollection<MainRecipe> MB = new ObservableCollection<MainRecipe>();
        public MainPage()
        {
            InitializeComponent();
            MainRecipeBind();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        public  void MainRecipeBind() 
        {
            MB.Add(new MainRecipe( "Beijing","/Assets/RecipeImages/beijing.jpg"));
            MB.Add(new MainRecipe("Chinese Bok Choys", "/Assets/RecipeImages/chinese-bok-choys.jpg"));
            MB.Add(new MainRecipe("Chinese Main Dish", "/Assets/RecipeImages/chinese-main-dish.jpg"));
            MB.Add(new MainRecipe("Chinese Rice", "/Assets/RecipeImages/chinese-rice.jpg"));
            MB.Add(new MainRecipe("Mongolian", "/Assets/RecipeImages/mongolian.jpg"));
            MB.Add(new MainRecipe("BeijTeriyaki", "/Assets/RecipeImages/teriyaki-sauce.jpg"));
            MainList.DataContext = MB;
            
        }

        private void MainList_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SubDisgPage.xaml", UriKind.Relative));
        }

        private void Fav_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/FavPage.xaml", UriKind.Relative));
        }

        private void ShopList_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ShopListPage.xaml", UriKind.Relative));
        }

       
       
        
    }
}