using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CommandBarSample.Shared.Views
{
    public sealed partial class MainPage : Page
    {
        Type currentPage;
        public MainPage()
        {
            InitializeComponent();
            currentPage = typeof(HomePage);
            contentView.Navigate(currentPage);
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
                    case "Info":
                        page = typeof(InfoPage);
                        break;
                    case "About":
                        page = typeof(AboutPage);
                        break;
                }

                if (currentPage != page)
                {
                    currentPage = page;
                    contentView.Navigate(page);
                }
            }
        }
    }
}
