using Terraria.ID;
using Terraria.ModLoader;

namespace ShortswordEX.Items.V2
{
	public class CatShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("MeowMini"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Fun sized meowmare!'");
		}

		public override void SetDefaults() 
		{
			item.damage = 180;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 25000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
	 		item.shoot = 502;
			item.shootSpeed = 12f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}