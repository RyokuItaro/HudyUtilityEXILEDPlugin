using Exiled.Events.EventArgs.Player;
using HudyUtilityPlugin.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudyUtilityPlugin.Handlers
{
    public class PlayerHandler
    {
        private PlayerHandlerHelper helper;
        private Config config;

        public PlayerHandler(Config config)
        {
            this.helper = new PlayerHandlerHelper();
            this.config = config;
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            if (config.HidePlayerInfo)
            {
                helper.HidePlayerInfo(ev.Player);
            }
        }
    }
}
