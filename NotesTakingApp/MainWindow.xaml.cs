using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NotesTakingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Note> notes = new ObservableCollection<Note>();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearNoteContent();
        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtboxTitle.Text))
            {
                MessageBox.Show("Enter a Title!");
            }
            else
            {
                if (String.IsNullOrEmpty(txtboxNote.Text))
                {
                    MessageBox.Show("Can't Save An Empty Note ☹️, Type Something!");
                }
                else
                {
                    notes.Add(new Note(txtboxTitle.Text, txtboxNote.Text));
                    listView.Items.Add(txtboxTitle.Text + " : " + txtboxNote.Text);
                    clearNoteContent();
                }
            }
        }

        public void clearNoteContent()
        {
            txtboxTitle.Text = "";
            txtboxNote.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //listView.Items.Remove(listView.SelectedItems);
            //listView.Items.Refresh();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            //Note noteSelected = listView.SelectedItems as Note;
        }
    }
}
