namespace SteamForms
{
    partial class WndwLibrary
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grpTypeRadio = new System.Windows.Forms.GroupBox();
            this.rbShame = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbOld = new System.Windows.Forms.RadioButton();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSteam = new System.Windows.Forms.Button();
            this.grpGameinfos = new System.Windows.Forms.GroupBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.tbxGameName = new System.Windows.Forms.TextBox();
            this.picGame = new System.Windows.Forms.PictureBox();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastPlayed = new System.Windows.Forms.Label();
            this.lblPlaytime = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.grpTypeRadio.SuspendLayout();
            this.grpGameinfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(22, 20);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpTypeRadio
            // 
            this.grpTypeRadio.Controls.Add(this.rbTop);
            this.grpTypeRadio.Controls.Add(this.rbShame);
            this.grpTypeRadio.Controls.Add(this.rbRandom);
            this.grpTypeRadio.Controls.Add(this.rbOld);
            this.grpTypeRadio.Location = new System.Drawing.Point(17, 50);
            this.grpTypeRadio.Name = "grpTypeRadio";
            this.grpTypeRadio.Size = new System.Drawing.Size(185, 185);
            this.grpTypeRadio.TabIndex = 1;
            this.grpTypeRadio.TabStop = false;
            this.grpTypeRadio.Text = "Funktionsweise";
            // 
            // rbShame
            // 
            this.rbShame.AutoSize = true;
            this.rbShame.Location = new System.Drawing.Point(18, 115);
            this.rbShame.Name = "rbShame";
            this.rbShame.Size = new System.Drawing.Size(58, 17);
            this.rbShame.TabIndex = 2;
            this.rbShame.TabStop = true;
            this.rbShame.Text = "Shame";
            this.rbShame.UseVisualStyleBackColor = true;
            this.rbShame.Click += new System.EventHandler(this.rbShame_Click);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(18, 76);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(65, 17);
            this.rbRandom.TabIndex = 1;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.Click += new System.EventHandler(this.rbRandom_Click);
            // 
            // rbOld
            // 
            this.rbOld.AutoSize = true;
            this.rbOld.Checked = true;
            this.rbOld.Location = new System.Drawing.Point(18, 36);
            this.rbOld.Name = "rbOld";
            this.rbOld.Size = new System.Drawing.Size(49, 17);
            this.rbOld.TabIndex = 0;
            this.rbOld.TabStop = true;
            this.rbOld.Text = "Oldie";
            this.rbOld.UseVisualStyleBackColor = true;
            this.rbOld.Click += new System.EventHandler(this.rbOld_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(368, 199);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(42, 36);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSteam
            // 
            this.btnSteam.Location = new System.Drawing.Point(35, 300);
            this.btnSteam.Name = "btnSteam";
            this.btnSteam.Size = new System.Drawing.Size(94, 36);
            this.btnSteam.TabIndex = 3;
            this.btnSteam.Text = "Open in Steam";
            this.btnSteam.UseVisualStyleBackColor = true;
            this.btnSteam.Click += new System.EventHandler(this.btnSteam_Click);
            // 
            // grpGameinfos
            // 
            this.grpGameinfos.Controls.Add(this.lblCurrent);
            this.grpGameinfos.Controls.Add(this.tbxDesc);
            this.grpGameinfos.Controls.Add(this.tbxGameName);
            this.grpGameinfos.Controls.Add(this.picGame);
            this.grpGameinfos.Location = new System.Drawing.Point(416, 12);
            this.grpGameinfos.Name = "grpGameinfos";
            this.grpGameinfos.Size = new System.Drawing.Size(323, 408);
            this.grpGameinfos.TabIndex = 4;
            this.grpGameinfos.TabStop = false;
            this.grpGameinfos.Text = "GameInfos";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(269, 382);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(48, 13);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "203/204";
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(16, 249);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.ReadOnly = true;
            this.tbxDesc.Size = new System.Drawing.Size(290, 128);
            this.tbxDesc.TabIndex = 2;
            this.tbxDesc.Text = "Beschreibung";
            // 
            // tbxGameName
            // 
            this.tbxGameName.Location = new System.Drawing.Point(16, 223);
            this.tbxGameName.Name = "tbxGameName";
            this.tbxGameName.ReadOnly = true;
            this.tbxGameName.Size = new System.Drawing.Size(291, 20);
            this.tbxGameName.TabIndex = 1;
            this.tbxGameName.Text = "Game Title";
            // 
            // picGame
            // 
            this.picGame.ImageLocation = "";
            this.picGame.Location = new System.Drawing.Point(16, 28);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(293, 189);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.label2);
            this.grpStats.Controls.Add(this.label1);
            this.grpStats.Controls.Add(this.lblLastPlayed);
            this.grpStats.Controls.Add(this.lblPlaytime);
            this.grpStats.Location = new System.Drawing.Point(243, 266);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(121, 141);
            this.grpStats.TabIndex = 5;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "My Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last played Since:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TotalPlaytime";
            // 
            // lblLastPlayed
            // 
            this.lblLastPlayed.AutoSize = true;
            this.lblLastPlayed.Location = new System.Drawing.Point(16, 91);
            this.lblLastPlayed.Name = "lblLastPlayed";
            this.lblLastPlayed.Size = new System.Drawing.Size(60, 13);
            this.lblLastPlayed.TabIndex = 1;
            this.lblLastPlayed.Text = "LastPLayer";
            // 
            // lblPlaytime
            // 
            this.lblPlaytime.AutoSize = true;
            this.lblPlaytime.Location = new System.Drawing.Point(16, 46);
            this.lblPlaytime.Name = "lblPlaytime";
            this.lblPlaytime.Size = new System.Drawing.Size(46, 13);
            this.lblPlaytime.TabIndex = 0;
            this.lblPlaytime.Text = "Playtime";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(745, 199);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 36);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Location = new System.Drawing.Point(18, 149);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(44, 17);
            this.rbTop.TabIndex = 3;
            this.rbTop.TabStop = true;
            this.rbTop.Text = "Top";
            this.rbTop.UseVisualStyleBackColor = true;
            this.rbTop.CheckedChanged += new System.EventHandler(this.rbTop_CheckedChanged);
            // 
            // WndwLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.grpGameinfos);
            this.Controls.Add(this.btnSteam);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.grpTypeRadio);
            this.Controls.Add(this.btnBack);
            this.Name = "WndwLibrary";
            this.Text = "SteamLibrary";
            this.grpTypeRadio.ResumeLayout(false);
            this.grpTypeRadio.PerformLayout();
            this.grpGameinfos.ResumeLayout(false);
            this.grpGameinfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpTypeRadio;
        private System.Windows.Forms.RadioButton rbShame;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbOld;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSteam;
        private System.Windows.Forms.GroupBox grpGameinfos;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.TextBox tbxGameName;
        private System.Windows.Forms.PictureBox picGame;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastPlayed;
        private System.Windows.Forms.Label lblPlaytime;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.RadioButton rbTop;
    }
}