using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BecomeLegend.Items.Misc
{
    public class CrotaBossBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("Treasure Bag dropped from Crota.");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 40;
            item.height = 40;
            item.rare = 9;
            item.expert = true;
            bossBagNPC = mod.NPCType("CrotaBoss");
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("Thorn"));
            }
            player.QuickSpawnItem(mod.ItemType("Gjallarhorn"));
        }

    }
}
