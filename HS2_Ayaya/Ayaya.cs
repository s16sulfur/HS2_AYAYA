using System;
using BepInEx;
using HarmonyLib;

namespace Patchers
{
    [BepInPlugin(GUID, PluginName, Version)]
    public class Ayaya : BaseUnityPlugin
    {
        private static class Hooks
        {
            [HarmonyPrefix]
            [HarmonyPatch(typeof(Studio.Info), "IsInstallAI", MethodType.Getter)]
            public static bool InitShortCutEvents1(ref bool __result)
            {
                __result = true;
                return false;
            }

            [HarmonyPrefix]
            [HarmonyPatch(typeof(Manager.GameSystem), "isSpecial02", MethodType.Getter)]
            public static bool InitShortCutEvents2(ref bool __result)
            {
                __result = true;
                return false;
            }

            [HarmonyPrefix]
            [HarmonyPatch(typeof(Manager.GameSystem), "isSpecial03", MethodType.Getter)]
            public static bool InitShortCutEvents3(ref bool __result)
            {
                __result = true;
                return false;
            }

            [HarmonyPrefix]
            [HarmonyPatch(typeof(Manager.GameSystem), "isSpecial04", MethodType.Getter)]
            public static bool InitShortCutEvents4(ref bool __result)
            {
                __result = true;
                return false;
            }
        }

        public const string GUID = "com.sulfur.bepinex.ayaya";

        public const string PluginName = "AYAYA Unlocker";

        public const string PluginNameInternal = "HS2_Ayaya";

        public const string Version = "1.0.1";

        internal void Main()
        {
            Harmony.CreateAndPatchAll(typeof(Hooks), null);
        }
    }
}
