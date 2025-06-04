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
        private int note_id;

        public MainWindow()
        {
            GetNotes();

            InitializeComponent();

            ChangeNoteList();
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

                note_id = i;
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void SetNotes()
        {
            StreamWriter sw = new StreamWriter("../../../notes");
            foreach (string note in notes)
            {
                sw.WriteLine(note);
            }

            sw.Close();
        }

        private void ChangeNoteList()
        {
            NoteList.Items.Clear();
            foreach (string note in notes)
            {
                NoteList.Items.Add(note);
            }
        }

        private void BtnNote_OnClick(object sender, RoutedEventArgs e)
        {
            notes[note_id] = NoteText.Text;
            note_id++;

            ChangeNoteList();
            SetNotes();
            
            NoteText.Text = "Введите текст заметки";
        }
    }
}