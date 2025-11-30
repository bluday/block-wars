using BlockWars.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlockWars
{
    public partial class Form1 : Form
    {
        private enum Position
        {
            Up,
            Down,
            Right,
            Left
        }

        private PictureBox playerObject = new PictureBox();

        private PictureBox objectB;

        private Position playerPosition;

        private bool dead;

        private bool play;

        private bool scored;

        private bool playerSprite;

        private Timer timer = new Timer();

        private float playerSpeed = 3f;

        private float x;

        private float y;

        private int timeElapsed;

        private int seconds;

        private int score;

        public Form1()
        {
            InitializeComponent();
        }

        private void Player()
        {
            playerObject.Anchor = AnchorStyles.None;
            playerObject.Height = 50;
            playerObject.Width = 50;
            if (playerSprite)
            {
                playerObject.BackColor = Color.Transparent;
            }
            else
            {
                playerObject.BackColor = Color.Blue;
            }
            playerObject.Parent = level;
            y = level.Height / 2 - playerObject.Height / 2;
            x = level.Width / 2 - playerObject.Width / 2;
        }

        private void Object()
        {
            objectB = new PictureBox();
            switch (new Random().Next(0, 5))
            {
                case 0:
                    objectB.BackColor = Color.Red;
                    break;
                case 1:
                    objectB.BackColor = Color.Green;
                    break;
                case 2:
                    objectB.BackColor = Color.Yellow;
                    break;
                case 3:
                    objectB.BackColor = Color.Purple;
                    break;
                case 4:
                    objectB.BackColor = Color.Cyan;
                    break;
                case 5:
                    objectB.BackColor = Color.Green;
                    break;
            }
            objectB.Height = 50;
            objectB.Width = 50;
            objectB.Parent = level;
            Random random = new Random();
            int num = random.Next(10, 400);
            int num2 = random.Next(10, 400);
            objectB.Location = new Point(num, num2);
        }

        private void DestroyObject(PictureBox gameObject)
        {
            if (gameObject.BackColor == Color.Yellow)
            {
                if (scored)
                {
                    score++;
                    playerSpeed += 2f;
                    level.Controls.Remove(gameObject);
                    gameObject.Dispose();
                    gameObject.Location = new Point(-1, -1);
                }
            }
            else if (gameObject.BackColor == Color.Purple)
            {
                if (scored)
                {
                    score++;
                    if (playerSpeed > 3f)
                    {
                        playerSpeed -= 2f;
                    }
                    if (playerSpeed < 1f)
                    {
                        playerSpeed += 1f;
                    }
                    level.Controls.Remove(gameObject);
                    gameObject.Dispose();
                    gameObject.Location = new Point(-1, -1);
                }
            }
            else if ((gameObject.BackColor == Color.Red || gameObject.BackColor == Color.Green || gameObject.BackColor == Color.Cyan) && scored)
            {
                score++;
                playerSpeed += 0.25f;
                level.Controls.Remove(gameObject);
                gameObject.Dispose();
                gameObject.Location = new Point(-1, -1);
            }
            if (!scored)
            {
                Object();
            }
        }

        private void GameTimer(object sender, EventArgs e)
        {
            if (play)
            {
                menuPanel.Enabled = false;
                menuPanel.Visible = false;
                seconds = timeElapsed / 60;
                playerObject.Location = new Point((int)x, (int)y);
                if (playerObject.Location.X < 1 || playerObject.Location.X > 983 || playerObject.Location.Y < 1 || playerObject.Location.Y > 408)
                {
                    dead = true;
                }
                else if (playerObject.Bounds.IntersectsWith(objectB.Bounds) && !scored)
                {
                    scored = true;
                    DestroyObject(objectB);
                    scored = false;
                    DestroyObject(objectB);
                }
                playerMovementSpeed.Text = "Player Speed: " + playerSpeed;
                if (!dead)
                {
                    timeElapsed++;
                    timerText.Text = "Score: " + score + " | Time: " + seconds + "s";
                    axis.Text = "Coordinates: " + x + ", " + y;
                    if (playerPosition == Position.Up)
                    {
                        y -= playerSpeed;
                    }
                    else if (playerPosition == Position.Down)
                    {
                        y += playerSpeed;
                    }
                    else if (playerPosition == Position.Right)
                    {
                        x += playerSpeed;
                    }
                    else if (playerPosition == Position.Left)
                    {
                        x -= playerSpeed;
                    }
                }
                else
                {
                    play = false;
                    playBtn.Text = "Play Again?";
                    if (level.Controls.Contains(objectB))
                    {
                        level.Controls.Remove(objectB);
                    }
                    if (score > Settings.Default.Highscore)
                    {
                        Settings.Default.Highscore = score;
                    }
                    else if (seconds > Settings.Default.HighscoreTime)
                    {
                        Settings.Default.HighscoreTime = seconds;
                    }
                    highscoreText.Text = "Highscore: " + Settings.Default.Highscore + " Points\nTime Highscore: " + Settings.Default.HighscoreTime + " Seconds";
                }
            }
            else
            {
                menuPanel.Enabled = true;
                menuPanel.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += GameTimer;
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Start();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            play = true;
            dead = false;
            playerPosition = Position.Right;
            playerSpeed = 3f;
            timeElapsed = 0;
            seconds = 0;
            score = 0;
            Player();
            Object();
        }

        private void changePlayerSprite_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose your own player sprite!";
            openFileDialog.FileName = "Image files (*.jpg, *.png) | *.jpg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                playerSprite = true;
                playerObject.ImageLocation = openFileDialog.FileName;
                playerObject.BackColor = Color.Transparent;
                playerObject.BackgroundImage = new Bitmap(openFileDialog.FileName);
                playerObject.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                playerSprite = false;
            }
            openFileDialog.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                playerPosition = Position.Down;
            }
            else if (e.KeyCode == Keys.Right)
            {
                playerPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.Left)
            {
                playerPosition = Position.Left;
            }
        }
    }
}