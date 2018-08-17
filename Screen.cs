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
    public partial class Screen : Form
    {
        public static string 
            key, name, pass;
        private RDPViewer screen;
        public Hub hub;
        public Screen()
        {
            hub = Hub.hub;
            InitializeComponent();
        }
        public void Start()
        {
            Screen_Capture.Connect(key, name, pass);
            Screen_Capture.OnConnectionFailed += Failed;
        }

        private void View_Closing(object sender, FormClosingEventArgs e)
        {
            Screen_Capture.Disconnect();
            Screen_Capture.Dispose();
        }

        private void View_Resize(object sender, EventArgs e)
        {
            Screen_Capture.Size = new Size(Width - 16, Height - 39);
        }

        private void Failed(object sender, EventArgs e)
        {
            Close();
        }
    }
}
