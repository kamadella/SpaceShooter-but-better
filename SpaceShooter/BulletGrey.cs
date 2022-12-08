using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    class BulletGrey : Bullet
    {

        public override void CreateBullet(Form form)
        {
            CurrentBullet.Image = Properties.Resources.bullet;
            CurrentBullet.Tag = "playerBullet";
            base.CreateBullet(form);
        }
    }
}
