using System;
using System.IO;
using System.Text;
using ColossalFramework.UI;

namespace CompCheck
{
    public class CompatibilityHelper
    {
        private static string steamAppsFolder;

        // Mod installation status variables
        public static bool IsLutCreatorInstalled = IsModInstalled("2979442499");
        public static bool IsEyecandyXInstalled = IsModInstalled("2980339529");
        public static bool IsPlayItInstalled = IsModInstalled("2741726428");
        public static bool IsRelightInstalled = IsModInstalled("1209581656");
        public static bool IsRenderItInstalled = IsModInstalled("1794015399");
        public static bool IsSpeedSliderV2Installed = IsModInstalled("406354745");
        public static bool IsThemeMixer2Installed = IsModInstalled("1899640536");
        public static bool IsThemeMixer2_5Installed = IsModInstalled("2954236385");
        public static bool IsUltimateEyecandyInstalled = IsModInstalled("672248733");
        public static bool IsUnifiedUIInstalled = IsModInstalled("2966990700");

        static CompatibilityHelper()
        {
            try
            {
                steamAppsFolder = GetSteamAppsFolder();
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., log, display an error message, etc.)
                Console.WriteLine($"Failed to retrieve SteamApps folder: {ex.Message}");
                steamAppsFolder = string.Empty; // Set steamAppsFolder to an empty string to indicate failure
            }
        }

        private static string GetSteamAppsFolder()
        {
            string programFilesFolder = GetProgramFilesFolder();

            // Check if running on macOS
            if (Environment.OSVersion.Platform == PlatformID.MacOSX || Environment.OSVersion.Platform == PlatformID.Unix)
            {
                string homeFolder = GetHomeFolder();
                return PathCombine(homeFolder, "Library/Application Support/Steam/steamapps");
            }
            // Check if running on Windows
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                return PathCombine(programFilesFolder, "Steam", "steamapps");
            }
            else
            {
                throw new Exception("Unsupported operating system");
            }
        }

        private static string GetHomeFolder()
        {
            string homePath = Environment.GetEnvironmentVariable("HOME");
            if (!string.IsNullOrEmpty(homePath))
            {
                return homePath;
            }

            string userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
            if (!string.IsNullOrEmpty(userProfile))
            {
                return userProfile;
            }

            throw new Exception("Unable to determine user home folder");
        }

        private static string GetProgramFilesFolder()
        {
            string programFilesPath = Environment.GetEnvironmentVariable("PROGRAMFILES(X86)");
            if (!string.IsNullOrEmpty(programFilesPath))
            {
                return programFilesPath;
            }

            programFilesPath = Environment.GetEnvironmentVariable("PROGRAMFILES");
            if (!string.IsNullOrEmpty(programFilesPath))
            {
                return programFilesPath;
            }

            throw new Exception("Unable to determine Program Files folder");
        }

        private static string PathCombine(params string[] paths)
        {
            string combinedPath = paths[0];
            for (int i = 1; i < paths.Length; i++)
            {
                combinedPath = Path.Combine(combinedPath, paths[i]);
            }

            return combinedPath;
        }

        private static bool IsModInstalled(string steamId)
        {
            if (string.IsNullOrEmpty(steamAppsFolder))
            {
                throw new Exception("SteamApps folder is not available");
            }

            string modFolderPath = PathCombine(steamAppsFolder, "workshop", "content", "255710", steamId);

            return Directory.Exists(modFolderPath);
        }

        public static void ShowInstalledVisualMods()
        {
            ExceptionPanel panel = UIView.library.ShowModal<ExceptionPanel>("ExceptionPanel");

            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine("Installed Visual Mods:");

            if (IsLutCreatorInstalled)
            {
                messageBuilder.AppendLine("- LutCreator");
            }

            if (IsEyecandyXInstalled)
            {
                messageBuilder.AppendLine("- EyecandyX");
            }

            if (IsPlayItInstalled)
            {
                messageBuilder.AppendLine("- PlayIt");
            }

            if (IsRelightInstalled)
            {
                messageBuilder.AppendLine("- Relight");
            }

            if (IsRenderItInstalled)
            {
                messageBuilder.AppendLine("- RenderIt");
            }

            if (IsSpeedSliderV2Installed)
            {
                messageBuilder.AppendLine("- SpeedSliderV2");
            }

            if (IsThemeMixer2Installed)
            {
                messageBuilder.AppendLine("- ThemeMixer2");
            }

            if (IsThemeMixer2_5Installed)
            {
                messageBuilder.AppendLine("- ThemeMixer2.5");
            }

            if (IsUltimateEyecandyInstalled)
            {
                messageBuilder.AppendLine("- UltimateEyecandy");
            }

            if (IsUnifiedUIInstalled)
            {
                messageBuilder.AppendLine("- UnifiedUI");
            }

            panel.SetMessage("Installed Visual Mods", messageBuilder.ToString(), false);
        }
    }
}
