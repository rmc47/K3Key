using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace K3Key
{
    internal static class Settings
    {
        public static string Get(string key, string defaultValue)
        {
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\M0VFC\K3Key", false))
            {
                if (regKey == null)
                    return defaultValue;
                return (string)regKey.GetValue(key, defaultValue);
            }
        }

        public static void Set(string key, string val)
        {
            using (RegistryKey regKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\M0VFC\K3Key"))
            {
                regKey.SetValue(key, val);
            }
        }
    }
}
