using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Minearia.Items
{
    public class Starguide : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("星辰之引");
            Tooltip.SetDefault(string.Format(" [c/5CACEE:“愿夜之星辰指引Ana以方向”]"));
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.noMelee = true;
            item.magic = true;
            item.mana = 5;
            item.rare = 3;
            item.width = 28;
            item.height = 30;
            item.useTime = 25;
            item.UseSound = SoundID.Item13;
            item.useStyle = 5;
            item.shootSpeed = 15;
            item.useAnimation = 20;
            item.shoot = mod.ProjectileType("guidance");
            item.value = Item.sellPrice(silver: 60);
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
