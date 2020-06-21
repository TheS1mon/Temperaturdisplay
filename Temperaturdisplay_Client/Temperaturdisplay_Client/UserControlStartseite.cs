using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturdisplay_Client
{
    public partial class UserControlStartseite : UserControl
    {
        public UserControlStartseite()
        {
            InitializeComponent();
        }

        public void enableControls()
        {
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
        }

        public void disableControls()
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
        }
    }
}
