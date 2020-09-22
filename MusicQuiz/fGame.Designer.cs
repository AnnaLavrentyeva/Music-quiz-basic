namespace MusicQuiz
{
    partial class fGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.btnNext = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pointCounter1 = new System.Windows.Forms.Label();
            this.pointCounter2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.musicCounter = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMusicDuration = new System.Windows.Forms.Label();
            this.winMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.winMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::MusicQuiz.Properties.Resources._2;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(32, 452);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(219, 57);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1.Location = new System.Drawing.Point(60, 49);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(139, 37);
            this.player1.TabIndex = 2;
            this.player1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(572, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2";
            // 
            // pointCounter1
            // 
            this.pointCounter1.AutoSize = true;
            this.pointCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointCounter1.Location = new System.Drawing.Point(100, 129);
            this.pointCounter1.Name = "pointCounter1";
            this.pointCounter1.Size = new System.Drawing.Size(36, 37);
            this.pointCounter1.TabIndex = 4;
            this.pointCounter1.Text = "0";
            this.pointCounter1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pointCounter1_MouseClick);
            // 
            // pointCounter2
            // 
            this.pointCounter2.AutoSize = true;
            this.pointCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointCounter2.Location = new System.Drawing.Point(612, 129);
            this.pointCounter2.Name = "pointCounter2";
            this.pointCounter2.Size = new System.Drawing.Size(36, 37);
            this.pointCounter2.TabIndex = 5;
            this.pointCounter2.Text = "0";
            this.pointCounter2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pointCounter1_MouseClick);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(416, 452);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(135, 57);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinue.BackgroundImage")));
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.Location = new System.Drawing.Point(599, 452);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(135, 57);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // musicCounter
            // 
            this.musicCounter.AutoSize = true;
            this.musicCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicCounter.Location = new System.Drawing.Point(37, 258);
            this.musicCounter.Name = "musicCounter";
            this.musicCounter.Size = new System.Drawing.Size(99, 32);
            this.musicCounter.TabIndex = 8;
            this.musicCounter.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 332);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(730, 48);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMusicDuration
            // 
            this.labelMusicDuration.AutoSize = true;
            this.labelMusicDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMusicDuration.Location = new System.Drawing.Point(367, 49);
            this.labelMusicDuration.Name = "labelMusicDuration";
            this.labelMusicDuration.Size = new System.Drawing.Size(32, 32);
            this.labelMusicDuration.TabIndex = 10;
            this.labelMusicDuration.Text = "0";
            // 
            // winMediaPlayer
            // 
            this.winMediaPlayer.Enabled = true;
            this.winMediaPlayer.Location = new System.Drawing.Point(28, 596);
            this.winMediaPlayer.Name = "winMediaPlayer";
            this.winMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winMediaPlayer.OcxState")));
            this.winMediaPlayer.Size = new System.Drawing.Size(171, 12);
            this.winMediaPlayer.TabIndex = 0;
            this.winMediaPlayer.Visible = false;
            this.winMediaPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.winMediaPlayer_OpenStateChange);
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicQuiz.Properties.Resources.Krigi_Dlya_Fona;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.labelMusicDuration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.musicCounter);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pointCounter2);
            this.Controls.Add(this.pointCounter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.winMediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.winMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer winMediaPlayer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pointCounter1;
        private System.Windows.Forms.Label pointCounter2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label musicCounter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMusicDuration;
    }
}