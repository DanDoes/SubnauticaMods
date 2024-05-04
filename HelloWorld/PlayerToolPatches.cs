using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Logging;
using HarmonyLib;

namespace DanDoes.HelloWorld
{
    [HarmonyPatch(typeof(PlayerTool))]
    internal class PlayerToolPatches
    {
        [HarmonyPatch(nameof(PlayerTool.Awake))]
        [HarmonyPostfix]
        public static void Awake_Postfix(PlayerTool __instance)
        {
            if (__instance.GetType() == typeof(Knife))
            {
                Knife knife = __instance as Knife;
                HelloWorldPlugin.Log.LogDebug($"Knife damage WAS: {knife.damage}");
                knife.damage *= HelloWorldPlugin.ModOptions.KnifeDamageMultiplier;
                HelloWorldPlugin.Log.LogDebug($"Knife damage is now: {knife.damage}");
            }
        }
    }
}
