using HarmonyLib;

namespace LootSearchSpeed.Core;

internal abstract class BasePatch
{
    protected readonly Harmony Harmony;

    protected BasePatch(Harmony harmony)
    {
        Harmony = harmony;
    }

    internal abstract void Apply();
}