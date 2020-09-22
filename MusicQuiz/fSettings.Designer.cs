namespace MusicQuiz
{
    partial class fSettings
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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.allFolders = new System.Windows.Forms.ListBox();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.chBoxFoldersInside = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGameDuraction = new System.Windows.Forms.ComboBox();
            this.comboBoxAnswerTime = new System.Windows.Forms.ComboBox();
            this.checkBoxRandomStart = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 328);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(152, 41);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Choose folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // allFolders
            // 
            this.allFolders.FormattingEnabled = true;
            this.allFolders.ItemHeight = 20;
            this.allFolders.Location = new System.Drawing.Point(-3, -2);
            this.allFolders.Name = "allFolders";
            this.allFolders.Size = new System.Drawing.Size(791, 324);
            this.allFolders.TabIndex = 1;
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Location = new System.Drawing.Point(194, 328);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(159, 41);
            this.btnRemoveList.TabIndex = 2;
            this.btnRemoveList.Text = "Remove list";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            // 
            // chBoxFoldersInside
            // 
            this.chBoxFoldersInside.AutoSize = true;
            this.chBoxFoldersInside.Location = new System.Drawing.Point(489, 337);
            this.chBoxFoldersInside.Name = "chBoxFoldersInside";
            this.chBoxFoldersInside.Size = new System.Drawing.Size(149, 24);
            this.chBoxFoldersInside.TabIndex = 3;
            this.chBoxFoldersInside.Text = "All folders inside";
            this.chBoxFoldersInside.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(561, 514);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 33);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(684, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxRandomStart);
            this.groupBox1.Controls.Add(this.comboBoxAnswerTime);
            this.groupBox1.Controls.Add(this.comboBoxGameDuraction);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 146);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current settings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer time:";
            // 
            // comboBoxGameDuraction
            // 
            this.comboBoxGameDuraction.FormattingEnabled = true;
            this.comboBoxGameDuraction.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.comboBoxGameDuraction.Location = new System.Drawing.Point(157, 27);
            this.comboBoxGameDuraction.Name = "comboBoxGameDuraction";
            this.comboBoxGameDuraction.Size = new System.Drawing.Size(52, 28);
            this.comboBoxGameDuraction.TabIndex = 2;
            this.comboBoxGameDuraction.Text = "60";
            // 
            // comboBoxAnswerTime
            // 
            this.comboBoxAnswerTime.FormattingEnabled = true;
            this.comboBoxAnswerTime.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.comboBoxAnswerTime.Location = new System.Drawing.Point(157, 65);
            this.comboBoxAnswerTime.Name = "comboBoxAnswerTime";
            this.comboBoxAnswerTime.Size = new System.Drawing.Size(52, 28);
            this.comboBoxAnswerTime.TabIndex = 3;
            this.comboBoxAnswerTime.Text = "20";
            // 
            // checkBoxRandomStart
            // 
            this.checkBoxRandomStart.AutoSize = true;
            this.checkBoxRandomStart.Location = new System.Drawing.Point(24, 113);
            this.checkBoxRandomStart.Name = "checkBoxRandomStart";
            this.checkBoxRandomStart.Size = new System.Drawing.Size(132, 24);
            this.checkBoxRandomStart.TabIndex = 7;
            this.checkBoxRandomStart.Text = "Random start";
            this.checkBoxRandomStart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player 2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "A";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(322, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "K";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chBoxFoldersInside);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.allFolders);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "fSettings";
            this.Text = "fSettings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ListBox allFolders;
        private System.Windows.Forms.Button btnRemoveList;
        private System.Windows.Forms.CheckBox chBoxFoldersInside;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxRandomStart;
        private System.Windows.Forms.ComboBox comboBoxAnswerTime;
        private System.Windows.Forms.ComboBox comboBoxGameDuraction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}