using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ClearAllCommand : ICommand
    {
        private RichTextBox m_RichTextBox;
        private string m_PreviousRtf;

        public ClearAllCommand(RichTextBox i_RichTextBox)
        {
            m_RichTextBox = i_RichTextBox;
            m_PreviousRtf = i_RichTextBox.Rtf;
        }

        public void Execute()
        {
            m_RichTextBox.Clear();
        }

        public void Undo()
        {
            m_RichTextBox.Rtf = m_PreviousRtf;
        }
    }
}
