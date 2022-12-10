using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class SpaceShooter : Form
    {
        SpawnManager spawnManage;
        CollisionManager collisionManage;

        bool goLeft, goRight;

        int playerLife = 100;
        int speed = 10;
        int score = 0;
        int level = 1;

        public SpawnManager SpawnManage { get => spawnManage;}
        public int PlayerLife { get => playerLife; set => playerLife = value; }
        public int Score { get => score; set => score = value; }
        public int Level { get => level; set => level = value; }

        public SpaceShooter()
        {
            spawnManage= new SpawnManager(this, 13);
            collisionManage= new CollisionManager(this);

            InitializeComponent();
        }

        private void GetUserInput()
        {

        }

        private void MovePlayer()
        {
            if (goLeft ==true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
        }

        private void isPlayerAlive()
        {
            if(playerLife > 1)
            {
                LifeBar.Value = playerLife;
            }
            else
            {
                GameTimer.Stop();
                GameOver gameOver = new GameOver(score);
                gameOver.ShowDialog();
                this.Close();
            }


        }

        private void GameTick(object sender, EventArgs e)
        {
            player.BringToFront();
            isPlayerAlive();
            LabelScore.Text = "Punkty: " + Score;
            LabelLevel.Text = "Level: " + Level;
            MovePlayer();
            collisionManage.DetectCollision();
        }

        private void isKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        private void isKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if(e.KeyCode == Keys.Space)
            {
                ShootBullet(); //gracz strzela
            }

        }



        private void ShootBullet()
        {
            Bullet newBullet = new BulletGrey();
            newBullet.Direction = Direction.up;
            newBullet.BulletPosLeft = player.Left + (player.Width / 3);
            newBullet.BulletPosTop = player.Top + (player.Height / 2);
            newBullet.CreateBullet(this);
        }
    }
}
