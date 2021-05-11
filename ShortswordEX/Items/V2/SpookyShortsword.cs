using Terraria.ID;
using Terraria.ModLoader;

namespace ShortswordEX.Items.V2
{
	public class SpookyShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Horseman's Knife"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.damage = 68;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 3;
			item.knockBack = 7;
			item.value = 17000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 321;
			item.shootSpeed = 11f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpookyWood, 75);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}