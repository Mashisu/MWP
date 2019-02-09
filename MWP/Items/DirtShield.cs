using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MWP.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class DirtShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
				
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 1;
			item.rare = 1;
			item.accessory = true;
			item.defense = 2;
			item.lifeRegen = 0;
		}



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 35);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
