namespace Interface
{
    partial class MainMenu
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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bLoadGame = new System.Windows.Forms.Button();
            this.bOptions = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bMusicSwitch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainMenu.Location = new System.Drawing.Point(563, 131);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(105, 24);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(561, 188);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(107, 36);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "START";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // bLoadGame
            // 
            this.bLoadGame.Location = new System.Drawing.Point(561, 243);
            this.bLoadGame.Name = "bLoadGame";
            this.bLoadGame.Size = new System.Drawing.Size(107, 36);
            this.bLoadGame.TabIndex = 2;
            this.bLoadGame.Text = "Load game";
            this.bLoadGame.UseVisualStyleBackColor = true;
            this.bLoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // bOptions
            // 
            this.bOptions.Location = new System.Drawing.Point(561, 295);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(107, 36);
            this.bOptions.TabIndex = 3;
            this.bOptions.Text = "Options";
            this.bOptions.UseVisualStyleBackColor = true;
            this.bOptions.Click += new System.EventHandler(this.Options_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(561, 347);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(107, 36);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "EXIT";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bMusicSwitch
            // 
            this.bMusicSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.bMusicSwitch.AutoSize = true;
            this.bMusicSwitch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMusicSwitch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMusicSwitch.Location = new System.Drawing.Point(13, 13);
            this.bMusicSwitch.Name = "bMusicSwitch";
            this.bMusicSwitch.Size = new System.Drawing.Size(93, 24);
            this.bMusicSwitch.TabIndex = 5;
            this.bMusicSwitch.Text = "Music On / Off";
            this.bMusicSwitch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bMusicSwitch.UseVisualStyleBackColor = false;
            this.bMusicSwitch.CheckedChanged += new System.EventHandler(this.MusicSwitch_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Interface.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(1118, 546);
            this.Controls.Add(this.bMusicSwitch);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOptions);
            this.Controls.Add(this.bLoadGame);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lblMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bLoadGame;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.CheckBox bMusicSwitch;

    }
}

