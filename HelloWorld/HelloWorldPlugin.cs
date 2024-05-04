using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Nautilus.Handlers;

namespace DanDoes.HelloWorld
{
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    [BepInDependency("com.snmodding.nautilus")]
    public class HelloWorldPlugin : BaseUnityPlugin
    {
        private const string MyGuid = "com.DanDoes.HelloWorld";
        private const string PluginName = "Hello World";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGuid);
        public static ManualLogSource Log;
        public static ModOptions ModOptions;

        private void Awake()
        {
            ModOptions = OptionsPanelHandler.RegisterModOptions<ModOptions>();

            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " loaded.");
            Log = Logger;
        }
    }
}
