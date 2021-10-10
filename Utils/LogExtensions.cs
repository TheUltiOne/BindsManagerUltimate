using System;
using System.Collections.Generic;
using System.IO;
using BindsManagerUltimate.Utils.Enums;

namespace BindsManagerUltimate.Utils
{
    public static class LogExtensions
    {
        public static void Write(this string content, LogType log)
        {
            using (StreamWriter writer = new StreamWriter(log.GetLog(), append: true))
            {
                writer.WriteLine($"[{DateTime.Now}] - {content}");
            }
        }

        public static string GetLog(this LogType log)
        {
            switch (log)
            {
                default:
                    return Log.GeneralLogs;
                case LogType.Command:
                    return Log.GeneralLogs;
                case LogType.Installation:
                    return Log.InstallationLogs;
            }
        }

        public static string Debug(this string content)
        {
            if (Main.Debug) return content;
            return string.Empty;
        }
    }
}