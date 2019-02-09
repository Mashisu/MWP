using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MWP.Items
{
	public class DirtPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Dirt Pickaxe");
            Tooltip.SetDefault("The Most inneficient way to mine.");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 7;
			item.useAnimation = 7;
			item.pick = 25;
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
