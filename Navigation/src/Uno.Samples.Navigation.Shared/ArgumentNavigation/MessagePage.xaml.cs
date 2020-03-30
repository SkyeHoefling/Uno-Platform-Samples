using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Uno.Samples.Navigation.ArgumentNavigation
{
    public sealed partial class MessagePage : Page
    {
        public MessagePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Message.Text = (string)e.Parameter;
        }
    }
}
