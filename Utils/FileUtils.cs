using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Microsoft.Win32;

namespace BindsManagerUltimate.Utils
{
    public static class FileUtils
    {
        public static string StartMenu =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs");

        public static string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static void AddShortcut(string path)
        {
            string shortcutLocation = Path.Combine(path, "BindsManagerUltimate.lnk");

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut) shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "A shortcut to quickly use Binds Manager Ultimate";
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.Save();
        }
    }
}