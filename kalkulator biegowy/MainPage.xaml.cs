using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using kalkulator_biegowy.Resources;

namespace kalkulator_biegowy
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void PrzyciskDystans_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Dystans.xaml", UriKind.Relative));
        }

       
        private void PrzyciskPredkosc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tempo.xaml", UriKind.Relative));
        }
       

 private void PrzyciskCzas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Czas.xaml", UriKind.Relative));
        }
       
        private void ZamknijBox_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Terminate();
        }

       

            
        }



        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
