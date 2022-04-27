using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1_VladyslavNaumenko51447
{
    public class vnAktywacja
    {
        public static void vnAktywacjaControlki(Control vnControl)
        {
                vnControl.Enabled = true;
                vnControl.BackColor = SystemColors.Highlight;
        }
        public static void vnDeaktywizacjaControlki(Control vnControl)
        {
                vnControl.Enabled = false;
                vnControl.BackColor = SystemColors.ControlDark;
        }
        public static void vnAktywacjaControlki(Control[] vnControls)
        {
            for (int i = 0; i < vnControls.Length; i++)
            {
                vnControls[i].Enabled = true;
                vnControls[i].BackColor = SystemColors.Highlight;
            }
        }
        public static void vnDeaktywizacjaControlki(Control[] vnControls)
        {
            for (int i = 0; i < vnControls.Length; i++)
            {
                vnControls[i].Enabled = false;
                vnControls[i].BackColor = SystemColors.ControlDark;
            }
        }
    }
}
