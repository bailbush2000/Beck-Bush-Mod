using Terraria.ID;
using Terraria.ModLoader;

namespace BecomeLegend.Items.Weapons
{
	public class Gjallarhorn : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gjallarhorn");
			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
            item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = 10;
            item.shootspeed = 16f;
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
