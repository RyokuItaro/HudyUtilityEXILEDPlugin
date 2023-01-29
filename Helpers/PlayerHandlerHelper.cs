using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudyUtilityPlugin.Helpers
{
    public class PlayerHandlerHelper
    {
        public PlayerHandlerHelper()
        {
        }

        public void HidePlayerInfo(Player player)
        {
            player.InfoArea &= ~PlayerInfoArea.CustomInfo;
            player.InfoArea &= ~PlayerInfoArea.Badge;
            player.InfoArea &= ~PlayerInfoArea.UnitName;
            player.InfoArea &= ~PlayerInfoArea.Nickname;
            player.InfoArea &= ~PlayerInfoArea.PowerStatus;
            player.InfoArea &= ~PlayerInfoArea.Role;
        }
    }
}
