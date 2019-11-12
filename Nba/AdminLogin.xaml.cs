﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Nba {

    public partial class AdminLogin : Page {
        public AdminLogin() {
            InitializeComponent();
        }

        private void OnPageLoad(object sender, RoutedEventArgs e) {
            Window.GetWindow(this).Title = "Admin Login";
        }

        private void BackClick(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new Uri("StartPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CancelClick(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new Uri("StartPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}