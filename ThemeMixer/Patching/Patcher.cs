using System.Reflection;
using HarmonyLib;
using static ThemeMixer3.Mod;

namespace ThemeMixer3.Patching
{
    public static class Patcher
    {
        private const string HarmonyId = "com.nyoko.ThemeMixer32.5";

        private static bool patched = false;

        private static UltimateEyeCandyPatch UltimateEyeCandyPatch { get; set; }

        public static void PatchAll()
        {
            if (patched) return;

            UnityEngine.Debug.Log("ThemeMixer3 2.5: Patching...");

            patched = true;

            Harmony harmony = new Harmony(HarmonyId);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            if (IsModEnabled(672248733UL, "UltimateEyeCandy"))
            {
                UltimateEyeCandyPatch = new UltimateEyeCandyPatch();
                UltimateEyeCandyPatch.Patch(harmony);
            }
        }

        public static void UnpatchAll()
        {
            if (!patched) return;

            Harmony harmony = new Harmony(HarmonyId);
            harmony.UnpatchAll(HarmonyId);

            patched = false;

            UnityEngine.Debug.Log("ThemeMixer3 2.5: Reverted...");
        }
    }
}