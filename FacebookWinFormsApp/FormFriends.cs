using FacebookWrapper;
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
    public partial class FormFriends : Form
    {
        public FormFriends()
        {
            InitializeComponent();
        }

        private void buttonSearchName_Click(object sender, EventArgs e)
        {
            /*Clear existing selections on myListView.

            Iterate through myListView.Items.

            If an item contains the searchTextBox text (case-insensitive), select and 
            ensure visible that item.

            If no item is found, display a notification.*/
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormMainFacebookWindow HomeForm = new FormMainFacebookWindow(m_LoginResult);
            this.Close();
            HomeForm.Show();
        }
    }
}
