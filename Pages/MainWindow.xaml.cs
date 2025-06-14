using System.Windows;

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
            Personal.Click += Pers;
            Contact.Click += Cont;
            Adres.Click += Adr;
        }

        private void Pers(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Person());
        }

        private void Cont(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Contactor());
        }

        private void Adr(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Addr());
        }
    }
}