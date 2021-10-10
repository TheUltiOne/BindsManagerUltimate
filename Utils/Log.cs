using System;
using System.Collections.Generic;
using System.IO;
using BindsManagerUltimate.Utils.Enums;

namespace BindsManagerUltimate.Utils
{
    public class Log
    {
        public static string LogFolder = $"{Main.DataDirectory}/Logs";
        public static string InstallationLogs = $"{LogFolder}/install.txt";
        public static string GeneralLogs = $"{LogFolder}/main.txt";

        public static Dictionary<Exception, string> ExceptionContents = new Dictionary<Exception, string>()
        {
            
        };

        public Log()
        {
            CreateLogs();
            Info($"I'm awake! Currently using version {Main.Version}");
            Info($"I'm awake! Currently using version {Main.Version}", LogType.Installation);
        }

        public void Error(string content, LogType log = LogType.Command)
            => $"[ERROR]: {content}".Write(log);

        public void Error(Exception error, LogType log = LogType.Command)
        {
            var content = error.ToString();
            if (ExceptionContents.TryGetValue(error, out var value)) content = value;

            Error(content, log);
        }

        public void Info(string content, LogType log = LogType.Command)
            => content.Write(log);

        public void CreateLogs()
        {
            if (!Directory.Exists(Main.DataDirectory)) Directory.CreateDirectory(Main.DataDirectory);
            if (!Directory.Exists(LogFolder)) Directory.CreateDirectory(LogFolder);
            
            if (!File.Exists(InstallationLogs)) File.Create(InstallationLogs);
            if (!File.Exists(GeneralLogs)) File.Create(GeneralLogs);
        }
    }
}