using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagerWinForm.Helpers
{
    public static class FormTools
    {
        public static void ClearAllText(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();
                if (c is RichTextBox)
                    ((RichTextBox)c).Clear();
            }
        }
    }
}
