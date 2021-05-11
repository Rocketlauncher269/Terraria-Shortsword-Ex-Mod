using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShortswordEX.Items.V2
{
	public class TreeShortSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Christmas Shrub"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.damage = 105;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 3;
			item.knockBack = 5;
			item.value = 14000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		 	item.shoot = 335;
			item.shootSpeed = 12f;
		}



		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BorealWood, 15);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}