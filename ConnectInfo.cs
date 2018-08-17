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
    public partial class ConnectInfo : Form
    {
        public ConnectInfo()
        {
            InitializeComponent();
        }

        private void Button_CreateKey_Click(object sender, EventArgs e)
        {
            if (Text_Auth.Text.Length > 0 && Text_Group.Text.Length > 0 && Text_Password.Text.Length > 0)
            {
                Hub.auth = Text_Auth.Text;
                Hub.group = Text_Group.Text;
                Hub.pass = Text_Password.Text;

                Close();
            }
            else
                Label_Status.Text = "Invalid";
        }

        private void Info_Closing(object sender, FormClosingEventArgs e)
        {
            Hub.auth = "default";
            Hub.group = "default";
            Hub.pass = "default";
        }
    }
}
