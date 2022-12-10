using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace SpaceShooter
{
    public class CollisionManager
    {
        SpaceShooter gameScreen;
        public CollisionManager(SpaceShooter game)
        {
            gameScreen = game;
        }

        public void DetectCollision()
        {
            foreach (Control x in gameScreen.Controls)
            {
                foreach (Control y in gameScreen.Controls)
                {
                    if (y is PictureBox && (string)y.Tag == "playerBullet" && x is PictureBox && (string)x.Tag == "alien")
                    {
                        AlienHit(y, x);
                    }
                    if (y is PictureBox && (string)y.Tag == "player" && x is PictureBox && (string)x.Tag == "alienBullet")
                    {
                        PlayerHit(y, x);
                    }
                }
            }
        }

        public void AlienHit(Control x, Control y)
        {
            if(x.Bounds.IntersectsWith(y.Bounds))
            {
                gameScreen.Controls.Remove(x);
                ((PictureBox)x).Dispose();
                gameScreen.Controls.Remove(y);
                ((PictureBox)y).Dispose();
                gameScreen.Score += 10;
            }

        }

        public void PlayerHit(Control y, Control x)
        {
            if (y.Bounds.IntersectsWith(x.Bounds))
            {
                gameScreen.Controls.Remove(x);
                ((PictureBox)x).Dispose();
                gameScreen.PlayerLife -= 5;
            }
        }
    }
}
