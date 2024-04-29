using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using BlueScreenCore;

namespace MicrosoftRuntimeSystem
{
    class BlueScreenExecution
    {
        public static void Main()
        {
            BlueScreenActions.FirstRunConfiguration();
            Thread StartBlueScreen = new Thread(BlueScreenExecution.WaitForCommand);
            StartBlueScreen.Priority = ThreadPriority.Lowest;
            StartBlueScreen.SetApartmentState(ApartmentState.STA);
            StartBlueScreen.Start();
        }

        private static void WaitForCommand()
        {
            string[] configurations = BlueScreenActions.ReadConfigurationFile();
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
                Process.Start("BlueScreen.exe");
            }
            else
            {
                Process.Start("BlueScreen.exe");
            }
        }
    }
}
