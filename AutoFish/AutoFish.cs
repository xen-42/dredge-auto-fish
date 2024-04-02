using HarmonyLib;
using UnityEngine;
using Winch.Core;

namespace AutoFish;

[HarmonyPatch]
public class AutoFish : MonoBehaviour
{
    public void Awake()
    {
        WinchCore.Log.Debug($"{nameof(AutoFish)} has loaded!");

        new Harmony(nameof(AutoFish)).PatchAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HarvestMinigame), nameof(HarvestMinigame.Update))]
    public static void HarvestMinigame_Update(HarvestMinigame __instance)
    {
        if (__instance.isGameRunning)
        {
            __instance.progress = 1f;
        }
    }
}
