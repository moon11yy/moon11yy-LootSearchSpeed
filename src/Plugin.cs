using BepInEx;
using HarmonyLib;

namespace LootSearchSpeed;

[BepInPlugin(
    PluginInfo.Guid,
    PluginInfo.Name,
    PluginInfo.Version)]
public class Plugin : BaseUnityPlugin
{
    internal static Plugin Instance { get; private set; } = null!;

    internal static Harmony Harmony { get; private set; } = null!;

    private void Awake()
    {
        Instance = this;

        Harmony = new Harmony(PluginInfo.Guid);
        Harmony.PatchAll();

        Logger.LogInfo($"{PluginInfo.Name} v{PluginInfo.Version} loaded.");
    }

    private void OnDestroy()
    {
        Harmony?.UnpatchSelf();

        Logger.LogInfo($"{PluginInfo.Name} unloaded.");
    }
}