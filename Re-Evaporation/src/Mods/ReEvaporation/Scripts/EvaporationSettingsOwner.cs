using System;
using ModSettings.Common;
using ModSettings.Core;
using Timberborn.Modding;
using Timberborn.SettingsSystem;
using Timberborn.SingletonSystem;

namespace Mods.ReEvaporation.Scripts
{
    internal class EvaporationSettingsOwner : ModSettingsOwner, IUnloadableSingleton
    {
        public static EvaporationSettingsOwner? Instance { get; private set; }

        public ModSetting<bool> EnableMod { get; }
        public RangeIntModSetting CoveredEvaporationRate { get; }
        public RangeIntModSetting UncoveredEvaporationRate { get; }
        public RangeIntModSetting MaxSearchHeight { get; }
        public RangeIntModSetting UpdateInterval { get; }

        protected override string ModId => "Re-evaporation";

        public EvaporationSettingsOwner(
            ISettings settings,
            ModSettingsOwnerRegistry modSettingsOwnerRegistry,
            ModRepository modRepository)
            : base(settings, modSettingsOwnerRegistry, modRepository)
        {
            Instance = this;
            EnableMod = new ModSetting<bool>(true, Descriptor("enablemod"));
            CoveredEvaporationRate = new RangeIntModSetting(50, 0, 400, Descriptor("coveredevaporationrate"));
            UncoveredEvaporationRate = new RangeIntModSetting(100, 0, 400, Descriptor("uncoveredevaporationrate"));
            MaxSearchHeight = new RangeIntModSetting(15, 3, 50, Descriptor("maxsearchheight"));
            UpdateInterval = new RangeIntModSetting(4, 1, 10, Descriptor("updateinterval"));
        }

        protected override void OnAfterLoad()
        {
            UpdateStaticSettings();
            ModSettingChanged += OnModSettingChanged;
        }

        public void Unload()
        {
            ModSettingChanged -= OnModSettingChanged;
        }

        private void OnModSettingChanged(object sender, ModSettingChangedEvent e)
        {
            UpdateStaticSettings();
        }

        private void UpdateStaticSettings()
        {
            if (ModInfo.SettingsOwner == null)
            {
                ModInfo.SettingsOwner = new EvaporationSettings();
            }
            ModInfo.SettingsOwner.EnableMod = EnableMod.Value;
            ModInfo.SettingsOwner.CoveredEvaporationRate = (float)CoveredEvaporationRate.Value / 100f;
            ModInfo.SettingsOwner.UncoveredEvaporationRate = (float)UncoveredEvaporationRate.Value / 100f;
            ModInfo.SettingsOwner.MaxSearchHeight = MaxSearchHeight.Value;
            ModInfo.SettingsOwner.UpdateInterval = MapUserValueToTicks(UpdateInterval.Value);
            EvaporationManager.Instance?.RefreshCachedSettings();
        }

        private static int MapUserValueToTicks(int userValue) => userValue switch
        {
            1  => 37,
            2  => 52,
            3  => 74,
            4  => 111,
            5  => 148,
            6  => 222,
            7  => 296,
            8  => 370,
            9  => 444,
            10 => 518,
            _  => 74,
        };

        private static ModSettingDescriptor Descriptor(string key)
        {
            return ModSettingDescriptor
                .CreateLocalized("reevaporation.settings." + key)
                .SetLocalizedTooltip("reevaporation.settings." + key + ".desc");
        }
    }
}
