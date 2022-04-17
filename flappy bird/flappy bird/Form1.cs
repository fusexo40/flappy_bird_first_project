using System;
using System.Windows.Forms;
namespace flappy_bird
{
    public partial class Flappy_bird : Form
    {
        int pipe_speed = 8, gravity = 15, score = 0;
        public Flappy_bird()
        {
            InitializeComponent();
        }
        private void Game_timer_ivent(object sender, EventArgs e)
        {
            Score_Text.Text = "Score: " + score.ToString();
            bird.Top += gravity;
            pipeTop.Left -= pipe_speed;
            pipeBottom.Left -= pipe_speed;
            if (pipeTop.Left <  - 20)
            {
                pipeTop.Left = 700;
                score += 1;
            }
            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 900;
                score += 1;
            }
            if (score > 10) {pipe_speed = 15; }
            
            if(bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
               bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               bird.Bounds.IntersectsWith(floor.Bounds)
                ) { 
                end();
                }
        }
        private void Key_down(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Space) {
                gravity = -15;
            }
        }
        private void Key_up(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Space)
            {
                gravity = 15;

            }
        }
        private void end() { 
            game_timer.Stop();
            Score_Text.Text += "!!! GAME OVER !!!";
            }
    }
}

