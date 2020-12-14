using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Minearia.Items
{
    public class Fishercannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("摸鱼巨炮");
            Tooltip.SetDefault(" “狗才摸鱼！” ");
        }

        public override void SetDefaults()
        {
            item.damage = 55;
            item.noMelee = true;
            item.ranged = true;
            item.channel = true; //Channel so that you can held the weapon [Important]
            item.rare = 3;
            item.width = 28;
            item.height = 30;
            item.useTime = 14;
            item.UseSound = SoundID.Item1;
            item.useStyle = 5;
            item.shootSpeed = 3;
            item.useAnimation = 20;
            item.shoot = mod.ProjectileType("duoneedle");
            item.value = Item.sellPrice(silver: 60);
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddIngredient(ItemID.StarCannon, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
