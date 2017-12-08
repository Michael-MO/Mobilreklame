﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Mobilreklame.Views.Domain.Ordre
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class View : Page
    {
        public View()
        {
            this.InitializeComponent();
        }

        private void ChangeToMonteringPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Levering.View), null);
        }

        private void ChangeToKundePage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Kunde.View), null);
        }
    }
}
