﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppTransportista.Pages;
using Xamarin.Forms;

namespace AppTransportista
{
    public partial class App : Application
    {
        #region Properties
        public static MasterPage Master { get; internal set; }
        public static NavigationPage Navigator { get; internal set; }
        #endregion


        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
