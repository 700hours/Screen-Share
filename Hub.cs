using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RDPCOMAPILib;

namespace ScreenRecieve
{
    public partial class Hub : Form
    {
        public static string
            auth, group, pass;
        public static RDPSession session;
        public static Hub hub;
        public Hub()
        {
            hub = this;
            InitializeComponent();
        }

        private void Button_Begin_Click(object sender, EventArgs e)
        {
            if (Button_Begin.Text == "Initiate")
            {
                session = new RDPSession();

                session.OnAttendeeConnected += Incoming;
                session.Open();

                var info = new ConnectInfo();
                info.ShowDialog();
                
                IRDPSRAPIInvitation invitation = session.Invitations.CreateInvitation(auth, group, pass, 10);
                Text_Key.Text = invitation.ConnectionString;

                Buttons(Setting.Basic, true);
            }
            else if (Button_Begin.Text == "Begin")
            {
                var info = new Credentials();
                info.ShowDialog();

                Screen.key = Text_Key.Text;
                var screen = new Screen();
                screen.Start();
                screen.ShowDialog();
                
                Buttons(Setting.Basic, true);
            }
        }
        private void Button_Quit_Click(object sender, EventArgs e)
        {
            session.Close();
            
            Buttons(Setting.Basic, false);
        }

        private void Opt_ShareCheck(object sender, EventArgs e)
        {
            Buttons(Setting.Share, false);
        }
        private void Opt_ConnectCheck(object sender, EventArgs e)
        {
            Buttons(Setting.Connect, false);
        }

        private void Buttons(Setting type, bool start)
        {
            switch (type)
            {
                case Setting.Basic:
                    if (start)
                    {
                        Button_Begin.Enabled = false;
                        Button_Quit.Enabled = true;
                        Opt_Share.Enabled = false;
                        Opt_Connect.Enabled = false;
                    }
                    else
                    {
                        Button_Begin.Enabled = true;
                        Button_Quit.Enabled = false;
                        Opt_Share.Enabled = true;
                        Opt_Connect.Enabled = true;
                        Text_Key.Clear();
                    }
                    break;
                case Setting.Share:
                    Button_Begin.Text = "Initiate";
                    Text_Key.ReadOnly = true;
                    Text_Key.Clear();
                    break;
                case Setting.Connect:
                    Button_Begin.Text = "Begin";
                    Text_Key.ReadOnly = false;
                    Text_Key.Clear();
                    Text_Key.Text = "Input-key";
                    break;
            }
        }

        public void Incoming(object Guest)
        {
            IRDPSRAPIAttendee viewer = (IRDPSRAPIAttendee)Guest;
            viewer.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_VIEW;
        }
    }
    enum Setting
    {
        Basic,
        Share,
        Connect
    }
}
