﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    class AlienPink : Alien
    {
        Bullet bullet;
        Timer shootTimer = new Timer();
        Form gameScreen;
        Random random = new Random();

        public override void SpawnAlien(Form form)
        {
            base.SpawnAlien(form);
            AlienSpawn.Left = 100;
            AlienSpawn.Top = 50;

            gameScreen = form;
            AlienSpawn.Image = Properties.Resources.alien4;
            gameScreen.Controls.Add(AlienSpawn);
            AlienSpawn.BringToFront();

            shootTimer.Interval = 1000;
            shootTimer.Tick += new EventHandler(ShootTick);
            shootTimer.Start();
        }

        private void ShootTick(object sender, EventArgs e)
        {
            if (!gameScreen.Controls.Contains(AlienSpawn))
            {
                bullet = null;
                shootTimer.Stop();
            }
            else
            {

                bullet = new BulletGreen();

                bullet.Direction = Direction.down;
                bullet.BulletPosLeft = AlienSpawn.Left + (AlienSpawn.Width / 4);
                bullet.BulletPosTop = AlienSpawn.Top + (AlienSpawn.Height / 2);
                bullet.CreateBullet(gameScreen);
            }
        }
    }
}
