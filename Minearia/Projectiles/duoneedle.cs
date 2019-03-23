using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Achievements;
namespace Minearia.Projectiles
{
    public class duoneedle : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("°ÙÒ¶±ùÕëÄ¸±¾");
        }

        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.timeLeft = 6;
        }
        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 5; i++)
            {
                Vector2 vel = new Vector2(10 * projectile.velocity.X + 5 * Main.rand.NextFloat(-1, 1),10 * projectile.velocity.Y + 5 *Main.rand.NextFloat(-1, 1));
                Projectile.NewProjectile(projectile.Center, vel, mod.ProjectileType("needle"), projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
            }
        }
        public override void AI()
        {
            if (Main.rand.Next(2) == 0)
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 20, 0, 1, 150, Color.Aqua, 0.7f);
            }
        }
    }
}


