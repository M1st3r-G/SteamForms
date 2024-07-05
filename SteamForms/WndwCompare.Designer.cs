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
            // 
            // tbxMyself
            // 
            this.tbxMyself.Location = new System.Drawing.Point(85, 107);
            this.tbxMyself.Name = "tbxMyself";
            this.tbxMyself.ReadOnly = true;
            this.tbxMyself.Size = new System.Drawing.Size(215, 20);
            this.tbxMyself.TabIndex = 1;
            // 
            // WndwCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxMyself);
            this.Controls.Add(this.dpdnFriends);
            this.Name = "WndwCompare";
            this.Text = "WndwCompare";
            this.Load += new System.EventHandler(this.WndwCompare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dpdnFriends;
        private System.Windows.Forms.TextBox tbxMyself;
    }
}