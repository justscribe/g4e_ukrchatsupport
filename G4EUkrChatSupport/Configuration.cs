﻿using System;
using Dalamud.Configuration;
using Dalamud.Plugin;

namespace UkrChatSupportPlugin;

[Serializable]
public class Configuration : IPluginConfiguration
{
    [NonSerialized]
    // ReSharper disable once InconsistentNaming
    private DalamudPluginInterface? PluginInterface;

    public bool ReactOnlyToUkLayout { get; set; }
    public bool ReplaceOnlyOnUkLayout { get; set; } = true;
    public bool ReplaceInput { get; set; } = true;

    public int Version { get; set; } = 1;

    public void Initialize(DalamudPluginInterface pluginInterface)
    {
        PluginInterface = pluginInterface;
    }

    public void Save()
    {
        PluginInterface!.SavePluginConfig(this);
    }
}
