using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minearia.Items
{
    public class Moreglowts : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("捆绑式巨量粘性荧光棒");
            Tooltip.SetDefault("“噗啊啊啊啊！” \n溢出的光明粘住并刺伤了黑夜的狗眼");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.shootSpeed = 16f;
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.shoot = mod.ProjectileType("Moreglowts");
            item.consumable = true;
            item.UseSound = SoundID.Item1;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.rare = 1;
            item.holdStyle = 1;
            item.flame = true;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glowstick, 20);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}