﻿using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Shots.Helpers;
using Shots.Views;

namespace Shots
{
    /// <summary>
    ///     Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App
    {
        /// <summary>
        ///     Initializes the singleton application object.  This is the first line of authored code
        ///     executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
        }

        public new static App Current => Application.Current as App;

        public override Task OnInitializeAsync()
        {
            ApplicationView.GetForCurrentView().SetDesiredBoundsMode(ApplicationViewBoundsMode.UseCoreWindow);
            return Task.FromResult(0);
        }

        public override Task OnLaunchedAsync(ILaunchActivatedEventArgs e)
        {
            // Navigate to default page
            NavigationService.Navigate(typeof (MainPage));
            return Task.FromResult(0);
        }
    }
}