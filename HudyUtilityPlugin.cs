using Exiled.API.Enums;
using Exiled.API.Features;
using HudyUtilityPlugin.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudyUtilityPlugin
{
    public class HudyUtilityPlugin : Plugin<Config>
    {
        public override Version Version => new Version(1, 0, 0);
        public override string Author => "RyokuItaro";

        public static HudyUtilityPlugin Singleton;
        public static HudyUtilityPlugin Instance => Singleton;
        public override PluginPriority Priority { get; } = PluginPriority.Last;
        private PlayerHandler playerHandler;

        public override void OnEnabled()
        {
            Singleton = this;
            playerHandler = new PlayerHandler(Config);

            Exiled.Events.Handlers.Player.Joined += playerHandler.OnJoined;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Joined -= playerHandler.OnJoined;

            playerHandler = null;
            Singleton = null;
            base.OnDisabled();
        }
    }
}
