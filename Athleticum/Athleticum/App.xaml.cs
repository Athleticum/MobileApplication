﻿using Athleticum.Common.XamarinCommon.Helpers;
using Athleticum.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Athleticum
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationHelpers.SetRootPage(typeof(ApplicationMainPage));
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
