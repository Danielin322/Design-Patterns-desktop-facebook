using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FacebookWindow : Form
    {
        public FacebookWindow()
        {
            InitializeComponent();
        }

        

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            // move to profile form (dont forget to give the user option to go back)
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            // move to friends form (dont forget to give the user option to go back)
        }

        

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //log out
        }

        private void FacebookWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonUserPhotos_Click(object sender, EventArgs e)
        {
            // go to photos form ( dont forget to give the user option to go back)
        }

        
    }
}
