using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

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
                BSActions.FirstRunConfiguration();
                ControllerUnlockCount = 0;
                lblProgress.Text = "0% complete";
                Presentage = 1;

                string[] configurations = BSActions.ReadConfigurationFile();
                Action = configurations[0];
                TimeOut = configurations[1];

                this.WindowState = FormWindowState.Maximized;

                if (TimeOut == "OnStartup")
                {
                    if (Action == "Shutdown")
                        BSActions.Shutdown();

                    if (Action == "Restart")
                        BSActions.Restart();

                    if (Action == "Sleep")
                        BSActions.Sleep();
                }
                else
                {
                    timer.Start();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.Exit();
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
                        BSActions.Shutdown();

                    if (Action == "Restart")
                        BSActions.Restart();

                    if (Action == "Sleep")
                        BSActions.Sleep();

                    Presentage = 1;
                }
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

        private void pbCrashImage_02_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControllerUnlockCount == 5)
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

                        string[] configurations = BSActions.ReadConfigurationFile();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
