using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class BoldCommand : ICommand
    {
        private RichTextBox m_RichTextBox;
        private Font m_PreviousFont;
        private int m_SelectionStart;
        private int m_SelectionLength;

        public BoldCommand(RichTextBox i_RichTextBox)
        {
            m_RichTextBox = i_RichTextBox;
            m_SelectionStart = i_RichTextBox.SelectionStart;
            m_SelectionLength = i_RichTextBox.SelectionLength;
            m_PreviousFont = i_RichTextBox.SelectionFont;
        }

        public void Execute()
        {
            m_RichTextBox.Select(m_SelectionStart, m_SelectionLength);

            if (m_RichTextBox.SelectionFont != null)
            {
                FontStyle style = m_RichTextBox.SelectionFont.Bold ? FontStyle.Regular : FontStyle.Bold;
                m_RichTextBox.SelectionFont = new Font(m_RichTextBox.SelectionFont, style);
            }
        }

        public void Undo()
        {
            m_RichTextBox.Select(m_SelectionStart, m_SelectionLength);
            m_RichTextBox.SelectionFont = m_PreviousFont;
        }
    }
}
