﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinLocalDataAccessDemo.Pages;

namespace XamarinLocalDataAccessDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LocalDataButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReadApplicationBaseDataDemoPage());
        }

        private void EditApplicationBaseDataButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditApplicationBaseDataDemoPage());
        }

        private void SecureDataButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SaveSecureDataDemoPage());
        }

        private void SqliteButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SqliteDemoPage());
        }

        private void EfCoreButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EfCoreDemoPage());
        }
    }
}
