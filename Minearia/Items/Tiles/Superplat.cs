using Terraria.ID;
using Terraria.ModLoader;

namespace Minearia.Items.Tiles
{
    public class Superplat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("超速部署平台");
            Tooltip.SetDefault(string.Format(" [c/6AACEE:“可发光、极速部署、耐高温、易降解”]"));
        }

         public override void SetDefaults()
        {
            item.width = 8;
            item.height = 10;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 2;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("Superplat");
            item.rare = 3;
        }
        // Set other item.X values here
        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.SetResult(this, 80);
            recipe.AddRecipe();
        }
    }

       
    }
