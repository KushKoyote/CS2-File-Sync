using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSync
{
    internal class Utils
    {
        public static string GetCSGOPath()
        {
            string steamPath = GetSteamPath();
            if (!string.IsNullOrEmpty(steamPath))
            {
                // Construct the path to the CS:GO directory
                string csgoPath = Path.Combine(steamPath, "steamapps", "common", "Counter-Strike Global Offensive", "game", "csgo");
                return csgoPath;
            }
            return null;
        }

        private static string GetDefaultCSGOPath()
        {
            string registryKeyPath = @"SOFTWARE\Classes\csgo\Shell\Open\Command";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKeyPath))
            {
                if (key != null)
                {
                    object o = key.GetValue(""); 
                    if (o != null)
                    {
                        string path = o.ToString();

     
                        path = path.Replace("\" +url_execute \"%1\"", "").Replace(@"\game\bin\win64\cs2.exe", "");

                        path = path.Trim('"');

                        return path;
                    }
                }
            }
            return null;
        }
        
        private static string GetSteamPath()
        {
            string registryKeyPath = @"SOFTWARE\Classes\csgo\Shell\Open\Command";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKeyPath))
            {
                if (key != null)
                {
                    object o = key.GetValue("");
                    if (o != null)
                    {
                        string path = o.ToString();


                        path = path.Replace("\" +url_execute \"%1\"", "").Replace(@"\steamapps\common\Counter-Strike Global Offensive\game\bin\win64\cs2.exe", "");

                        path = path.Trim('"');

                        return path;
                    }
                }
            }
            return null;
        }




    }
}
