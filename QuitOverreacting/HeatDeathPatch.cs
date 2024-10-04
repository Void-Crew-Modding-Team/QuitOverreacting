using CG.Game.Player;
using HarmonyLib;

namespace QuitOverreacting
{
    [HarmonyPatch(typeof(Player), "Awake")]
    internal class HeatDeathPatch
    {
        static void Postfix(Player __instance)
        {
            __instance.Parameters.DeathToHeat = 120f;
        }
    }
}
