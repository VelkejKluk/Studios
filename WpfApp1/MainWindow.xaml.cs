using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
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

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] poleStudii = { "Bohemia Interactive", "Warhorse Studios", "SCS Software", "2K Czech", "Madfinger Games" };
            Studia.ItemsSource = poleStudii; 
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image.Source = new BitmapImage(new Uri($@"Images/{Studia.SelectedItem}.png", UriKind.Relative));
        }
    }
}
