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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace KeepFit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StrPag : Page
    {
        public StrPag()
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
        private Uri uri;
        private void img1_tapped(object sender, TappedRoutedEventArgs e)
        {

            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img1")
            {
                uri = new Uri("ms-appx:///Assets/armStr1.jpg");
            }
            
            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
            txtblock1.Visibility = Visibility.Visible;
        }

        private void img2_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img2")
            {
                uri = new Uri("ms-appx:///Assets/armStr2.jpg");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
            
           
        }

        private void img3_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img3")
            {
                uri = new Uri("ms-appx:///Assets/armStr3.jpg");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
        }

        private void img4_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img4")
            {
                uri = new Uri("ms-appx:///Assets/armStr4.jpg");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
        }

        private void img5_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img5")
            {
                uri = new Uri("ms-appx:///Assets/legStr1.JPG");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
            txtblock2.Visibility = Visibility.Visible;
        }

        private void img6_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img6")
            {
                uri = new Uri("ms-appx:///Assets/legStr2.jpg");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
        }

        private void img7_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img7")
            {
                uri = new Uri("ms-appx:///Assets/legStr3.jpg");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
        }

        private void img8_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img8")
            {
                uri = new Uri("ms-appx:///Assets/legStr4.gif");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
        }

        private void img9_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img9")
            {
                uri = new Uri("ms-appx:///Assets/legStr5.jpg");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
        }

        private void img10_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img10")
            {
                uri = new Uri("ms-appx:///Assets/legStr6.jpg");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
        }

        private void img11_tapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            string tag = img.Tag.ToString();



            if (tag == "img11")
            {
                uri = new Uri("ms-appx:///Assets/armStr10.jpg");
            }

            //BitmapIcon bitmapImage = new BitmapIcon();

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = uri;
            displayImg.Source = bitmapImage;
        }

        private void backPg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Streches));
        }
    }
}
