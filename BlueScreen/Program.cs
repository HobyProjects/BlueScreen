using BlueScreenCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BlueScreen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread StartBlueScreen = new Thread(WaitForCommand);
            StartBlueScreen.Priority = ThreadPriority.Lowest;
            StartBlueScreen.SetApartmentState(ApartmentState.STA);
            StartBlueScreen.Start();
        }

        private static void WaitForCommand()
        {
            string[] configurations = BSActions.ReadConfigurationFile();
            while (true)
            {
                if ((Keyboard.GetKeyStates(Key.LeftCtrl) & KeyStates.Down) > 0 && (Keyboard.GetKeyStates(Key.LeftAlt) & KeyStates.Down) > 0 && (Keyboard.GetKeyStates(Key.H) & KeyStates.Down) > 0)
                {
                    break;
                }
            }

            if (configurations[1] != "OnStartup")
            {
                Thread.Sleep((int.Parse(configurations[1]) * 60) * 1000);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new BlueScreen());
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new BlueScreen());
            }
        }
    }
}
