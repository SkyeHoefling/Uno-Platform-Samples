using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace GettingStarted
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

#if __ANDROID__
            int[] position = new int[2];
            MyTextBlock.GetLocationOnScreen(position);
            Console.WriteLine($"MyTextBloc Position x:{position[0]}, y:{position[1]}");
#endif
        }
    }
}
