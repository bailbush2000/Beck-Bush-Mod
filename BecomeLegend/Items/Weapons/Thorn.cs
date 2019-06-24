using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BecomeLegend.Items.Weapons
{
    public class Thorn : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thorn");
            Tooltip.SetDefault("\"To rend one's enemies is to see them not as equals, but objects—hollow of spirit and meaning.\" —13th Understanding, 7th Book of Sorrow");
        }
        public override void SetDefaults()
        {
            item.damage = 50;
            item.ranged = true;
            item.width = 90;
            item.height = 52;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 4;
            item.autoReuse = true;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("ThornP");
            item.useAmmo = mod.ItemType("Primary");
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
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/ThornS"));
            if (Main.rand.NextBool(5))
            {
                player.AddBuff(BuffID.Wrath, 180);
            }
        }
    }
}
