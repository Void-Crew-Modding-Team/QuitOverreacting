using VoidManager.MPModChecks;

namespace QuitOverreacting
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107";

        public override string Description => "Stops player breathing noises when the player isn't taking damage";
    }
}
