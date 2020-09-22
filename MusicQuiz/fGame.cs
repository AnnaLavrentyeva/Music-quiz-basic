using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicQuiz
{
    public partial class fGame : Form
    {
        Random random = new Random();

        private bool[] players = new bool[2];

        private int musicDuration = Quiz.musicDuration;
        public fGame()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();

        }

        private void MakeMusic()
        {
            if (Quiz.listOfMusic.Count == 0)
            {
                EndGame();
            }
            else
            {
                musicDuration = Quiz.musicDuration;
                int rnd = random.Next(0, Quiz.listOfMusic.Count());
                winMediaPlayer.URL = Quiz.listOfMusic[rnd];
             //   Quiz.nameOfSong = System.IO.Path.GetFileNameWithoutExtension(winMediaPlayer.URL);
                Quiz.nameOfSong = winMediaPlayer.URL;
                Quiz.listOfMusic.RemoveAt(rnd);
                musicCounter.Text = Quiz.listOfMusic.Count.ToString();
                players[0] = false;
                players[1] = false;
            }
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            winMediaPlayer.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            musicCounter.Text = Quiz.listOfMusic.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Quiz.gameDuration;
            labelMusicDuration.Text = musicDuration.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            labelMusicDuration.Text = musicDuration.ToString();
            if(progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if(musicDuration == 0)
            {
                MakeMusic();
            }
        }

        private void EndGame()
        {
            timer1.Stop();
            winMediaPlayer.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void GamePause()
        {
            timer1.Stop();
            winMediaPlayer.Ctlcontrols.pause();
        }

        private void GamePlay()
        {
            timer1.Start();
            winMediaPlayer.Ctlcontrols.play();
        }
        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;  
            if(players[0] == false && e.KeyData == Keys.A)
            {
                players[0] = true;
                GamePause();
                AnswerForm answerForm = new AnswerForm();
                answerForm.label1.Text = "Player 1";
                if (answerForm.ShowDialog() == DialogResult.Yes)
                {
                    pointCounter1.Text = Convert.ToString(Convert.ToInt32(pointCounter1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }

            if (players[1] == false && e.KeyData == Keys.K)
            {
                players[1] = true;
                GamePause();
                AnswerForm answerForm = new AnswerForm();
                answerForm.label1.Text = "Player 2";
                if (answerForm.ShowDialog() == DialogResult.Yes) 
                { 

                    pointCounter2.Text = Convert.ToString(Convert.ToInt32(pointCounter2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void winMediaPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Quiz.randomStartPartInMusic) 
            {
                if (winMediaPlayer.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    winMediaPlayer.Ctlcontrols.currentPosition = random.Next(0, (int)winMediaPlayer.currentMedia.duration / 2);
                }
        }
        }

        private void pointCounter1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
            }
        }
    }
}
