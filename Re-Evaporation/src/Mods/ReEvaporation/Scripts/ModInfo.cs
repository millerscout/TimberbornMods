namespace Mods.ReEvaporation.Scripts
{
    public static class ModInfo
    {
        public const string HarmonyID = "ReEvaporation.water";
        public const string Name = "Re-Evaporation";

        public static EvaporationSettings? SettingsOwner { get; internal set; }
    }
}
