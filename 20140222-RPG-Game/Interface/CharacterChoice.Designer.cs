namespace Interface
{
    partial class CharacterChoice
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
            this.picArcher = new System.Windows.Forms.PictureBox();
            this.cbMage = new System.Windows.Forms.CheckBox();
            this.cbKnight = new System.Windows.Forms.CheckBox();
            this.cbArcher = new System.Windows.Forms.CheckBox();
            this.picMage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picKnight = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.bDone = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bMusicChoice = new System.Windows.Forms.CheckBox();
            this.picAmazon = new System.Windows.Forms.PictureBox();
            this.cbAmazon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmazon)).BeginInit();
            this.SuspendLayout();
            // 
            // picArcher
            // 
            this.picArcher.BackColor = System.Drawing.Color.Transparent;
            this.picArcher.BackgroundImage = global::Interface.Properties.Resources.Archer;
            this.picArcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArcher.Location = new System.Drawing.Point(644, 237);
            this.picArcher.Name = "picArcher";
            this.picArcher.Size = new System.Drawing.Size(80, 137);
            this.picArcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picArcher.TabIndex = 2;
            this.picArcher.TabStop = false;
            this.picArcher.Click += new System.EventHandler(this.PicArcher_Click);
            // 
            // cbMage
            // 
            this.cbMage.AutoSize = true;
            this.cbMage.BackColor = System.Drawing.Color.Transparent;
            this.cbMage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbMage.Location = new System.Drawing.Point(227, 189);
            this.cbMage.Name = "cbMage";
            this.cbMage.Size = new System.Drawing.Size(72, 24);
            this.cbMage.TabIndex = 3;
            this.cbMage.Text = "Mage";
            this.cbMage.UseVisualStyleBackColor = false;
            this.cbMage.CheckedChanged += new System.EventHandler(this.Mage_CheckedChanged);
            // 
            // cbKnight
            // 
            this.cbKnight.AutoSize = true;
            this.cbKnight.BackColor = System.Drawing.Color.Transparent;
            this.cbKnight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbKnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbKnight.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbKnight.Location = new System.Drawing.Point(441, 189);
            this.cbKnight.Name = "cbKnight";
            this.cbKnight.Size = new System.Drawing.Size(79, 24);
            this.cbKnight.TabIndex = 4;
            this.cbKnight.Text = "Knight";
            this.cbKnight.UseVisualStyleBackColor = false;
            this.cbKnight.CheckedChanged += new System.EventHandler(this.Knight_CheckedChanged);
            // 
            // cbArcher
            // 
            this.cbArcher.AutoSize = true;
            this.cbArcher.BackColor = System.Drawing.Color.Transparent;
            this.cbArcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbArcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbArcher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbArcher.Location = new System.Drawing.Point(643, 189);
            this.cbArcher.Name = "cbArcher";
            this.cbArcher.Size = new System.Drawing.Size(81, 24);
            this.cbArcher.TabIndex = 5;
            this.cbArcher.Text = "Archer";
            this.cbArcher.UseVisualStyleBackColor = false;
            this.cbArcher.CheckedChanged += new System.EventHandler(this.Archer_CheckedChanged);
            // 
            // picMage
            // 
            this.picMage.BackColor = System.Drawing.Color.Transparent;
            this.picMage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMage.Image = global::Interface.Properties.Resources.Sorcerer;
            this.picMage.Location = new System.Drawing.Point(227, 237);
            this.picMage.Name = "picMage";
            this.picMage.Size = new System.Drawing.Size(80, 134);
            this.picMage.TabIndex = 6;
            this.picMage.TabStop = false;
            this.picMage.Click += new System.EventHandler(this.PicMage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // picKnight
            // 
            this.picKnight.BackColor = System.Drawing.Color.Transparent;
            this.picKnight.BackgroundImage = global::Interface.Properties.Resources.Knight_t;
            this.picKnight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picKnight.Location = new System.Drawing.Point(444, 237);
            this.picKnight.Name = "picKnight";
            this.picKnight.Size = new System.Drawing.Size(76, 137);
            this.picKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picKnight.TabIndex = 8;
            this.picKnight.TabStop = false;
            this.picKnight.Click += new System.EventHandler(this.PicKnight_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarning.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWarning.Location = new System.Drawing.Point(320, 88);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(482, 37);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "Choose your character wisely!";
            // 
            // bDone
            // 
            this.bDone.BackColor = System.Drawing.Color.Transparent;
            this.bDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDone.Location = new System.Drawing.Point(494, 449);
            this.bDone.Name = "bDone";
            this.bDone.Size = new System.Drawing.Size(75, 23);
            this.bDone.TabIndex = 10;
            this.bDone.Text = "Done";
            this.bDone.UseVisualStyleBackColor = false;
            this.bDone.Click += new System.EventHandler(this.Done_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Location = new System.Drawing.Point(603, 449);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // bMusicChoice
            // 
            this.bMusicChoice.Appearance = System.Windows.Forms.Appearance.Button;
            this.bMusicChoice.AutoSize = true;
            this.bMusicChoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMusicChoice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMusicChoice.Location = new System.Drawing.Point(12, 11);
            this.bMusicChoice.Name = "bMusicChoice";
            this.bMusicChoice.Size = new System.Drawing.Size(93, 24);
            this.bMusicChoice.TabIndex = 12;
            this.bMusicChoice.Text = "Music On / Off";
            this.bMusicChoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bMusicChoice.UseVisualStyleBackColor = false;
            this.bMusicChoice.CheckedChanged += new System.EventHandler(this.MusicChoice_CheckedChanged);
            // 
            // picAmazon
            // 
            this.picAmazon.BackColor = System.Drawing.Color.Transparent;
            this.picAmazon.BackgroundImage = global::Interface.Properties.Resources.Amazon_t;
            this.picAmazon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAmazon.Location = new System.Drawing.Point(829, 234);
            this.picAmazon.Name = "picAmazon";
            this.picAmazon.Size = new System.Drawing.Size(80, 137);
            this.picAmazon.TabIndex = 13;
            this.picAmazon.TabStop = false;
            this.picAmazon.Click += new System.EventHandler(this.PicAmazon_Click);
            // 
            // cbAmazon
            // 
            this.cbAmazon.AutoSize = true;
            this.cbAmazon.BackColor = System.Drawing.Color.Transparent;
            this.cbAmazon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAmazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAmazon.ForeColor = System.Drawing.Color.PeachPuff;
            this.cbAmazon.Location = new System.Drawing.Point(828, 189);
            this.cbAmazon.Name = "cbAmazon";
            this.cbAmazon.Size = new System.Drawing.Size(93, 24);
            this.cbAmazon.TabIndex = 14;
            this.cbAmazon.Text = "Amazon";
            this.cbAmazon.UseVisualStyleBackColor = false;
            this.cbAmazon.CheckedChanged += new System.EventHandler(this.Amazon_CheckedChanged);
            // 
            // CharacterChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interface.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(968, 470);
            this.Controls.Add(this.cbAmazon);
            this.Controls.Add(this.picAmazon);
            this.Controls.Add(this.bMusicChoice);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bDone);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.picKnight);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picMage);
            this.Controls.Add(this.cbArcher);
            this.Controls.Add(this.cbKnight);
            this.Controls.Add(this.cbMage);
            this.Controls.Add(this.picArcher);
            this.Name = "CharacterChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your hero!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CharacterChoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmazon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArcher;
        private System.Windows.Forms.CheckBox cbMage;
        private System.Windows.Forms.CheckBox cbKnight;
        private System.Windows.Forms.CheckBox cbArcher;
        private System.Windows.Forms.PictureBox picMage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picKnight;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button bDone;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.CheckBox bMusicChoice;
        private System.Windows.Forms.PictureBox picAmazon;
        private System.Windows.Forms.CheckBox cbAmazon;
    }
}