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
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string action = (rbShutdown.Checked) ? rbShutdown.Text : (rbRestart.Checked) ? rbRestart.Text : rbSleep.Text;
            BlueScreenActions.WriteConfigurationFile(action, (rbOnStartup.Checked) ? "OnStartup" : nudTime.Value.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbAfter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAfter.Checked)
                nudTime.Enabled = true;
            else
                nudTime.Enabled = false;
        }

        private void rbOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOnStartup.Checked)
                BlueScreenActions.StartUpRegistery(true, "BlueScreen.exe", Application.ExecutablePath);
            else
                BlueScreenActions.StartUpRegistery(false, "BlueScreen.exe", Application.ExecutablePath);
        }
    }
}
