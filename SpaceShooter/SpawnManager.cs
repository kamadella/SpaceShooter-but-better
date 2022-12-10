using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SpaceShooter
{
    public class SpawnManager
    {
        SpaceShooter gameScreen;
        List<int> possible = new List<int>() {0,2 };
        public SpawnManager(SpaceShooter game)
        {
            gameScreen= game;
            
            /*
            List<int> listNumbers = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int index = rand.Next(0, possible.Count);
                listNumbers.Add(possible[index]);
                possible.RemoveAt(index);
            }
            */
            SpawnOrangeAlien();
            //SpawnGreenAlien();
            //SpawnPinkAlien();
            //SpawnRedAlien();
            //SpawnBlueAlien();
        }

        private void SpawnOrangeAlien()
        {
            Alien alien = new AlienOrange();
            alien.SpawnAlien(gameScreen);
        }
        private void SpawnRedAlien()
        {
            Alien alien = new AlienRed();
            alien.SpawnAlien(gameScreen);
        }
        private void SpawnPinkAlien()
        {
            Alien alien = new AlienPink();
            alien.SpawnAlien(gameScreen);
        }
        private void SpawnBlueAlien()
        {
            Alien alien = new AlienBlue();
            alien.SpawnAlien(gameScreen);
        }
        private void SpawnGreenAlien()
        {
            Alien alien = new AlienGreen();
            alien.SpawnAlien(gameScreen);
        }
    }
}
