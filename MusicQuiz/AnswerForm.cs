using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicQuiz
{
    public partial class AnswerForm : Form
    {
        private int answerTime = 10;
        public AnswerForm()
        {
            InitializeComponent();
        }

        private void AnswerForm_Load(object sender, EventArgs e)
        {
            answerTime = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            answerTime--;
            lblTimer.Text = answerTime.ToString();
            if(answerTime == 0)
            {
                timer1.Stop();
                //SoundPlayer sound = new SoundPlayer("Resources\\sound.wav");
                //sound.Play();
            }
        }

        private void AnswerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            var mp3file = TagLib.File.Create(Quiz.nameOfSong);

            lblAnswer.Text = mp3file.Tag.FirstAlbumArtist + " " + mp3file.Tag.Title;
        }
    }
}
