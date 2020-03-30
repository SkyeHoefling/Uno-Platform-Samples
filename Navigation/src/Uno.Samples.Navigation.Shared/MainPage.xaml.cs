using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Uno.Samples.Navigation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Clicked(object sender, RoutedEventArgs args)
        {
            if (sender == Basic)
                Frame.Navigate(typeof(BasicNavigation.MainPage));
            else if (sender == Argument)
                Frame.Navigate(typeof(ArgumentNavigation.MainPage));
            else if (sender == Animation)
                Frame.Navigate(typeof(AnimationNavigation.MainPage));
        }
    }
}
