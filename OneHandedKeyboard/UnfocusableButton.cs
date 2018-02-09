using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHandedKeyboard
{
    public class UnfocusableButton : Button
    {
        public UnfocusableButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
