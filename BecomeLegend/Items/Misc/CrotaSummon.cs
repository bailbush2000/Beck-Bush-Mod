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
    public class CrotaSummon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hive Worm");
            Tooltip.SetDefault("Used to summon Crota.");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 40;
            item.height = 40;
            item.rare = 9;
            item.value = 100;
            item.useAnimation = 40;
            item.useTime = 45;
            item.consumable = true;
            item.useStyle = 4;
        }

        public override bool CanUseItem(Player player)
        {
            bool bossOne = NPC.downedBoss1;
            bool alreadySpawned = NPC.AnyNPCs(mod.NPCType("CrotaBoss"));
            return !alreadySpawned;

        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("CrotaBoss"));
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;

        }

    }
}
