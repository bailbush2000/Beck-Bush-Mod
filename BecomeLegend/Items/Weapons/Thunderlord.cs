using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Diagnostics;

namespace BecomeLegend.Items.Weapons
{
    public class Thunderlord : ModItem
    {
        double oldTime = Main.time;
        int i = 1;
        int k = 1;
       
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thunderlord");
            Tooltip.SetDefault("They rest quiet on fields afar…for this is no ending, but the eye.");
        }
        public override void SetDefaults()
        {
            item.damage = 50;
            item.ranged = true;
            item.width = 90;
            item.height = 52;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 4;
            item.autoReuse = true;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("ThunderlordP");
            item.useAmmo = mod.ItemType("Heavy");
            item.shootSpeed = 16f;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void OnConsumeAmmo(Player player)
        {
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/ThunderlordS"));
            double currentTime = Main.time;
            if ((currentTime - oldTime) > 120)
            {
                item.useTime = 20;
                i = 1;
                k = 1;
            }
            if (k % 2 != 0)
            {
                ++i;
                if (i > 15)
                {
                    i = 15;
                }
            }

            item.useTime = 20 - i;
            oldTime = Main.time;
            k += 1;
        }
    }
}
