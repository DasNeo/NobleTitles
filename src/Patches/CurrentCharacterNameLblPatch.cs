using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.ViewModelCollection.Conversation;

namespace NobleTitles.Patches
{
    [HarmonyPatch(typeof(MissionConversationVM), "CurrentCharacterNameLbl", MethodType.Getter)]
    public class CurrentCharacterNameLblPatch
    {
        public static bool Prefix(ref string __result)
        {
            if (Hero.OneToOneConversationHero is null)
                return true;
            __result = Hero.OneToOneConversationHero.Name.ToString();
            return false;
        }
    }
}
