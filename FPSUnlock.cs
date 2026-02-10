using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using System;
using System.Reflection;
using System.IO;

[BepInPlugin("fps.unlocker", "FPS Unlocker", "1.0")]
public class FPSUnlock : BaseUnityPlugin
{
    private ConfigEntry<int> maxFPS;
    private int lastFPS;
    private PropertyInfo vSyncCountProp;
    private PropertyInfo targetFrameRateProp;
    private FileSystemWatcher watcher;

    void Awake()
    {
        maxFPS = Config.Bind(
            "General",
            "MaxFPS",
            144,
            "Maximum FPS for the game"
        );

        lastFPS = maxFPS.Value;

        var qsType = typeof(QualitySettings);
        var appType = typeof(Application);

        vSyncCountProp = qsType.GetProperty("vSyncCount", BindingFlags.Public | BindingFlags.Static);
        targetFrameRateProp = appType.GetProperty("targetFrameRate", BindingFlags.Public | BindingFlags.Static);

        ApplyFPS(lastFPS);

        watcher = new FileSystemWatcher(Path.GetDirectoryName(Config.ConfigFilePath));
        watcher.Filter = Path.GetFileName(Config.ConfigFilePath);
        watcher.NotifyFilter = NotifyFilters.LastWrite;
        watcher.Changed += OnConfigChanged;
        watcher.EnableRaisingEvents = true;

        Logger.LogInfo($"FPS Unlocker started. Initial MaxFPS: {lastFPS}");
    }

    private void OnConfigChanged(object sender, FileSystemEventArgs e)
    {
        try
        {
            Config.Reload();
            int currentFPS = maxFPS.Value;
            if (currentFPS != lastFPS)
            {
                lastFPS = currentFPS;
                ApplyFPS(lastFPS);
                Logger.LogInfo($"FPS updated in real time: {lastFPS}");
            }
        }
        catch { }
    }

    private void ApplyFPS(int fps)
    {
        vSyncCountProp?.SetValue(null, 0);
        targetFrameRateProp?.SetValue(null, fps);
    }
}