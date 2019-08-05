using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BecomeLegend.Crota
{
    [AutoloadBossHead]
    public class CrotaBoss : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crota");
            Main.npcFrameCount[npc.type] = 3;


        }

        public override void SetDefaults()
        {
            npc.aiStyle = -1;
            npc.lifeMax = 20000;
            npc.damage = 50;
            npc.defense = 25;
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 200;
            npc.value = 10000;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            music = MusicID.Boss1;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * .625f * bossLifeScale);
            npc.damage = (int)(npc.damage * .6f);
            npc.defense = (int)(npc.defense + numPlayers);
        }

        public override void AI()
        {
            Player player = Main.player[npc.target];

            DespawnBoss(player);

            Move(new Vector2(0, -100f) , player);
            //attacks
            npc.ai[1] -= 1f; //subtracts from ai
            if(npc.ai[1] <= 0f)
            {
                Attack(player);
            }
        }

        private void Move(Vector2 offset , Player player)
        {
            float speed = 5f;
            Vector2 moveTo = player.Center + offset;
            Vector2 move = moveTo - npc.Center;
            float magnitude = Magnitude(move);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            npc.velocity = move;
        }

        private void DespawnBoss(Player player)
        {
            if(!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if(!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, -10f);
                }
            }
        }

        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }
        /*
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 0.2D;       
        }
        */

        private void Attack(Player player)
        {
            

        }

        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CrotaBossBag"));
            }
        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }



    }
}
