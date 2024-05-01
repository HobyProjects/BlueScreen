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
                string[] configuration = BSActions.ReadConfigurationFile();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.Exit();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string action = (rbShutdown.Checked) ? rbShutdown.Text : (rbRestart.Checked) ? rbRestart.Text : rbSleep.Text;
            BSActions.WriteConfigurationFile(action, (rbOnStartup.Checked) ? "OnStartup" : nudTime.Value.ToString(), (chRunOnStartup.Checked) ? "true" : "false");
        }

        private void chRunOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chRunOnStartup.Checked)
                BSActions.StartUpRegistery(true, "BlueScreen.exe", Application.ExecutablePath);
            else
                BSActions.StartUpRegistery(false, "BlueScreen.exe", Application.ExecutablePath);
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
    }
}
