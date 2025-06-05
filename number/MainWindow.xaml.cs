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

namespace number
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int min_number = 1;
        private int max_number = 100;

        private int number;
        public int attempts = 0;
        public int min_now_number;
        public int max_now_number;

        public MainWindow()
        {
            InitializeComponent();
            SetNumber();
            SetLabel();
        }
        
        public void SetLabel()
        {
            L1.Content = "Угадайте число от " + min_now_number.ToString() + " до " + max_now_number.ToString();
            LabelAtt.Content = "Количество попыток: " + attempts.ToString();
        }

        private void SetNumber()
        {
            Random rm = new Random();
            number = rm.Next(min_number, max_number);
            
            min_now_number = min_number;
            max_now_number = max_number;
            
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            attempts += 1;
            int n = Convert.ToInt32(TextNumber.Text);

            if (n == number)
                LabelRes.Content = "Вы угадали!";
            else if (n > number) 
                LabelRes.Content = "число слишком большое!";
            else
                LabelRes.Content = "число слишком маленькое!";

            if (attempts % 10 == 0)
            {
                min_now_number = Math.Max(min_number, number - 10 * (int) (9 - attempts / 10));
                max_now_number = Math.Min(max_number, number + 10 * (int) (9 - attempts / 10));
            }
            
            SetLabel();
        }
    }
}