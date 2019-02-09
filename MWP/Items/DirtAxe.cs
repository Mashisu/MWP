using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MWP.Items
{
	public class DirtAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Faster!");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 9;
			item.useAnimation = 9;
			item.axe = 5;			//How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 1;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 7);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
