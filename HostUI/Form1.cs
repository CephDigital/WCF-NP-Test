using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFHostControl;
using Control = WCFHostControl.Control;

namespace HostUI
{
    public partial class Form1 : Form
    {
        Control hostControl;
        public Form1()
        {
            InitializeComponent();
            hostControl = new Control();
        }

        private void hostControlBtn_Click(object sender, EventArgs e)
        {
            if (hostControlBtn.Text == "Start")
            {
                hostControl.startHost();
                hostControlBtn.Text = "Stop";
                statusLabel.Text = "Host is running";
            } else
            {
                hostControl.stopHost();
                hostControlBtn.Text = "Start";
                statusLabel.Text = "Host is not running";
            }
        }
    }
}
