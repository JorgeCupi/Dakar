using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Dakar.Phone.Models;

namespace Dakar.Phone.Views
{
    public partial class Calendar : PhoneApplicationPage
    {
        public Calendar()
        {
            InitializeComponent();
            this.Loaded += Calendar_Loaded;
        }

        void Calendar_Loaded(object sender, RoutedEventArgs e)
        {
            LoadRaceCalendar();    
        }

        private void LoadRaceCalendar()
        {
            RaceDates raceDates = new RaceDates();
            lstbRaceCalendar.ItemsSource = RaceDates.getRaceDates();
        }
    }
}