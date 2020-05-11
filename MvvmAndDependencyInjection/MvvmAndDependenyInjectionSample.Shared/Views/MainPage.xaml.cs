using Microsoft.Extensions.DependencyInjection;
using MvvmAndDependenyInjectionSample.ViewModels;
using Windows.UI.Xaml.Controls;

namespace MvvmAndDependenyInjectionSample.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var container = ((App)App.Current).Container;
            DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(MainViewModel));
        }
    }
}
