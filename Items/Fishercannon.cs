using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Minearia.Items
{
    public class Fishercannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("狗头人巨炮");
            Tooltip.SetDefault(" “狗才摸鱼！” ");
        }

        public override void SetDefaults()
        {
            item.damage = 55;
            item.noMelee = true;
            item.ranged = true;
            item.useAmmo = AmmoID.Bullet;
            item.channel = true; //Channel so that you can held the weapon [Important]
            item.rare = 3;
            item.width = 28;
            item.height = 30;
            item.useTime = 14;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Rua");
            item.useStyle = 5;
            item.shootSpeed = 16f;
            item.useAnimation = 14;
            item.shoot = mod.ProjectileType("Fish");
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

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .25f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
            {
                type = mod.ProjectileType("Fish"); // or ProjectileID.FireArrow;
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }

    }
}
