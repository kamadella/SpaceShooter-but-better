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
        Random rand = new Random();
        List<int> possible = new List<int>() {0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500 }; //na jakiej szerokosci moga sie spawnowac aka 11 potworkow w 1 linii
        public SpawnManager(SpaceShooter game, int Aliens)
        {
            gameScreen = game;

            List<int> listNumbers1 = new List<int>(possible);
            List<int> listNumbers2 = new List<int>(possible);
            int index;
            for (int i = 0; i < Aliens; i++)  //tworzymy iles potworow 
            {
                if (i < 11) //gdy mieszcza sie w 1 linii
                {
                    index = rand.Next(0, listNumbers1.Count);
                    SpawnOrangeAlien(listNumbers1[index], 50);
                    
                    listNumbers1.RemoveAt(index);
                }
                else
                {
                    index = rand.Next(0, listNumbers2.Count);
                    SpawnOrangeAlien(listNumbers2[index], 120);
                    
                    listNumbers2.RemoveAt(index);
                }

            }
            
            
            //SpawnGreenAlien();
            //SpawnPinkAlien();
            //SpawnRedAlien();
            //SpawnBlueAlien();
        }

        private void SpawnOrangeAlien(int width, int height)
        {
            Alien alien = new AlienOrange();
            alien.SpawnAlien(gameScreen, width, height);
        }
        /*
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
        */
    }
}
