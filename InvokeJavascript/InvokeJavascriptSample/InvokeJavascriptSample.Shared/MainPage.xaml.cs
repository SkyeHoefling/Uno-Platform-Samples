using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

#if __WASM__
using Uno.Foundation;
#endif

namespace InvokeJavascriptSample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Tapped(object sender, RoutedEventArgs e)
        {
#if __WASM__
            WebAssemblyRuntime.InvokeJS("helloWorld()");
#endif
        }
    }
}
