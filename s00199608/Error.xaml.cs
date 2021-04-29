using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace s00199608
{
    /// <summary>
    /// Interaction logic for Error.xaml
    /// </summary>
    public partial class Error : Window
    {
        public Error(Anime selected)
        {
            InitializeComponent();
            Image myimage = new Image();
            myimage.Width = 300;

            BitmapImage mybitmapImage = new BitmapImage();

            mybitmapImage.BeginInit();
            mybitmapImage.UriSource = new Uri(selected.Image);
            mybitmapImage.DecodePixelWidth = 300;
            mybitmapImage.EndInit();

            myimage.Source = mybitmapImage;

            Picture.Source = myimage.Source;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
