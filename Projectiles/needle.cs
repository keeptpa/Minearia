using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Achievements;
namespace Minearia.Projectiles
{
    public class needle : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("∞Ÿ“∂±˘’Î");
        }

        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 1;
            projectile.friendly = true;
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(38, projectile.position);
            for (int i = 0; i < 10; i++)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 20, projectile.velocity.X * 0.25f, 1f, 150, Color.Aqua, 0.7f);
            }
        }
        public override void AI()
        {
            if (Main.rand.Next(2) == 0)
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 20, 0, 1,150,Color.Aqua,0.7f);
            }
        }
    }
}


