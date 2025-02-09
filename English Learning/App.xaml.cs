﻿using English_Learning.Data;
using English_Learning.Services;
using English_Learning.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace English_Learning
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<DialogService>();//верно?
            DependencyService.Register<WordDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
