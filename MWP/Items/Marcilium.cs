using Terraria.ID;
using Terraria.ModLoader;

namespace MWP.Items
{
	public class Marcilium : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The heart of the Marcilium Slime");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 60;
			item.rare = 1;
		}
		}
	}

