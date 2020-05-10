﻿using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;

namespace PiholeDashboard
{
    public partial class App : Application
    {

        public App()
        {

            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {

            string appcenterID = Environment.GetEnvironmentVariable("appcenterID");

            if (appcenterID != null && appcenterID.Length > 5)
            {
                AppCenter.Start($"ios={appcenterID}",
                    typeof(Analytics), typeof(Crashes));
            }

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
