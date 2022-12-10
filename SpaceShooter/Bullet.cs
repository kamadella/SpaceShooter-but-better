using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    public abstract class Bullet
    {

        int bulletPosLeft;
        int bulletPosTop;

        int speed = 20;

        PictureBox bullet = new PictureBox();
        Timer bulletTimer = new Timer();
        Direction direction;

        public int BulletPosLeft { get => bulletPosLeft; set => bulletPosLeft = value; }
        public int BulletPosTop { get => bulletPosTop; set => bulletPosTop = value; }
        public int Speed { get => speed; set => speed = value; }
        public PictureBox CurrentBullet { get => bullet; set => bullet = value; }
        public Timer BulletTimer { get => bulletTimer; set => bulletTimer = value; }
        public Direction Direction { get => direction; set => direction = value; }

        public virtual void CreateBullet(Form form)
        {
            CurrentBullet.BackColor = Color.Transparent;
            CurrentBullet.Left = BulletPosLeft;
            CurrentBullet.Top = BulletPosTop;
            CurrentBullet.BringToFront();
            form.Controls.Add(CurrentBullet);

            bulletTimer.Interval= Speed;
            bulletTimer.Tick += new EventHandler(BulletTick);
            bulletTimer.Start();
        }

        private void BulletTick(object sender, EventArgs e)
        {
            if(Direction == Direction.up)
            {
                CurrentBullet.Top -= Speed;
            }
            if (Direction == Direction.down)
            {
                CurrentBullet.Top += Speed;
            }


            if (CurrentBullet.Bottom < 50 || CurrentBullet.Bottom>900)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                CurrentBullet.Dispose();

                bulletTimer= null;
                CurrentBullet= null;
            }
        }

    }
}
