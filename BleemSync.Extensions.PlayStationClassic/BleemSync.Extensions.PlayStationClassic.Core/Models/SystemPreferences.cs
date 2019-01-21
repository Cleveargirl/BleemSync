﻿using BleemSync.Extensions.PlayStationClassic.Core.Attributes;
using System.ComponentModel;

namespace BleemSync.Extensions.PlayStationClassic.Core.Models
{
    public class SystemPreferences : Preference
    {
        public SystemPreferences() { }
        public SystemPreferences(string configString) : base(configString) { }

        [DefaultValue(12.3)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuMainRadiUs")]
        public double LauncherMenuMainRadius { get; set; }

        [DefaultValue(12.3)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuOptionRadiUs")]
        public double LauncherMenuOptionRadius { get; set; }

        [DefaultValue(5.5)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuMainXDegrees")]
        public double LauncherMenuMainXDegrees { get; set; }

        [DefaultValue(4.4)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuOptionXDegrees")]
        public double LauncherMenuOptionXDegrees { get; set; }

        [DefaultValue(30.5)]
        [PreferenceProperty(Name = "dUiSystemSettingPerspectiveFovy")]
        public double PerspectiveFovY { get; set; }

        [DefaultValue(1.0)]
        [PreferenceProperty(Name = "dUiSystemSettingPerspectiveZnear")]
        public double PerspectiveZNear { get; set; }

        [DefaultValue(10000.0)]
        [PreferenceProperty(Name = "dUiSystemSettingPerspectiveZfar")]
        public double PerspectiveZFar { get; set; }

        [DefaultValue(6.2)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuMainYOffset")]
        public double LauncherMenuMainYOffset { get; set; }

        [DefaultValue(-31.6)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuMainZOffset")]
        public double LauncherMenuMainZOffset { get; set; }

        [DefaultValue(6.3)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuOptionYOffset")]
        public double LauncherMenuOptionYOffset { get; set; }

        [DefaultValue(-33.6)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuOptionZOffset")]
        public double LauncherMenuOptionZOffset { get; set; }

        [DefaultValue(-0.4)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuSelectIconMainYOffset")]
        public double LauncherMenuSelectIconMainYOffset { get; set; }

        [DefaultValue(-8.4)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuSelectIconMainZOffset")]
        public double LauncherMenuSelectIconMainZOffset { get; set; }

        [DefaultValue(-0.2)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuSelectIconOptionYOffset")]
        public double LauncherMenuSelectIconOptionYOffset { get; set; }

        [DefaultValue(-8.4)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuSelectIconOptionZOffset")]
        public double LauncherMenuSelectIconOptionZOffset { get; set; }

        [DefaultValue(150)]
        [PreferenceProperty(Name = "iUiSystemSettingLauncherMenudUration")]
        public int LauncherMenuDuration { get; set; }

        [DefaultValue(1.9)]
        [PreferenceProperty(Name = "dUiSystemSettingLauncherMenuIconScale")]
        public double LauncherMenuIconScale { get; set; }

        [DefaultValue(300)]
        [PreferenceProperty(Name = "iUiSystemSettingKeyRepeatDelay")]
        public int KeyRepeatDelay { get; set; }

        [DefaultValue(100)]
        [PreferenceProperty(Name = "iUiSystemSettingKeyRepeatInterval")]
        public int KeyRepeatInterval { get; set; }

        [DefaultValue("/data/AppData/sony/pcsx/.pcsx")]
        [PreferenceProperty(Name = "sPcsxDataLinkPath")]
        public string DataLinkPath { get; set; }

        [DefaultValue("/data/AppData/sony/pcsx/")]
        [PreferenceProperty(Name = "sPcsxDataOriginPath")]
        [ReadOnly(true)]
        public string DataOriginPath { get; set; }

        [DefaultValue("/data/AppData/sony/title")]
        [PreferenceProperty(Name = "sPcsxGameImageLinkPath")]
        public string GameImageLinkPath { get; set; }

        [DefaultValue("/gaadata/")]
        [PreferenceProperty(Name = "sPcsxGameImageOriginPath")]
        [ReadOnly(true)]
        public string GameImageOriginPath { get; set; }

        [DefaultValue("/data/AppData/sony/pcsx/")]
        [PreferenceProperty(Name = "sPcsxRunPath")]
        public string RunPath { get; set; }

        [DefaultValue("/data/AppData/sony/ui/")]
        [PreferenceProperty(Name = "sPcsxUiPath")]
        public string UiPath { get; set; }

        [DefaultValue("/data/AppData/sony/")]
        [PreferenceProperty(Name = "sPcsxInitPath")]
        public string InitPath { get; set; }

        [DefaultValue("/usr/sony/bin/pcsx")]
        [PreferenceProperty(Name = "sPcsxExecPath")]
        public string ExecPath { get; set; }

        [DefaultValue("/usr/sony/bin/bios")]
        [PreferenceProperty(Name = "sPcsxBiosPath")]
        public string BiosPath { get; set; }

        [DefaultValue("/data/AppData/sony/pcsx/bios")]
        [PreferenceProperty(Name = "sPcsxRunBiosPath")]
        public string RunBiosPath { get; set; }

        [DefaultValue("/data/power/disable")]
        [PreferenceProperty(Name = "sPcsxPowerSave")]
        public string PowerSave { get; set; }
    }
}
