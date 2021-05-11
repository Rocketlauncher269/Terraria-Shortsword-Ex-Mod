using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShortswordEX.Items.TerraBlade
{
	public class EdgeShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Short's Edge"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.damage = 34;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.knockBack = 7;
			item.value = 28000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(mod, "HellShortsword", 1);
                        recipe.AddIngredient(mod, "CorruptShortsword", 1);
                        recipe.AddIngredient(mod, "DungeonShortsword", 1);
                        recipe.AddIngredient(mod, "JungleShortsword", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
                        recipe.AddIngredient(mod, "HellShortsword", 1);
                        recipe.AddIngredient(mod, "CrimsonShortsword", 1);
                        recipe.AddIngredient(mod, "DungeonShortsword", 1);
                        recipe.AddIngredient(mod, "JungleShortsword", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}