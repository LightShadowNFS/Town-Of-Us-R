using HarmonyLib;

namespace TownOfUs.CrewmateRoles.MayorMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.SetInfected))]
    public class NoButtons
    {
        public static void Postfix()
        {
            if (!CustomGameOptions.MayorButton)
                if (PlayerControl.LocalPlayer.Is(RoleEnum.Mayor)) PlayerControl.LocalPlayer.RemainingEmergencies = 0;
        }
    }

    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.Start))]
    public class NoButtonsHost
    {
        public static void Postfix()
        {
            if (!CustomGameOptions.MayorButton) 
                if (PlayerControl.LocalPlayer.Is(RoleEnum.Mayor)) PlayerControl.LocalPlayer.RemainingEmergencies = 0;
        }
    }
}