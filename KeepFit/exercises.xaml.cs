using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace KeepFit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class exercises : Page
    {
        public exercises()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void backPg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void absPg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AbsExe));
        }

        private void bootyPg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BootyExe));
        }

        private void legsPg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LegsExe));
        }

        private void armsPg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ArmsExe));

        }
    }
}
