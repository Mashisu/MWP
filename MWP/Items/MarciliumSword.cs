using Terraria.ID;
using Terraria.ModLoader;

namespace MWP.Items
{
	public class MarciliumSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Marcilium Sword");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
            item.scale = 1.5f;
            item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 160;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Marcilium"), 10);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
