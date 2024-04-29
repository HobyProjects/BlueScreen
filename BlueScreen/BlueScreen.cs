using BlueScreenCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueScreen
{
    public partial class BlueScreen : Form
    {
        private static int Presentage { get; set; }
        private static int ControllerUnlockCount { get; set; }
        private static string Action { get; set; }
        private static string TimeOut {  get; set; }  


        public BlueScreen()
        {
            InitializeComponent();
        }

        private void BlueScreen_Load(object sender, EventArgs e)
        {
            BlueScreenActions.FirstRunConfiguration();
            ControllerUnlockCount = 0;
            lblProgress.Text = "0% complete";
            Presentage = 1;

            string[] configurations = BlueScreenActions.ReadConfigurationFile();
            Action = configurations[0];
            TimeOut = configurations[1];

            this.WindowState = FormWindowState.Maximized;

            if(TimeOut == "OnStartup")
            {
                if (Action == "Shutdown")
                    BlueScreenActions.Shutdown();

                if (Action == "Restart")
                    BlueScreenActions.Restart();

                if (Action == "Sleep")
                    BlueScreenActions.Sleep();
            }
            else
            {
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblProgress.Text = $"{(Presentage * 10)}% complete";
            Presentage++;

            if(Presentage == 10)
            {
                if (Action == "Shutdown")
                    BlueScreenActions.Shutdown();

                if (Action == "Restart")
                    BlueScreenActions.Restart();

                if (Action == "Sleep")
                    BlueScreenActions.Sleep();

                Presentage = 1;
            }
        }

        private void pbCrashImage_02_Click(object sender, EventArgs e)
        {
            if(ControllerUnlockCount == 5)
            {
                timer.Stop();
                ControllerUnlockCount = 0;
                BlueScreenController controller = new BlueScreenController();
                this.Hide();

                if (controller.ShowDialog() == DialogResult.OK)
                {
                    this.Show();

                    Action = string.Empty;
                    TimeOut = string.Empty;

                    string[] configurations = BlueScreenActions.ReadConfigurationFile();
                    Action = configurations[0];
                    TimeOut = configurations[1];

                    timer.Start();
                }
            }
            else
            {
                ControllerUnlockCount++;
            }
        }
    }
}
