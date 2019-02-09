using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MWP.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class DirtBreastplate : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("DirtBreastplate");
            Tooltip.SetDefault("");
        }

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 1;
			item.defense = 1;
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
