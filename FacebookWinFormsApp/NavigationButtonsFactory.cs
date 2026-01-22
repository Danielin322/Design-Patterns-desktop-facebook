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
        public enum eButtonsTypes
        {
            Profile,
            Photos,
            Statistics,
            SpecialMoments,
            home
        }
        public static List<Button> CreateButtons(eButtonsTypes i_ButtonType, FormMainFacebookWindow i_CurrentForm, User i_loggedInUser)
        {
            List<Button> buttonsList = new List<Button>();

            if (i_ButtonType == eButtonsTypes.Profile)
            {
                buttonsList.Add(creatNavigationButton("Home", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); FormToClose.Close();i_CurrentForm.Show(); }));
                buttonsList.Add(creatNavigationButton("Photos", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); openPhotos(i_CurrentForm, i_loggedInUser, FormToClose); }));
                buttonsList.Add(creatNavigationButton("Statistics", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); openUserStatistics(i_CurrentForm, i_loggedInUser, FormToClose); }));

            }
            else if (i_ButtonType == eButtonsTypes.Statistics)
            {
                buttonsList.Add(creatNavigationButton("Home", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); FormToClose.Close(); i_CurrentForm.Show(); }));
                buttonsList.Add(creatNavigationButton("Profile", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); openProfile(i_CurrentForm, i_loggedInUser, FormToClose); }));
                buttonsList.Add(creatNavigationButton("Photos", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); openPhotos(i_CurrentForm, i_loggedInUser, FormToClose); }));
            }
            else if (i_ButtonType == eButtonsTypes.Photos)
            {
                buttonsList.Add(creatNavigationButton("Home", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); FormToClose.Close(); i_CurrentForm.Show(); }));
                buttonsList.Add(creatNavigationButton("Profile", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); openProfile(i_CurrentForm, i_loggedInUser, FormToClose); }));
                buttonsList.Add(creatNavigationButton("Statistics", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); openUserStatistics(i_CurrentForm, i_loggedInUser,FormToClose); }));

            }
            else if (i_ButtonType == eButtonsTypes.SpecialMoments)
            {
                buttonsList.Add(creatNavigationButton("Home", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); FormToClose.Close(); i_CurrentForm.Show(); }));
            }
            else if(i_ButtonType == eButtonsTypes.home)
            {
                buttonsList.Add(creatNavigationButton("Profile", (s, e) => openProfile(i_CurrentForm, i_loggedInUser, null)));
                buttonsList.Add(creatNavigationButton("Photos", (s, e) => openPhotos(i_CurrentForm, i_loggedInUser, null)));
                buttonsList.Add(creatNavigationButton("Statistics", (s, e) => openUserStatistics(i_CurrentForm, i_loggedInUser, null)));
                buttonsList.Add(creatNavigationButton("Special Moments", (sender, e) => { Form FormToClose = ((Button)sender).FindForm(); openCollageOfPhotos(i_CurrentForm, i_loggedInUser, FormToClose); }));
            }

            return buttonsList;
        }

        private static Button creatNavigationButton(string i_Text, EventHandler i_ClickHandler)
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

        private static void openPhotos(FormMainFacebookWindow i_Current, User i_User, Form i_SubFormToClose)
        {
            new FormPhotos(i_User, i_Current).Show();
            i_Current.Hide();
            i_SubFormToClose.Close();
        }

        private static void openUserStatistics(FormMainFacebookWindow i_Current, User i_User, Form i_SubFormToClose)
        {
            new FormUserStatistics(i_User, i_Current).Show();
            i_Current.Hide();
            i_SubFormToClose.Close();
        }

        private static void openProfile(FormMainFacebookWindow i_Current, User i_User, Form i_SubFormToClose)
        {
            new FormProfile(i_User, i_Current).Show();
            i_Current.Hide();
            i_SubFormToClose.Close();
        }

        private static void openCollageOfPhotos(FormMainFacebookWindow i_Current, User i_User, Form i_SubFormToClose)
        {
            new FormCollageOfPhotos(i_User, i_Current).Show();
            i_Current.Hide();
            i_SubFormToClose.Close();
        }
    }
}
