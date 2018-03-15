using MediaTrackerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Media_Tracker
{
    public partial class MainWindow : Form
    {
        public User user = new User();
        
        public MainWindow()
        {            
            InitializeComponent();
        }

        public void testMethod()
        {
            user.printFilms();          
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //testMethod();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This application is used to keep track of media such as films and games that the user has seen or played." +
                "\n\nMedia can be added to the user's collection using the Collection menu strip button. The user's collection is displayed in a table format.","About");
        }

        private void selectUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCreation userForm = new UserCreation(this);
            userForm.Show();
        }        

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmForm filmForm = new FilmForm(this);
            filmForm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm("Film", this);
            removeForm.Show();

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testMethod();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm("Game", this);
            removeForm.Show();
        }

        private void dataRefresh()
        {

        }

        

        
    }
}
