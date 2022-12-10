using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    public abstract class Alien
    {

        PictureBox alien;
        int alienPosLeft;
        int alienPosTop;

        public PictureBox AlienSpawn { get => alien; set => alien = value; }
        public int AlienPosLeft { get => alienPosLeft; set => alienPosLeft = value; }
        public int AlienPosTop { get => alienPosTop; set => alienPosTop = value; }

        public virtual void SpawnAlien(Form form)
        {
            alien = new PictureBox();
            AlienSpawn.Tag = "alien";
            AlienSpawn.Size = new Size(50,50);
            AlienSpawn.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
