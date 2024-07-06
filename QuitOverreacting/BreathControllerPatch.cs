using HarmonyLib;
using VFX.PlayerHealth;

namespace QuitOverreacting
{
    [HarmonyPatch(typeof(BreathController), "DetermineBreathType")]
    internal class BreathControllerPatch
    {
        static void Prefix(CameraPostRenderSettings ___settings, ref float ____currentColdStrength, ref float ____currentHeatStrength, out float __state)
        {
            __state = ___settings.StartStrainAtOxygenLevel;
            ___settings.StartStrainAtOxygenLevel = 0.001f;
            ____currentColdStrength -= 0.99f;
            ____currentHeatStrength -= 0.99f;
        }

        static void Postfix(CameraPostRenderSettings ___settings, ref float ____currentColdStrength, ref float ____currentHeatStrength, float __state)
        {
            ___settings.StartStrainAtOxygenLevel = __state;
            ____currentColdStrength += 0.99f;
            ____currentHeatStrength += 0.99f;
        }
    }
}
