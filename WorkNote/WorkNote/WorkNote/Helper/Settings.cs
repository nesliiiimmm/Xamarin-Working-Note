﻿using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkNote.Helper
{
    public static class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string GeneralSettings
        {
            get => AppSettings.GetValueOrDefault(nameof(GeneralSettings), string.Empty);

            set => AppSettings.AddOrUpdateValue(nameof(GeneralSettings), value);

        }
        public static string GeneralSettingsPass
        {
            get => AppSettings.GetValueOrDefault(nameof(GeneralSettingsPass), string.Empty);

            set => AppSettings.AddOrUpdateValue(nameof(GeneralSettingsPass), value);

        }
    }
}
