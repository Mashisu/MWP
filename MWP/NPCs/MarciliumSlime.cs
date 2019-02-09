using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MWP.NPCs
{
    // This ModNPC serves as an example of a complete AI example.
    public class MarciliumSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Marcilium Slime"); // Automatic from .lang files
            Main.npcFrameCount[npc.type] = 2; // make sure to set this for your modnpcs.
        }

        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.aiStyle = 1; // This npc has a completely unique AI, so we set this to -1.
            npc.damage = 7;
            npc.defense = 5;
            npc.lifeMax = 50;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            aiType = NPCID.BlueSlime;
            animationType = NPCID.BlueSlime;
            //npc.alpha = 175;
            //npc.color = new Color(0, 80, 255, 100);
            npc.value = 25f;
            npc.buffImmune[BuffID.Poisoned] = true;
            npc.buffImmune[BuffID.Confused] = false; // npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            // we would like this npc to spawn in the overworld.
            return SpawnCondition.OverworldDaySlime.Chance * 0.1f;
        }
        public override void NPCLoot()
        {
            if (Main.netMode != 1) Item.NewItem(npc.getRect(), mod.ItemType("Marcilium"));
        }
    }
}