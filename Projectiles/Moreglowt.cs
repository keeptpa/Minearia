using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Achievements;
namespace Minearia.Projectiles
{
    public class Moreglowt : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("À©É¢Ó«¹â°ô");
        }

        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 12;
            projectile.aiStyle = 16;
            projectile.friendly = true;
            projectile.ranged = true;
            aiType = ProjectileID.Glowstick;
            projectile.timeLeft = 20;
        }
        public override void Kill(int timeLeft)
        {

            for (int i = 0; i < 20; i++)
            {
                // Random upward vector.
                Vector2 vel = new Vector2(Main.rand.NextFloat(-20, 20), Main.rand.NextFloat(-15, 0));
                Projectile.NewProjectile(projectile.Center, vel, 50, 0, projectile.knockBack, projectile.owner, 0, 1);
            }
            Main.PlaySound(SoundID.Item16, projectile.position);



        }
    }
}


