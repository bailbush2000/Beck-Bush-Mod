using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BecomeLegend.Items.Weapons
{
    public class Primary : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This ammo is used by all primary ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 1;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 1000;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("ExampleBullet");   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 16f;                  //The speed of the projectile
            item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(mod.ItemType("ExampleItem"), 1);
            recipe.AddTile(mod.TileType("ExampleWorkbench"));
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}
