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
			Tooltip.SetDefault("This is a modded gun");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.ranged = true;
			item.width = 696;
			item.height = 564;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 4;
            item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("Primary");

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
	}
}
