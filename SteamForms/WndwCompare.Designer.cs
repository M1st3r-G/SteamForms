namespace SteamForms
{
    partial class WndwCompare
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
            this.dpdnFriends = new System.Windows.Forms.ComboBox();
            this.tbxMyself = new System.Windows.Forms.TextBox();
            this.imgUser1 = new System.Windows.Forms.PictureBox();
            this.imgUser2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumberUser1 = new System.Windows.Forms.TextBox();
            this.tbxNumberUser2 = new System.Windows.Forms.TextBox();
            this.tbxShared = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlaytimeOwn = new System.Windows.Forms.Label();
            this.grpGameinfos = new System.Windows.Forms.GroupBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.tbxGameName = new System.Windows.Forms.TextBox();
            this.picGame = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlaytimeFriend = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAchievmentUser1 = new System.Windows.Forms.Label();
            this.lblAchievmentUser2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser2)).BeginInit();
            this.grpStats.SuspendLayout();
            this.grpGameinfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpdnFriends
            // 
            this.dpdnFriends.FormattingEnabled = true;
            this.dpdnFriends.Location = new System.Drawing.Point(438, 107);
            this.dpdnFriends.MaxDropDownItems = 50;
            this.dpdnFriends.Name = "dpdnFriends";
            this.dpdnFriends.Size = new System.Drawing.Size(228, 21);
            this.dpdnFriends.TabIndex = 0;
            this.dpdnFriends.Text = "Friend";
            this.dpdnFriends.SelectedIndexChanged += new System.EventHandler(this.dpdnFriends_SelectedIndexChanged);
            // 
            // tbxMyself
            // 
            this.tbxMyself.Location = new System.Drawing.Point(85, 107);
            this.tbxMyself.Name = "tbxMyself";
            this.tbxMyself.ReadOnly = true;
            this.tbxMyself.Size = new System.Drawing.Size(215, 20);
            this.tbxMyself.TabIndex = 1;
            // 
            // imgUser1
            // 
            this.imgUser1.ImageLocation = "";
            this.imgUser1.Location = new System.Drawing.Point(12, 78);
            this.imgUser1.Name = "imgUser1";
            this.imgUser1.Size = new System.Drawing.Size(50, 50);
            this.imgUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser1.TabIndex = 2;
            this.imgUser1.TabStop = false;
            // 
            // imgUser2
            // 
            this.imgUser2.Location = new System.Drawing.Point(687, 78);
            this.imgUser2.Name = "imgUser2";
            this.imgUser2.Size = new System.Drawing.Size(50, 50);
            this.imgUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser2.TabIndex = 3;
            this.imgUser2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Games";
            // 
            // tbxNumberUser1
            // 
            this.tbxNumberUser1.Location = new System.Drawing.Point(274, 131);
            this.tbxNumberUser1.Name = "tbxNumberUser1";
            this.tbxNumberUser1.ReadOnly = true;
            this.tbxNumberUser1.Size = new System.Drawing.Size(40, 20);
            this.tbxNumberUser1.TabIndex = 5;
            // 
            // tbxNumberUser2
            // 
            this.tbxNumberUser2.Location = new System.Drawing.Point(420, 131);
            this.tbxNumberUser2.Name = "tbxNumberUser2";
            this.tbxNumberUser2.ReadOnly = true;
            this.tbxNumberUser2.Size = new System.Drawing.Size(40, 20);
            this.tbxNumberUser2.TabIndex = 6;
            // 
            // tbxShared
            // 
            this.tbxShared.Location = new System.Drawing.Point(306, 166);
            this.tbxShared.Name = "tbxShared";
            this.tbxShared.ReadOnly = true;
            this.tbxShared.Size = new System.Drawing.Size(40, 20);
            this.tbxShared.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shared Games";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(526, 410);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 25);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblAchievmentUser1);
            this.grpStats.Controls.Add(this.label5);
            this.grpStats.Controls.Add(this.label4);
            this.grpStats.Controls.Add(this.lblPlaytimeOwn);
            this.grpStats.Location = new System.Drawing.Point(85, 208);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(121, 102);
            this.grpStats.TabIndex = 12;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "My Stats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TotalPlaytime";
            // 
            // lblPlaytimeOwn
            // 
            this.lblPlaytimeOwn.AutoSize = true;
            this.lblPlaytimeOwn.Location = new System.Drawing.Point(16, 46);
            this.lblPlaytimeOwn.Name = "lblPlaytimeOwn";
            this.lblPlaytimeOwn.Size = new System.Drawing.Size(46, 13);
            this.lblPlaytimeOwn.TabIndex = 0;
            this.lblPlaytimeOwn.Text = "Playtime";
            // 
            // grpGameinfos
            // 
            this.grpGameinfos.Controls.Add(this.lblCurrent);
            this.grpGameinfos.Controls.Add(this.tbxGameName);
            this.grpGameinfos.Controls.Add(this.picGame);
            this.grpGameinfos.Location = new System.Drawing.Point(260, 208);
            this.grpGameinfos.Name = "grpGameinfos";
            this.grpGameinfos.Size = new System.Drawing.Size(260, 230);
            this.grpGameinfos.TabIndex = 11;
            this.grpGameinfos.TabStop = false;
            this.grpGameinfos.Text = "GameInfos";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(206, 214);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(48, 13);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "203/204";
            // 
            // tbxGameName
            // 
            this.tbxGameName.Location = new System.Drawing.Point(14, 189);
            this.tbxGameName.Name = "tbxGameName";
            this.tbxGameName.ReadOnly = true;
            this.tbxGameName.Size = new System.Drawing.Size(229, 20);
            this.tbxGameName.TabIndex = 1;
            this.tbxGameName.Text = "Game Title";
            // 
            // picGame
            // 
            this.picGame.ImageLocation = "";
            this.picGame.Location = new System.Drawing.Point(14, 19);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(229, 164);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(219, 410);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 25);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAchievmentUser2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPlaytimeFriend);
            this.groupBox1.Location = new System.Drawing.Point(545, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Friend Stats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TotalPlaytime";
            // 
            // lblPlaytimeFriend
            // 
            this.lblPlaytimeFriend.AutoSize = true;
            this.lblPlaytimeFriend.Location = new System.Drawing.Point(16, 46);
            this.lblPlaytimeFriend.Name = "lblPlaytimeFriend";
            this.lblPlaytimeFriend.Size = new System.Drawing.Size(46, 13);
            this.lblPlaytimeFriend.TabIndex = 0;
            this.lblPlaytimeFriend.Text = "Playtime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Achievements";
            // 
            // lblAchievmentUser1
            // 
            this.lblAchievmentUser1.AutoSize = true;
            this.lblAchievmentUser1.Location = new System.Drawing.Point(14, 82);
            this.lblAchievmentUser1.Name = "lblAchievmentUser1";
            this.lblAchievmentUser1.Size = new System.Drawing.Size(48, 13);
            this.lblAchievmentUser1.TabIndex = 4;
            this.lblAchievmentUser1.Text = "100/100";
            // 
            // lblAchievmentUser2
            // 
            this.lblAchievmentUser2.AutoSize = true;
            this.lblAchievmentUser2.Location = new System.Drawing.Point(14, 82);
            this.lblAchievmentUser2.Name = "lblAchievmentUser2";
            this.lblAchievmentUser2.Size = new System.Drawing.Size(48, 13);
            this.lblAchievmentUser2.TabIndex = 6;
            this.lblAchievmentUser2.Text = "100/100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Achievements";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(597, 412);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 15;
            // 
            // WndwCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.grpGameinfos);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxShared);
            this.Controls.Add(this.tbxNumberUser2);
            this.Controls.Add(this.tbxNumberUser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgUser2);
            this.Controls.Add(this.imgUser1);
            this.Controls.Add(this.tbxMyself);
            this.Controls.Add(this.dpdnFriends);
            this.Name = "WndwCompare";
            this.Text = "WndwCompare";
            this.Load += new System.EventHandler(this.WndwCompare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser2)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpGameinfos.ResumeLayout(false);
            this.grpGameinfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dpdnFriends;
        private System.Windows.Forms.TextBox tbxMyself;
        private System.Windows.Forms.PictureBox imgUser1;
        private System.Windows.Forms.PictureBox imgUser2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumberUser1;
        private System.Windows.Forms.TextBox tbxNumberUser2;
        private System.Windows.Forms.TextBox tbxShared;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlaytimeOwn;
        private System.Windows.Forms.GroupBox grpGameinfos;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox tbxGameName;
        private System.Windows.Forms.PictureBox picGame;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlaytimeFriend;
        private System.Windows.Forms.Label lblAchievmentUser1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAchievmentUser2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblError;
    }
}