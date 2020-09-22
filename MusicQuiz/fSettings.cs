using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicQuiz
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Quiz.allFolders = chBoxFoldersInside.Checked;
            Quiz.gameDuration = Convert.ToInt32(comboBoxGameDuraction.Text);
            Quiz.musicDuration = Convert.ToInt32(comboBoxAnswerTime.Text);
            Quiz.randomStartPartInMusic = checkBoxRandomStart.Checked;

            Quiz.WriteSettings();

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetSettings();

            this.Hide();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if( fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", 
                    chBoxFoldersInside.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                allFolders.Items.Clear();
                allFolders.Items.AddRange(music_list);
                Quiz.listOfMusic.Clear();
                Quiz.listOfMusic.AddRange(music_list);
                Quiz.lastFolder = fbd.SelectedPath;
            }
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            SetSettings();
            allFolders.Items.Clear();
            allFolders.Items.AddRange(Quiz.listOfMusic.ToArray());
        }

        void SetSettings()
        {
            chBoxFoldersInside.Checked = Quiz.allFolders;
            comboBoxGameDuraction.Text = Quiz.gameDuration.ToString();
            comboBoxAnswerTime.Text = Quiz.musicDuration.ToString();
            checkBoxRandomStart.Checked = Quiz.randomStartPartInMusic;
        }
    }
}
