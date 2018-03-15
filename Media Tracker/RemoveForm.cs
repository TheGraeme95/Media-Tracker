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
    public partial class RemoveForm : Form
    {
        string AssetType = null;
        MainWindow mainForm = null;

        public RemoveForm(string type, MainWindow Form)
        {
            InitializeComponent();
            this.AssetType = type;
            this.mainForm = Form;
        }        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            if (this.RemoveIDInput.Text != "")
            {
                switch (AssetType)
                {
                    case "Film":                        
                        this.mainForm.user.RemoveFilm(Int32.Parse(RemoveIDInput.Text));
                        this.Close();
                        break;

                    case "Game":                        
                        this.mainForm.user.RemoveFilm(Int32.Parse(RemoveIDInput.Text));
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID integer.");
            }
                
        }
    }
}
