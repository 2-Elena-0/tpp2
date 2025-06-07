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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string n1 = "";
        private string n2 = "";
        private string operate = "";
        private double res = 0;
        private bool first_number = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetNumber(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if (res != 0)
            {
                res = 0;
                first_number = true;
                n1 = "";
            }

            if (first_number)
                n1 += b.Content.ToString();
            else
            {
                n2 += b.Content.ToString();
                if (operate == "/" && n2 == "0")
                {
                    MessageBox.Show("Ошибка!");
                    n2 = "";
                }
            }
        }

        private void with_animation(Button b, int p)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.To = p;
            animation.Duration = TimeSpan.FromSeconds(0.5);
            b.BeginAnimation(Button.WidthProperty, animation);
            
        }
        
        private void height_animation(Button b, int p)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.To = p;
            animation.Duration = TimeSpan.FromSeconds(0.5);
            b.BeginAnimation(Button.HeightProperty, animation);
        }

        private void decrease_animation(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            
            height_animation(b, 50);
            with_animation(b, 50);
        }
        
        private void increase_animation(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            
            height_animation(b, 60);
            with_animation(b, 60);
        }

        private void operated(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            operate = b.Content.ToString();
            first_number = false;

            if (res != 0)
            {
                n1 = Convert.ToInt32(res).ToString();
                res = 0;
            }
        }

        private void result(object sender, RoutedEventArgs e)
        {
            switch (operate)
            {
                case "+":
                    res = Convert.ToInt32(n1) + Convert.ToInt32(n2);
                    break;
                case "-":
                    res = Convert.ToInt32(n1) - Convert.ToInt32(n2);
                    break;
                case "*":
                    res = Convert.ToInt32(n1) * Convert.ToInt32(n2);
                    break;
                case "/":
                    res = Convert.ToDouble(n1) / Convert.ToDouble(n2);
                    break;
            }

            MainText.Text = res.ToString();
            n2 = "";
            operate = "";
        }

        private void Cleaned(object sender, RoutedEventArgs e)
        {
            n1 = "";
            n2 = "";
            res = 0;
            operate = "";
            first_number = true;
        }

        private void UIElement_OnLayoutUpdated(object? sender, EventArgs e)
        {
            if (res == 0 && n1 != "")
                MainText.Text = n1 + " " + operate + " " + n2;
            else
                MainText.Text = res.ToString() + " ";
        }
    }
}