using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BecomeLegend.Buffs
{
    public class Lightning : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Lightning");
            Description.SetDefault("Zap Zap");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
            canBeCleared = false;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeRegen -= 500;
        }
    }
}