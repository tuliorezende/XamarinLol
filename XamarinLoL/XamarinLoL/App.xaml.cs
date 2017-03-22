﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinLoL.Models;

namespace XamarinLoL
{
    public partial class App : Application
    {
        public static SummonerModel Summoner { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinLoL.Views.SearchSummonerPage();
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
