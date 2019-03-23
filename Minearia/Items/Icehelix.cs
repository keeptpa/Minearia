using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Minearia.Items
{
    public class Icehelix : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("凛冬暴风");
            Tooltip.SetDefault(" “愿冬之凛冽赋予你力量” ");
        }

        public override void SetDefaults()
        {
            item.damage = 16;
            item.noMelee = true;
            item.magic = true;
            item.channel = true; //Channel so that you can held the weapon [Important]
            item.mana = 5;
            item.rare = 3;
            item.width = 28;
            item.height = 30;
            item.useTime = 25;
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
            recipe.AddIngredient(ItemID.IceBlock, 10);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
