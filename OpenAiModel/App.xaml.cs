﻿using OpenAiModel.Views;

namespace OpenAiModel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
