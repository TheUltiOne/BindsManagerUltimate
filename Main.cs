using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindsManagerUltimate.Utils;
using BindsManagerUltimate.Utils.CustomExtraForms;
using MessageBox = BindsManagerUltimate.Utils.CustomExtraForms.MessageBox;

namespace BindsManagerUltimate
{
    public partial class Main : Form
    {
        public static readonly string AppDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static readonly string DataDirectory = $"{AppDataDirectory}/BindsManagerUltimate";
        public static readonly string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static readonly string PresetDirectory = Path.Combine(Documents, "BindsManagerUltimate");
        public static readonly bool Debug = false;
        
        public static readonly Version Version = new Version(1, 0, 0);
        internal static Log Log;

        public string RealContents = string.Empty;
        
        public Main()
        {
            InitializeComponent();
            Log = new Log();

            FileUtils.AddShortcut(FileUtils.Desktop);
            FileUtils.AddShortcut(FileUtils.StartMenu);

            Directory.CreateDirectory(PresetDirectory);
            Log.Info("Added shortcuts, initialized components and created all files required.");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Log.Info("Adding all keycodes...");
            Keys.Items.AddRange(UnityKeyCodes.Keycodes.Keys.ToArray());
            Log.Info("Keycodes added");

            using (StreamReader reader = new StreamReader(Path.Combine(AppDataDirectory, "SCP Secret Laboratory", "cmdbinding.txt")))
            {
                var content = reader.ReadToEnd();
                if (content != string.Empty)
                    BindsLabel.Text = SimplifyText(content);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Log.Info("Closed by user by pressing button.");
            Environment.Exit(0);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            Log.Info("Minimized by user.");
            WindowState = FormWindowState.Minimized;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            RealContents = string.Empty;
            BindsLabel.Text = "Commands that are binded will show up here.";
            using (StreamWriter writer = new StreamWriter(Path.Combine(AppDataDirectory, "SCP Secret Laboratory", "cmdbinding.txt")))
            {
                Log.Info("Resetting cmdbindings.txt");
                writer.Write(string.Empty);
            }
            Log.Info("Reset cmdbindings.");
        }

        private void Export_Click(object sender, EventArgs e)
        {
            var result = InputBox.AskInput("What will you name this preset?");

            if (result == null)
            {
                Log.Info("Aborted Export process");
                return;
            }
            if (result == string.Empty)
            {
                MessageBox.Show("Binds Manager Error!", "You must specify a preset name!");
                Log.Error("No preset name specified");
                return;
            }

            var path = Path.Combine(PresetDirectory, $"{result}.ult");
            var file = File.Create(path);

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(RealContents);
                MessageBox.Show("Saved preset!", $"The preset was successfully saved under name '{result}'");
                Log.Info($"Preset saved @ {path}");
            }
        }
        
        private void OpenSaved_Click(object sender, EventArgs e)
        {
            Process.Start(@PresetDirectory);
        }

        public string SimplifyText(string contents = null)
        {
            if (contents == null) contents = RealContents;
            string result = string.Empty;
            
            foreach (string line in contents.Split('\n'))
            {
                if (line == string.Empty) continue;
                
                var split = line.Split(':');
                var keycode = UnityKeyCodes.Keycodes.FirstOrDefault(x => x.Value.ToString() == split[0]).Key;
                result += $"{line.Replace(split[0], keycode)}\n";
            }

            return result;
        }
        
        private void Import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = PresetDirectory;
                dialog.Filter = "Bind preset files (*.ult)|*.ult";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = dialog.FileName;
                    var file = dialog.OpenFile();

                    using (StreamReader reader = new StreamReader(file))
                    {
                        RealContents = reader.ReadToEnd();
                        BindsLabel.Text = SimplifyText();
                        var result = ButtonBox.AskResult("Would you like to set your binds to this file?", "View", "Save");
                        if (result)
                        {
                            using (StreamWriter writer = new StreamWriter(Path.Combine(AppDataDirectory, "SCP Secret Laboratory", "cmdbinding.txt"))) {
                                writer.Write(RealContents.Replace("\n", Environment.NewLine));
                            }

                            Log.Info("Saved imported binds successfully.");
                        }
                    }
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Keys.SelectedItem == null)
            {
                Log.Error("No keycode selected.");
                MessageBox.Show("Binds Manager Error!", "You don't have anything selected!");
                return;
            }

            if (!UnityKeyCodes.Keycodes.TryGetValue(Keys.SelectedItem.ToString(), out var keycode))
            {
                Log.Error("Invalid keycode selected.");
                MessageBox.Show("Binds Manager Error!", "Invalid keycode selected!");
                return;
            }

            RealContents += $"{keycode}:{(AdminCommand.Checked ? "/" : string.Empty)}{CommandBox.Text}\n";
            BindsLabel.Text = SimplifyText();

            using (StreamWriter writer = new StreamWriter(Path.Combine(AppDataDirectory, "SCP Secret Laboratory", "cmdbinding.txt"))) {
                writer.Write(RealContents.Replace("\n", Environment.NewLine));
            }
            Log.Info($"Added keybind.\n{Keys.SelectedItem}:{CommandBox.Text}");
        }
    }
}