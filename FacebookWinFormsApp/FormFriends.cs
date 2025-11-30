using FacebookWrapper;
using FacebookWrapper.ObjectModel;
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
        private LoginResult m_LoginResult;

        public FormFriends(LoginResult loginResult)
        {
            m_LoginResult = loginResult;

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile(m_LoginResult);
            this.Close();
            profileForm.Show();
        }

        private void FormFriends_Load(object sender, EventArgs e)
        {
            fetchFriends();
        }



        private void fetchFriends()
        {
            listViewFriends.Items.Clear();

            foreach (User friend in m_LoginResult.LoggedInUser.Friends)
            {
                if (friend.Name != null)
                {
                    ListViewItem item = new ListViewItem(friend.Name);
                    listViewFriends.Items.Add(item);
                }
            }

            if (listViewFriends.Items.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

    }
}
