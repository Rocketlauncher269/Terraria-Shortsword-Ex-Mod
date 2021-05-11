using Terraria.ID;
using Terraria.ModLoader;

namespace ShortswordEX.Items.TerraBlade
{
	public class CrimsonShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blood Dagger"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.damage = 16;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}