using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Dakar.Phone.Resources;
using Dakar.Core.Services;
using Dakar.Phone.Models;

namespace Dakar.Phone
{
    public partial class MainPage : PhoneApplicationPage
   {
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            lstCompetitors.ItemsSource = await Services.GetBikesList();
            LoadAppBar();
        }

        private void LoadAppBar()
        {
            this.ApplicationBar = new ApplicationBar();
            
            ApplicationBarIconButton btnCalendar = new ApplicationBarIconButton();
            btnCalendar.IconUri = new Uri("/Assets/AppBar/.png",UriKind.Relative);
            btnCalendar.Text = "Calendar";
            btnCalendar.Click += btnCalendar_Click;
            ApplicationBar.Buttons.Add(btnCalendar);
        }

        void btnCalendar_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Calendar.xaml",UriKind.Relative));   
        }
    }
}