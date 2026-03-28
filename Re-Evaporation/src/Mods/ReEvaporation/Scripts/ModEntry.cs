using System.Reflection;
using HarmonyLib;
using Timberborn.ModManagerScene;
using UnityEngine;

namespace Mods.ReEvaporation.Scripts
{
    public class ModEntry : IModStarter
    {
        public void StartMod(IModEnvironment modEnvironment)
        {
            if (ModInfo.SettingsOwner == null)
            {
                ModInfo.SettingsOwner = new EvaporationSettings();
            }
            new Harmony(ModInfo.HarmonyID).PatchAll(Assembly.GetExecutingAssembly());
            Debug.Log("[Re-Evaporation] Evaporation vs a levee, place your bets.");
        }
    }
}
