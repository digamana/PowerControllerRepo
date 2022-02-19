using Microsoft.Win32;
using System;
namespace PowerController.Main
{
    class addToRegForRun
    {
        private static RegistryKey getRunKey()
        {
            RegistryKey rk1 = Registry.CurrentUser;
            RegistryKey rk2 = rk1.CreateSubKey("SOFTWARE");
            RegistryKey rk3 = rk2.CreateSubKey("Microsoft");
            RegistryKey rk4 = rk3.CreateSubKey("Windows");
            RegistryKey rk5 = rk4.CreateSubKey("CurrentVersion");
            RegistryKey rk6 = rk5.CreateSubKey("Run");
            return rk6;
        }
        public bool chk(string key, System.Windows.Forms.TextBox txLog)
        {
            bool result = true;
            //2. 註冊到registry file中讓開機自動啟動
            //using Microsoft.Win32;
            RegistryKey rk6 = getRunKey();
            object ret = rk6.GetValue(key, "找不到");
            txLog.Text += key + "  : " + ret.ToString() + Environment.NewLine;
            rk6.Close();
            if (ret.ToString() == "找不到")
                result = false;
            return result;
        }
        public bool chk(string key)
        {
            bool result = true;
            //2. 註冊到registry file中讓開機自動啟動
            //using Microsoft.Win32;
            RegistryKey rk6 = getRunKey();
            object ret = rk6.GetValue(key, "找不到");
            //txLog.Text += key + "  : " + ret.ToString() + Environment.NewLine;
            rk6.Close();
            if (ret.ToString() == "找不到")
                result = false;
            return result;
        }


        public void add(string key, string src_file)
        {
            //2. 註冊到registry file中讓開機自動啟動
            RegistryKey rk6 = getRunKey();
            rk6.SetValue(key, @src_file);
            rk6.Close();

        }
        public void remove(string key)
        {
            //2. 註冊到registry file中讓開機自動啟動
            //using Microsoft.Win32;
            RegistryKey rk6 = getRunKey();
            object ret = rk6.GetValue(key, "找不到");
            if (ret.ToString() != "找不到")
                rk6.DeleteValue(key);
            rk6.Close();
        }
    }
}
