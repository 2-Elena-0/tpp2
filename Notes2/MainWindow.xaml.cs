using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using Microsoft.Win32;

namespace Notes2
{
    public partial class MainWindow : Window
    {
        private string fileName;

        public MainWindow()
        {
            InitializeComponent();
            
            App.LanguageChanged += ChangeLanguage;

            CultureInfo currLang = App.Language;

            Languages.Items.Clear();
            foreach (var l in App.Languages)
            {
                MenuItem ml = new MenuItem();
                ml.Header = l.DisplayName;
                ml.Tag = l;
                ml.IsChecked = l.Equals(currLang);
                ml.Click += ChangeLanguageClick;
                Languages.Items.Add(ml);
            }
        }
        
        private void ChangeLanguage(object? sender, EventArgs e)
        {
            try
            {
                CultureInfo cl = App.Language;

                foreach (MenuItem i in Languages.Items)
                {
                    CultureInfo ci = i.Tag as CultureInfo;
                    i.IsChecked = ci != null && ci.Equals(cl);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ChangeLanguageClick(object sender, RoutedEventArgs e)
        {
            try
            {
                MenuItem mi = sender as MenuItem;
                if (mi != null)
                {
                    CultureInfo lang = mi.Tag as CultureInfo;
                    if (lang != null)
                        App.Language = lang;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void OpenFile(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == true)
                {
                    fileName = ofd.FileName;
                    StreamReader sr = new StreamReader(fileName);
                    fileText.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void Savefile(object sender, RoutedEventArgs e)
        {
            try
            {
                if (fileName != null)
                {
                    StreamWriter sw = new StreamWriter(fileName);
                    sw.Write(fileText.Text);
                    sw.Close();
                }
                else
                {
                    SavefileAs(sender, e);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void SavefileAs(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog ofd = new SaveFileDialog();
                if (ofd.ShowDialog() == true)
                {
                    StreamWriter sw = new StreamWriter(ofd.FileName);
                    sw.Write(fileText.Text);
                    sw.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
                                 DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }
    }

    public class WindowCommands
    {
        static WindowCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E"));

            InputGestureCollection inputsOpen = new InputGestureCollection();
            inputsOpen.Add(new KeyGesture(Key.O, ModifierKeys.Control, "Ctrl+O"));

            InputGestureCollection inputsSave = new InputGestureCollection();
            inputsSave.Add(new KeyGesture(Key.N, ModifierKeys.Control, "Ctrl+N"));

            InputGestureCollection inputsSaveAs = new InputGestureCollection();
            inputsSaveAs.Add(new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S"));

            Exit = new RoutedCommand("Exit", typeof(MainWindow), inputs);
            Open = new RoutedCommand("Open", typeof(MainWindow), inputsOpen);
            Save = new RoutedCommand("Save", typeof(MainWindow), inputsSave);
            SaveAs = new RoutedCommand("SaveAs", typeof(MainWindow), inputsSaveAs);
        }

        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Open { get; set; }
        public static RoutedCommand SaveAs { get; set; }
        public static RoutedCommand Save { get; set; }
    }
}