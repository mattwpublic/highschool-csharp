using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidemanBrickOutV2
{
 
    public partial class Form1 : Form
    {
        Image canvas;
        int boardWidth = 1920;
        int boardHeight = 1080;
        int r = 0;
        int c = 0;
        int brickcol = 50;
        int brickrow = 25;
        int score = 0;
        Ball ball;
        Brick[] brick;
        Paddle paddle;

        Brush[] BrickBrush;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(boardWidth, boardHeight);
            BrickBrush = new Brush[6];
            BrickBrush[0] = Brushes.Black;
            BrickBrush[1] = Brushes.Red;
            BrickBrush[2] = Brushes.Orange;
            BrickBrush[3] = Brushes.Yellow;
            BrickBrush[4] = Brushes.GreenYellow;
            BrickBrush[5] = Brushes.Green;

            ball = new Ball(300, 400, 10, 5, 5);
            brick = new Brick[brickcol * brickrow];
            double colwidth = boardWidth / brickcol;
            double rowheight = (boardHeight/2) / brickrow;
            double brickx = c * colwidth + (.1 * colwidth);
            double bricky = r * rowheight + (.1 * rowheight);
            paddle = new Paddle(((boardWidth / 2) - ((int)(colwidth * 5) / 2)), (boardHeight - (((boardHeight / 2)) / 2) / 2), ((int)(colwidth/2)), ((int)rowheight/5));
            int i = 0;

            for (r = 0; r<brickrow;r++)
            {
                for(c = 0; c<brickcol;c++)
                {
                    brick[i] = new Brick( (int)(c * colwidth + (.1 * colwidth)), (int)(r * rowheight + (.1 * rowheight)), (int)(colwidth - (brickx * 2)), (int)(rowheight - (bricky * 2)), 5);
                    i++;
                }
            }
            ball.size = colwidth / 5;
            drawGame();
            timer1.Start();
        }
        public void drawGame()
        {
            Graphics g = Graphics.FromImage(canvas);
            g.Clear(Color.Black);
            g.FillEllipse(Brushes.White, (int)ball.x, (int)ball.y, (int) ball.size, (int)ball.size);
            for(int i = 0; i< brickcol * brickrow; i++)
            {
                if (brick[i].brickhp > 0)
                {
                    g.FillRectangle(BrickBrush[brick[i].brickhp], brick[i].x, brick[i].y, brick[i].width, brick[i].height);
                }
            }
            g.FillRectangle(Brushes.White, paddle.x, paddle.y, paddle.width, paddle.height);
            ScoreBox.Text = "" + score;
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawImage(canvas, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i;
            //Move the ball//

            ball.x += ball.speedX;
            ball.y += ball.speedY;

            //Border bouncing//

            if ((ball.y + ball.size) >= boardHeight && ball.speedY > 0)
            {
                ball.speedY *= -1;
                score -= 100;
            }
            else if (ball.y <= 0 && ball.speedY < 0)
            {
                ball.speedY *= -1;
            }
            else if ((ball.x + ball.size) >= boardWidth && ball.speedX > 0)
            {
                ball.speedX *= -1;
            }
            else if (ball.x <= 0 && ball.speedX < 0)
            {
                ball.speedX *= -1;
            }
            else if (ball.speedY > 0 &&
                    ball.y + ball.size >= paddle.y &&
                    ball.y + ball.size < paddle.y + ball.speedY &&
                    ball.x + ball.size >= paddle.x &&
                    ball.x <= paddle.x + paddle.width)
            {
                ball.speedY *= -1;
                ball.speedX += .05 * (ball.x + ball.size / 2 - (paddle.x + paddle.width) / 2);
                score += 10;
            }
            for (i = 0; i < brick.Length; i++)
            {
                if(brick[i].brickhp < 1)
                {
                    continue;
                }
                //bottom of brick[i]//

                if (ball.speedY < 0 &&
                    ball.y <= brick[i].y + brick[i].height &&
                    ball.y > brick[i].y + brick[i].height + ball.speedY &&
                    ball.x + ball.size >= brick[i].x &&
                    ball.x <= brick[i].x + brick[i].width
                )
                {
                    ball.speedY *= -1;
                    brick[i].brickhp += -1;
                    score += 10;
                }
                //top//
                else if (ball.speedY > 0 &&
                    ball.y + ball.size >= brick[i].y &&
                    ball.y + ball.size < brick[i].y + ball.speedY &&
                    ball.x + ball.size >= brick[i].x &&
                    ball.x <= brick[i].x + brick[i].width
                )
                {
                    ball.speedY *= -1;
                    brick[i].brickhp += -1;
                    score += 10;
                }

                //Left//
                else if (ball.speedX > 0 &&
                    ball.y + ball.size >= brick[i].y &&
                    ball.y <= brick[i].y + brick[i].height &&
                    ball.x + ball.size >= brick[i].x &&
                    ball.x + ball.size < brick[i].x + ball.speedX
                    )
                {
                    ball.speedX *= -1;
                    brick[i].brickhp += -1;
                    score += 10;
                }

                //right//
                else if (ball.speedX < 0 &&
                    ball.y + ball.size >= brick[i].y &&
                    ball.y <= brick[i].y + brick[i].height &&
                    ball.x <= brick[i].x + brick[i].width &&
                    ball.x > brick[i].x + brick[i].width + ball.speedX
                    )
                {
                    ball.speedX *= -1;
                    brick[i].brickhp += -1;
                    score += 10;
                }
                if(brick[i].brickhp == 0)
                {
                    score += 100;
                }
                
            }
            //Draw new frame//

            drawGame();
        

            //Refresh screen//

            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                paddle.x += paddle.xSpeed;
            } 
            if(e.KeyCode == Keys.Left)
            {
                paddle.x -= paddle.xSpeed;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            paddle.x = e.X - paddle.width/2;
        }
    }
}
