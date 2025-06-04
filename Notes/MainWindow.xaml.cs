using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] notes = new string[100];
        public MainWindow()
        {
            GetNotes();
            InitializeComponent();
            foreach (string note in notes)
            {
                NoteList.Items.Add(note);
            }
        }
        private void GetNotes()
        {
            try
            {
                StreamReader sr = new StreamReader("../../../notes");
                string line = sr.ReadLine();
                int i = 0;
                while (line != null)
                {
                    notes[i++] = line;
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
    }
}
