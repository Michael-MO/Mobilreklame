using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Mobilreklame.Views.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ChangePageOrdre(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Domain.Ordre.View), null);
        }

        private void ChangeToMOnteringPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Domain.Levering.View), null);
        }

        private void ChangeToKundePage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Domain.Kunde.View), null);
        }
    }
}
