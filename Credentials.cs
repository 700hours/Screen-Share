using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRecieve
{
    public partial class Credentials : Form
    {
        public Credentials()
        {
            InitializeComponent();
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (Text_User.Text.Length > 0 && Text_Pass.Text.Length > 0)
            {
                Screen.name = Text_User.Text;
                Screen.pass = Text_Pass.Text;
                Close();
            }
        }

        private void Info_Closing(object sender, FormClosingEventArgs e)
        {
            Screen.name = "default";
            Screen.pass = "default";
        }
    }
}
