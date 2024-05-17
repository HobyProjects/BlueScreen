using System;
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
            try
            {
                BlueScreenActions.FirstRunConfiguration();
                ControllerUnlockCount = 0;
                lblProgress.Text = "0% complete";
                Presentage = 1;

                string[] configurations = BlueScreenActions.ReadConfigurationFile();
                Action = configurations[0];
                TimeOut = configurations[1];

                this.WindowState = FormWindowState.Maximized;

                if (TimeOut == "OnStartup")
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
                    CountDownTimer.Start();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                lblProgress.Text = $"{(Presentage * 10)}% complete";
                Presentage++;

                if (Presentage == 10)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void pbCrashImage_02_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControllerUnlockCount == 5)
                {
                    CountDownTimer.Stop();
                    ControllerUnlockCount = 0;
                    BlueScreenController controller = new BlueScreenController();
                    this.Hide();

                    if (controller.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("BlueScreen is restarting. To Apply changes you made", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
                else
                {
                    ControllerUnlockCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
