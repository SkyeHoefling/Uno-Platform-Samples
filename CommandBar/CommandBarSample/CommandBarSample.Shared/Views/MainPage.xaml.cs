using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CommandBarSample.Views
{
    public sealed partial class MainPage : Page
    {
        Type _currentPage;
        public MainPage()
        {
            this.InitializeComponent();
            _currentPage = typeof(HomePage);
            ContentView.Navigate(_currentPage);
        }

        void OnAppBarButtonTapped(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                var tag = element.Tag.ToString();
                Type page = null;
                switch (tag)
                {
                    case "Home":
                        page = typeof(HomePage);
                        break;
                    case "About":
                        page = typeof(AboutPage);
                        break;
                    case "Settings":
                        page = typeof(SettingsPage);
                        break;
                }

                if (_currentPage != page)
                {
                    _currentPage = page;
                    ContentView.Navigate(page);
                }
            }
        }
    }
}
