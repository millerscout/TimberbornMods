using ModSettings.Common;
using ModSettings.Core;
using Timberborn.Modding;
using Timberborn.SettingsSystem;
using Timberborn.SingletonSystem;

namespace TimberbornProfiler
{
    internal class ProfilerSettings : ModSettingsOwner, IUnloadableSingleton
    {
        public static ProfilerSettings? Instance { get; private set; }

        /// <summary>Enable per-tick CSV profiling. Off by default — zero overhead when disabled.</summary>
        public ModSetting<bool> EnableProfiling { get; }

        /// <summary>How many ticks between CSV flushes to disk (10–1000).</summary>
        public RangeIntModSetting FlushIntervalTicks { get; }

        /// <summary>Also print a summary line to Player.log every flush.</summary>
        public ModSetting<bool> PrintSummaryToLog { get; }

        protected override string ModId => "TimberbornProfiler";

        public ProfilerSettings(
            ISettings settings,
            ModSettingsOwnerRegistry modSettingsOwnerRegistry,
            ModRepository modRepository)
            : base(settings, modSettingsOwnerRegistry, modRepository)
        {
            Instance = this;
            EnableProfiling    = new ModSetting<bool>(false,        Descriptor("enable"));
            FlushIntervalTicks = new RangeIntModSetting(200, 10, 1000, Descriptor("flushinterval"));
            PrintSummaryToLog  = new ModSetting<bool>(true,         Descriptor("printsummary"));
        }

        protected override void OnAfterLoad()
        {
            ProfilerManager.RefreshSettings();
            ModSettingChanged += (_, _) => ProfilerManager.RefreshSettings();
        }

        public void Unload()
        {
            ModSettingChanged -= (_, _) => ProfilerManager.RefreshSettings();
        }

        private static ModSettingDescriptor Descriptor(string key) =>
            ModSettingDescriptor
                .CreateLocalized($"timberbornprofiler.settings.{key}")
                .SetLocalizedTooltip($"timberbornprofiler.settings.{key}.desc");
    }
}
