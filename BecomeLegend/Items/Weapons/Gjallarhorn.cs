using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BecomeLegend.Items.Weapons
{
    public class Gjallarhorn : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gjallarhorn");
            Tooltip.SetDefault("This is a modded gun");
        }
        public override void SetDefaults()
        {
            item.damage = 50;
            item.ranged = true;
            item.width = 90;
            item.height = 52;
            item.useTime = 120;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 4;
            item.autoReuse = true;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("GjallarhornP1");
            item.useAmmo = mod.ItemType("Heavy");
            item.shootSpeed = 16f;
        }
        public override void OnConsumeAmmo(Player player)
        {
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/GjallahornS"));
            if (Main.rand.NextBool(5))
            {
                player.AddBuff(BuffID.Wrath, 180);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
