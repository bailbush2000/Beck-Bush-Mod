using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BecomeLegend.Dusts
{
    public class LightningD : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.frame = new Rectangle(100, 400, -100, -400);
        }

        public override bool Update(Dust dust)
        {
            dust.scale -= 0.005f;
            if (dust.scale < 0.75f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}