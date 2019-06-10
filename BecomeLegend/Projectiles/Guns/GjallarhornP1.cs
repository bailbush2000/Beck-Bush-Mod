using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
  using Microsoft.Xna.Framework;
     using Microsoft.Xna.Framework.Graphics;
     using System;
using System.Collections.Generic;

namespace BecomeLegend.Projectiles.Guns
{
    public class GjallarhornP1 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("English Display Name Here");
        }

        public override void SetDefaults()
        {
            projectile.width = 20;               //The width of projectile hitbox
            projectile.height = 20;              //The height of projectile hitbox          //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
            projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
            projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.alpha = 1;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
            projectile.light = 0f;            //How much light emit around the projectile
            projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = true;
            aiType = 207;
            projectile.aiStyle = 1;//Can the projectile collide with tiles?         //Act exactly like default Bullet
        }
    }
}