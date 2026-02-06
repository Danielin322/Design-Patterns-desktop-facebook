using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ColorChangeCommand : ICommand
    {
        private RichTextBox m_RichTextBox;
        private Color m_PreviousColor;
        private Color m_NewColor;
        private int m_SelectionStart;
        private int m_SelectionLength;

        public ColorChangeCommand(RichTextBox i_RichTextBox, Color i_NewColor)
        {
            m_RichTextBox = i_RichTextBox;
            m_NewColor = i_NewColor;
            m_SelectionStart = i_RichTextBox.SelectionStart;
            m_SelectionLength = i_RichTextBox.SelectionLength;
            m_PreviousColor = i_RichTextBox.SelectionColor;
        }

        public void Execute()
        {
            m_RichTextBox.Select(m_SelectionStart, m_SelectionLength);
            m_RichTextBox.SelectionColor = m_NewColor;
        }

        public void Undo()
        {
            m_RichTextBox.Select(m_SelectionStart, m_SelectionLength);
            m_RichTextBox.SelectionColor = m_PreviousColor;
        }
    }
}
