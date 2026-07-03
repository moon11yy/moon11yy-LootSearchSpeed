using BepInEx.Logging;

namespace LootSearchSpeed.Utils;

internal static class Log
{
    private static ManualLogSource Logger => Plugin.Instance.Logger;

    internal static void Info(string message)
    {
        Logger.LogInfo(message);
    }

    internal static void Warning(string message)
    {
        Logger.LogWarning(message);
    }

    internal static void Error(string message)
    {
        Logger.LogError(message);
    }
}