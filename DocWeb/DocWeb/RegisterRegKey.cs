﻿// <auto-generated Note="Disable CodeMaid sorting." />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DocWeb
{
    /// <summary>
    /// 把软件自身放到开机启动注册表里
    /// </summary>
    static class RegisterRegKey
    {
        private const string autoStartValue = "DocWeb_ED4F3008-A7D3-4E9F-B239-E8E7EB6FCEC7";

        private const string autoStartPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private static RegistryKey rk;

        //public static RegisterRegKey Instance { get; } = new RegisterRegKey();

        //private RegisterRegKey()
        //{
        //    rk = Registry.CurrentUser.OpenSubKey(autoStartPath, true);
        //}

        //~RegisterRegKey()
        //{
        //    rk.Dispose();
        //}

        //private static void OpenRegKey()
        //{
        //    rk = Registry.CurrentUser.OpenSubKey(autoStartPath, true);
        //}

        public static void AddRegKey(string data)
        {
            using (rk = Registry.CurrentUser.OpenSubKey(autoStartPath, true))
            {
                rk.SetValue(autoStartValue, data, RegistryValueKind.String);
            }
        }

        public static bool FindRegKey()
        {
            using (rk = Registry.CurrentUser.OpenSubKey(autoStartPath, true))
            {
                string[] values = rk.GetValueNames();
                return values.Contains(autoStartValue);
            }
        }

        public static void DeleteRegKey()
        {
            using (rk = Registry.CurrentUser.OpenSubKey(autoStartPath, true))
            {
                rk.DeleteValue(autoStartValue, false);
                {
                    rk.Dispose();
                }
            }
        }
    }
}
