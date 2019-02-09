using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MWP.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class DirtLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");

        }

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 1;
			item.defense = 0;
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
