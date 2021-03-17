using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaos_Mover
{
    public partial class frmMain : Form
    {
        private string stashPath = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var configKeys = new List<string>
            {
                "GTA5_Install_Path"
            };

            foreach (var myKey in configKeys) {
                switch (myKey) {
                    case "GTA5_Install_Path":
                        txtInstallPath.Text = GetConfigSetting(myKey);
                        fdGTA.SelectedPath = txtInstallPath.Text;
                        break;
                }
            }

            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            stashPath = new FileInfo(location.AbsolutePath).Directory.FullName + "\\Stashed";

            if (!Directory.Exists(stashPath))
            {
                Directory.CreateDirectory(stashPath);
            }

            UpdateStatus();
        }

        private string GetConfigSetting(string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            var value = settings[key]?.Value;

            if (string.IsNullOrEmpty(value))
            {
                value = "";
                settings.Add(key, value);
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            return value;
        }

        private void SaveConfigSetting(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;

            settings[key].Value = value;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }


        private void sdGTA_FileOk(object sender, CancelEventArgs e)
        {
            txtInstallPath.Text = sdGTA.FileName;
            SaveConfigSetting("GTA5_Install_Path", sdGTA.FileName);
        }

        private void btnPickPath_Click(object sender, EventArgs e)
        {
            var currentValue = txtInstallPath.Text.Trim();

            if (Directory.Exists(currentValue))
            {
                fdGTA.SelectedPath = currentValue;
            }

            PickInstallPath();
        }

        private bool PickInstallPath()
        {
            DialogResult result = fdGTA.ShowDialog();
            var selectedPath = fdGTA.SelectedPath;

            if (result == DialogResult.OK)
            {
                selectedPath = fdGTA.SelectedPath;
                txtInstallPath.Text = selectedPath;
                SaveConfigSetting("GTA5_Install_Path", selectedPath);
            }

            return HaveValidPath();
        }

        private bool HaveValidPath()
        {
            return Directory.Exists(fdGTA.SelectedPath);
        }


        private List<string> GetAllModFiles(string fromPath)
        {
            var asiFiles = Directory.GetFiles(fromPath, "*.asi");
            var dllFiles = Directory.GetFiles(fromPath, "*.dll");
            var modPath = $"{fromPath}\\chaosmod";
            var chaosMod = Directory.Exists(modPath);
            var modFiles = new List<string>();

            TreeView saveTree = tvStorage;

            if (fromPath == fdGTA.SelectedPath)
            {
                saveTree = tvGTA;
            }

            saveTree.Nodes.Clear();

            if (asiFiles.Length + dllFiles.Length > 0 && chaosMod)
            {
                var modDlls = new List<string>()
                {
                    "dinput8.dll",
                    "ScriptHookV.dll"
                };

                modFiles.Add(modPath);
                modFiles.AddRange(asiFiles.ToList<string>());

                foreach (string item in dllFiles)
                {
                    var file = item.Replace(fromPath + "\\", "");

                    if (modDlls.Contains(file))
                    {
                        modFiles.Add(item);
                    }
                }

                foreach (string item in modFiles)
                {
                    saveTree.Nodes.Add(item.Replace(fromPath + "\\", ""));
                }
            };

            return modFiles;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            var modFiles = GetAllModFiles(stashPath);
            MoveFiles(stashPath, fdGTA.SelectedPath, modFiles);
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            var modFiles = GetAllModFiles(fdGTA.SelectedPath);
            MoveFiles(fdGTA.SelectedPath, stashPath, modFiles);
        }

        private void MoveFiles(string fromPath, string toPath, List<string> modFiles)
        {
            foreach (string item in modFiles)
            {
                var file = item.Replace($"{fromPath}\\", "");
                var test = $"{toPath}\\{file}";
                var oops = "";
                Directory.Move(item, $"{toPath}\\{file}");
            }

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            var installed = GetAllModFiles(fdGTA.SelectedPath);
            var stashed = GetAllModFiles(stashPath);
            11
            if (installed.Count > 0 )
            {
                lblStatus.Text = "Installed";
                lblStatus.ForeColor = Color.FromArgb(22, 148, 56);
            }
            else
            {
                lblStatus.Text = "Uninstalled";
                lblStatus.ForeColor = Color.FromArgb(176, 25, 40);
            }
        }
        
    }
}
