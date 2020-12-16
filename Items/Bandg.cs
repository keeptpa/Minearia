using Terraria.ID;
using Terraria.ModLoader;

namespace Minearia.Items
{
	public class Bandg : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("捆绑式手雷");
			Tooltip.SetDefault("贫穷和杀意的终极结合体. \n 糟糕，粘太紧拆不掉了。");
		}
		public override void SetDefaults()
		{
            item.useStyle = 1;
            item.shootSpeed = 24f;
            item.shoot = mod.ProjectileType("bang");
            item.width = 8;
            item.height = 28;
            item.maxStack = 30;
            item.consumable = true;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 40;
            item.useTime = 40;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.rare = 2;

        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Grenade, 5);
            recipe.AddIngredient(ItemID.Gel, 1);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,1);
			recipe.AddRecipe();
		}
	}
}
