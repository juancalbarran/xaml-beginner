﻿using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager.UniversalWindows
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SlideButton.Begin();
        }

        private void ExpeditePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ExpeditePage));
        }

        private void OrderPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OrderPage));
        }
    }
}
