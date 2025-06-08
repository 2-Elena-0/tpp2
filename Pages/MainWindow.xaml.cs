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

namespace Pages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoToPersonalData(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Personal_Data());
        }

        private void GoToContactData(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Contact_Data());
        }

        private void GoToAdressData(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Adress());
        }
    }
}