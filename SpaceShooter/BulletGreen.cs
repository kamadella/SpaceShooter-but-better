using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    class BulletGreen : Bullet
    {
        public override void CreateBullet(Form form)
        {
            CurrentBullet.Image = Properties.Resources.alien_bullet;
            CurrentBullet.Tag = "alienBullet";
            CurrentBullet.SizeMode = PictureBoxSizeMode.AutoSize;
            base.CreateBullet(form);
        }
    }
}
