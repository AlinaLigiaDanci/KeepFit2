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
    public sealed partial class Snacks : Page
    {
        public Snacks()
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
            this.Frame.Navigate(typeof(videos));
        }
        private void btnDigiClick(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += (string)((Button)sender).Content;
        }

        private void btnOperatorClick(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += " " + (string)((Button)sender).Content + " ";
        }

        private void btnEqualsClick(object sender, RoutedEventArgs e)
        {
            string[] text = txtOutput.Text.Split();

            double n1 = double.Parse(text[0]);
            double n2 = double.Parse(text[2]);

            if (text[1] == "+")
            {
                txtOutput.Text = (n1 + n2).ToString();
            }
            else if (text[1] == "-")
            {
                txtOutput.Text = (n1 - n2).ToString();
            }
            else if (text[1] == "/")
            {
                if (n2 == 0.0)
                    txtOutput.Text = "Error";
                else
                    txtOutput.Text = (n1 / n2).ToString();
            }
            else if (text[1] == "*")
            {
                txtOutput.Text = (n1 * n2).ToString();
            }
            //txtOutput.Text = text.Count().ToString();

        }

        private void bynClearClick(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = " ";
        }
    }
}
