using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDownShooter
{
    public partial class Form1 : Form
    {
        Player player = new Player { Health = 100, Speed = 10 };
        bool isGameOver = false;
        bool[] directionActivated = new bool[4];
        public enum Direction
        {
            Up,
            Down,
            Right,
            Left
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Update(object sender, EventArgs e)
        {
            if (player.Health > 1)
            {
                HealthBar.Value = player.Health;
            }
            else
            {
                isGameOver = true;
                Soldier.Image = Properties.Resources.DeadSoldier;
                GameTimer.Stop();
            }

            PlayerMovement();


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (isGameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                directionActivated[(int)Direction.Left] = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                directionActivated[(int)Direction.Right] = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                directionActivated[(int)Direction.Up] = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                directionActivated[(int)Direction.Down] = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                directionActivated[(int)Direction.Left] = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                directionActivated[(int)Direction.Right] = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                directionActivated[(int)Direction.Up] = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                directionActivated[(int)Direction.Down] = false;
            }

        }

        private void PlayerMovement()
        {
            if (directionActivated[(int)Direction.Up])
            {
                Soldier.Top -= player.Speed;
            }
            if (directionActivated[(int)Direction.Down])
                Soldier.Top += player.Speed;
            if (directionActivated[(int)Direction.Left])
                Soldier.Left -= player.Speed;
            if (directionActivated[(int)Direction.Right])
                Soldier.Left += player.Speed;

        }

        private Bitmap RotateImage(Bitmap bitmap, float angle)
        {
            return null;
        }

    }
}