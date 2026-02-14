using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacadeMainWindow
    {
        private User m_LoggedInUser;
        private Stack<ICommand> m_UndoStack = new Stack<ICommand>();
        private Stack<ICommand> m_RedoStack = new Stack<ICommand>();

        public FacadeMainWindow(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public string GetProfilePictureURL()
        {
            string url = null;

            if (m_LoggedInUser != null)
            {
                url = m_LoggedInUser.PictureNormalURL;
            }

            return url;
        }

        public string GetUserName()
        {
            string name = "";

            if (m_LoggedInUser != null)
            {
                name = m_LoggedInUser.Name;
            }

            return name;
        }

        public List<Page> GetLikedPages()
        {
            List<Page> pageList = new List<Page>();

            if (m_LoggedInUser != null)
            {
                if (m_LoggedInUser.LikedPages != null)
                {
                    IAggregate<Page> pageAggregate = new FacebookObjectCollection<Page>(m_LoggedInUser.LikedPages);
                    IIterator<Page> pageIterator = pageAggregate.CreateIterator();
                    while (pageIterator.HasNext())
                    {
                        Page page = pageIterator.Next() as Page;
                        pageList.Add(page);
                    }
                }
            }

            return pageList;
        }

        public void PublishPost(string i_TextToPost)
        {
            // Posting a new status (facebook doesnt allow posting from here)
        }

        public void ExecuteCommand(ICommand i_Command)
        {
            i_Command.Execute();
            m_UndoStack.Push(i_Command);
            m_RedoStack.Clear();
        }

        public void Undo()
        {
            if (m_UndoStack.Count > 0)
            {
                ICommand command = m_UndoStack.Pop();

                command.Undo();
                m_RedoStack.Push(command);
            }
        }

        public void Redo()
        {
            if (m_RedoStack.Count > 0)
            {
                ICommand command = m_RedoStack.Pop();

                command.Execute();
                m_UndoStack.Push(command);
            }
        }
    }
}