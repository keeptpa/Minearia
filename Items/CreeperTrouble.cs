using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace Minearia.Items
{
    class CreeperTrouble : ModItem
    {
        // TODO, count as explosive for demolitionist spawn

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("出包力怕");
            Tooltip.SetDefault("游戏特性是游戏的一部分，不爽不要玩.");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("boom");
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
            recipe.AddIngredient(ItemID.PiggyBank, 1);
            recipe.AddIngredient(ItemID.Gel, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this,5);
            recipe.AddRecipe();
        }
    }
}
