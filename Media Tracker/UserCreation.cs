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
    public partial class UserCreation : Form
    {
        MainWindow mainForm = null;

        public UserCreation(MainWindow mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }        

        private void Okaybutton_Click(object sender, EventArgs e)
        {
            string UserInput = UserCreationInputBox.Text;

            if (UserInput != "")
            {
                this.mainForm.user.Name = UserInput;
                this.Close();
                this.mainForm.testMethod();
            }
            else
            {
                MessageBox.Show("Please enter a valid username");
            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
