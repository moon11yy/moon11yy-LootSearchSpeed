using HarmonyLib;
using LootSearchSpeed.Patches;

namespace LootSearchSpeed.Core;

internal static class PatchManager
{
    internal static void Apply(Harmony harmony)
    {
        new ContainerSearchPatch(harmony).Apply();
        new ItemExaminePatch(harmony).Apply();
    }
}