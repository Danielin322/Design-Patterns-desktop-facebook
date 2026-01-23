using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class NavigationButtonsFactory
    {
        public enum eButtonTypes
        {
            Profile,
            Photos,
            Statistics,
            SpecialMoments,
            home
        }
        public static List<Button> CreateButtons(eButtonTypes i_ButtonType, Form i_SpecificForm, FormMainFacebookWindow i_MainForm, User i_LoggedInUser)
        {
            List<Button> buttonsList = new List<Button>();

            if (i_ButtonType == eButtonTypes.Profile)
            {
                buttonsList.Add(createNavigationButton("Home", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); formToClose.Close(); i_MainForm.Show(); }));
                buttonsList.Add(createNavigationButton("Photos", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); openPhotos(i_MainForm, i_LoggedInUser, formToClose); }));
                buttonsList.Add(createNavigationButton("Statistics", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); openUserStatistics(i_MainForm, i_LoggedInUser, formToClose); }));
            }
            else if (i_ButtonType == eButtonTypes.Statistics)
            {
                buttonsList.Add(createNavigationButton("Home", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); formToClose.Close(); i_MainForm.Show(); }));
                buttonsList.Add(createNavigationButton("Profile", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); openProfile(i_MainForm, i_LoggedInUser, formToClose); }));
                buttonsList.Add(createNavigationButton("Photos", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); openPhotos(i_MainForm, i_LoggedInUser, formToClose); }));
            }
            else if (i_ButtonType == eButtonTypes.Photos)
            {
                buttonsList.Add(createNavigationButton("Home", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); formToClose.Close(); i_MainForm.Show(); }));
                buttonsList.Add(createNavigationButton("Profile", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); openProfile(i_MainForm, i_LoggedInUser, formToClose); }));
                buttonsList.Add(createNavigationButton("Statistics", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); openUserStatistics(i_MainForm, i_LoggedInUser, formToClose); }));

            }
            else if (i_ButtonType == eButtonTypes.SpecialMoments)
            {
                buttonsList.Add(createNavigationButton("Home", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); formToClose.Close(); i_MainForm.Show(); }));
            }
            else if (i_ButtonType == eButtonTypes.home)
            {
                buttonsList.Add(createNavigationButton("Profile", (s, e) => openProfile(i_MainForm, i_LoggedInUser, null)));
                buttonsList.Add(createNavigationButton("Photos", (s, e) => openPhotos(i_MainForm, i_LoggedInUser, null)));
                buttonsList.Add(createNavigationButton("Statistics", (s, e) => openUserStatistics(i_MainForm, i_LoggedInUser, null)));
                buttonsList.Add(createNavigationButton("Special Moments", (sender, e) => { Form formToClose = ((Button)sender).FindForm(); openCollageOfPhotos( i_MainForm,i_LoggedInUser, null); }));
            }

            for (int i = 0; i < buttonsList.Count; i++)
            {
                Button btn = buttonsList[i];

                // Calculate X and Y for the bottom right corner
                int x = i_SpecificForm.ClientSize.Width - (btn.Width * (i + 1));
                int y = i_SpecificForm.ClientSize.Height - btn.Height;

                btn.Location = new System.Drawing.Point(x, y);
                btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            }

            return buttonsList;
        }

        private static Button createNavigationButton(string i_Text, EventHandler i_ClickHandler)
        {
            Button newButton = new Button()
            {
                Text = i_Text,
                Size = new System.Drawing.Size(108, 53),
                BackColor = System.Drawing.Color.Gold
            };

            newButton.Click += i_ClickHandler;
            return newButton;
        }

        private static void openPhotos(FormMainFacebookWindow i_MainForm, User i_LoggedInUser, Form i_SubFormToClose)
        {
            new FormPhotos(i_LoggedInUser, i_MainForm).Show();
            i_MainForm.Hide();
            if (i_SubFormToClose != null)
            {
                i_SubFormToClose.Close();
            }
        }

        private static void openUserStatistics(FormMainFacebookWindow i_MainForm, User i_LoggedInUser, Form i_SubFormToClose)
        {
            new FormUserStatistics(i_LoggedInUser, i_MainForm).Show();
            i_MainForm.Hide();
            if (i_SubFormToClose != null)
            {
                i_SubFormToClose.Close();
            }
        }

        private static void openProfile(FormMainFacebookWindow i_MainForm, User i_LoggedInUser, Form i_SubFormToClose)
        {
            new FormProfile(i_LoggedInUser, i_MainForm).Show();
            i_MainForm.Hide();
            if (i_SubFormToClose != null)
            {
                i_SubFormToClose.Close();
            }
        }

        private static void openCollageOfPhotos(FormMainFacebookWindow i_MainForm, User i_LoggedInUser, Form i_SubFormToClose)
        {
            new FormCollageOfPhotos(i_LoggedInUser, i_MainForm).Show();
            i_MainForm.Hide();
            if (i_SubFormToClose != null)
            {
                i_SubFormToClose.Close();
            }
        }
    }
}
