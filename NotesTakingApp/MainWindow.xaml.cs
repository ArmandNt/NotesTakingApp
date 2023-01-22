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
                if(txtboxTitle.Text.Length > 15)
                {
                    MessageBox.Show("The Title Has To Be Between 1 and 15 Characters, Try Again!");
                }
                else if (String.IsNullOrEmpty(txtboxNote.Text))
                {
                    MessageBox.Show("Can't Save An Empty Note ☹️, Type Something!");
                }
                else
                {
                    MessageBox.Show("Note saved!");
                    notes.Add(new Note(txtboxTitle.Text, txtboxNote.Text));
                    listView.Items.Add(txtboxTitle.Text + " : " + txtboxNote.Text);
                    clearNoteContent();
                }
            }
        }

        /// <summary>
        /// Method to clear content from the Note tab.
        /// </summary>
        public void clearNoteContent()
        {
            txtboxTitle.Text = "";
            txtboxNote.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing to delete, Try Again!");
            }
            else
            {
                MessageBox.Show("Deleted: " + listView.SelectedItem);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing to edit, Try Again!");
            }
            else
            {
                MessageBox.Show("Selected: " + listView.SelectedItem + " to edit.");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Session terminated!");
            Environment.Exit(0);
        }
    }
}
