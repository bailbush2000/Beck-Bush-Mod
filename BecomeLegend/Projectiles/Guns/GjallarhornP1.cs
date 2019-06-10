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
        }
        public override void AI()
        {
            for(int k = 0; k < 200; k++) {
                if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5)
                {
                    //Get the shoot trajectory from the projectile and target
                    float shootToX = Main.npc[k].position.X + (float)Main.npc[k].width * 0.5f - projectile.Center.X;
                    float shootToY = Main.npc[k].position.Y - projectile.Center.Y;
                    float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                    //If the distance between the live targeted npc and the projectile is less than 480 pixels
                    if (distance < 480f && !Main.npc[k].friendly && Main.npc[k].active)
                    {
                        //Divide the factor, 3f, which is the desired velocity
                        distance = 3f / distance;

                        //Multiply the distance by a multiplier if you wish the projectile to have go faster
                        shootToX *= distance * 5;
                        shootToY *= distance * 5;

                        //Set the velocities to the shoot values
                        projectile.velocity.X = shootToX;
                        projectile.velocity.Y = shootToY;
                    }
                }
            }
        }
    }
}