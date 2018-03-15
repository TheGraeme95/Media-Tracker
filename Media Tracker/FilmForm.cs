using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTrackerLibrary;

namespace Media_Tracker
{
    public partial class FilmForm : Form
    {
        MainWindow mainForm = null;

        public FilmForm(MainWindow mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FilmTitleInput.Text != "" && FilmRatingInput.Text != "")
            {                
                Film film = new Film(FilmTitleInput.Text, FilmSeenInput.Checked, FilmDateInput.Value, FilmOwnedInput.Checked,
                Int32.Parse(FilmRatingInput.Text), FilmBlurayInput.Checked);
                mainForm.user.Add(film);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ensure Title and Rating are valid.");
            }            
        }
    }
}
