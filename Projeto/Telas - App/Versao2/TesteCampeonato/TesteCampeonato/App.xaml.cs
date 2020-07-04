﻿using System;
using TesteCampeonato.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteCampeonato
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PrincipalView();
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
