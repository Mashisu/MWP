using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MWP.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class DirtHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("''Complete this set to mine faster!''");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 1;
			item.defense = 0;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("DirtBreastplate") && legs.type == mod.ItemType("DirtLeggings");
		}




        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increase Mining speed by 25%.";
            player.AddBuff(BuffID.Mining, 2);
        }






        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 30);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}