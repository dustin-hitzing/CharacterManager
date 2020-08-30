﻿using System;
using CharacterManager.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CharacterManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CharacterSheetMainPage();
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