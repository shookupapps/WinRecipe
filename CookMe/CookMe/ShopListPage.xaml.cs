﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CookMe
{
    public partial class ShopListPage : PhoneApplicationPage
    {
        public ShopListPage()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Fav_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/FavPage.xaml", UriKind.Relative));
        }
    }
}