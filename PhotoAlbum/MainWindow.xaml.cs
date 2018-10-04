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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LessThanThreeColonCloseParentheses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel instance;
        public MainWindow()
        {
            instance = new ViewModel();
            DataContext = instance;

            // Or whatever's useful instead of Console.WriteLine
            instance.PropertyChanged += (sender, args) => Console.Write("");
            InitializeComponent();

        }

        private void Snapchats_Click(object sender, RoutedEventArgs e)
        {
            instance.AlbumIndex = 0;
        }

        private void HomecomingAndProm_Click(object sender, RoutedEventArgs e)
        {
            instance.AlbumIndex = 1;
        }

        private void SeniorYear_Click(object sender, RoutedEventArgs e)
        {
            instance.AlbumIndex = 2;
        }

        private void Disney_Click(object sender, RoutedEventArgs e)
        {
            instance.AlbumIndex = 3;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                instance.PictureIndex++;

            }catch(ArgumentOutOfRangeException)
            {
                instance.PictureIndex--;
            }
                
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            //use substring of the image's path to determine the album and use that to determine album size
            try
            {
                instance.PictureIndex--;

            }
            catch (ArgumentOutOfRangeException)
            {
                instance.PictureIndex++;
            }
        }
    }
}
