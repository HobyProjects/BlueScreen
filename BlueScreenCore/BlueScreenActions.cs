using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace BlueScreenCore
{
    public class BlueScreenActions
    {
        public static void FirstRunConfiguration()
        {
            if (!File.Exists("bluescreen.txt"))
            {
                using (StreamWriter sw = new StreamWriter("bluescreen.txt", true))
                {
                    sw.WriteLine($"Action:Sleep");
                    sw.WriteLine($"TakeAction:1");
                    sw.WriteLine($"RunOnStartup:false");
                    sw.Close();
                }
            }
        }

        public static string[] ReadConfigurationFile()
        {
            string[] file_content = File.ReadAllLines("bluescreen.txt");
            string[] config = new string[3];
            for(int i = 0; i < 3; i++)
            {
                string[] config_value = file_content[i].Split(':');
                if (config_value[1] != string.Empty)
                {
                    config[i] = config_value[1];
                }
            }

            return config;
        }

        public static void WriteConfigurationFile(string action, string take_action, string run_on_startup)
        {
            if (!File.Exists("bluescreen.txt"))
            {
                using (StreamWriter sw = new StreamWriter("bluescreen.txt", true))
                {
                    sw.WriteLine($"Action:{action}");
                    sw.WriteLine($"TakeAction:{take_action}");
                    sw.WriteLine($"RunOnStartup:{run_on_startup}");
                    sw.Close();
                }
            }
            else
            {
                File.Delete("bluescreen.txt");
                WriteConfigurationFile(action, take_action, run_on_startup);
            }
        }

        public static void StartUpRegistery(bool register, string application_name, string path)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (register)
                rk.SetValue(application_name, path);
            else
                rk.DeleteValue(application_name, false);
        }


        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);


        public static void Sleep()
        {
            Thread.Sleep(5000);
            SetSuspendState(false, true, true);
        }

        public static void Shutdown()
        {
            Thread.Sleep(5000);
            Process.Start("shutdown", "/s /t 0");
        }

        public static void Restart()
        {
            Thread.Sleep(5000);
            Process.Start("shutdown", "/r /t 0");
        }
    }
}
