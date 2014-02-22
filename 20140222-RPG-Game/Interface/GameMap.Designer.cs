namespace Interface
{
    partial class GameMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMap));
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barHealth = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.barEnergy = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.barTonus = new System.Windows.Forms.ProgressBar();
            this.bRest = new System.Windows.Forms.Button();
            this.bMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMap.BackgroundImage")));
            this.pbMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMap.Location = new System.Drawing.Point(10, 10);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(960, 720);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            this.pbMap.Click += new System.EventHandler(this.Map_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.barHealth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.barEnergy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.barTonus);
            this.panel1.Controls.Add(this.bRest);
            this.panel1.Controls.Add(this.bMove);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(967, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 336);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "6/6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Moves:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Health:";
            // 
            // barHealth
            // 
            this.barHealth.Location = new System.Drawing.Point(18, 71);
            this.barHealth.Name = "barHealth";
            this.barHealth.Size = new System.Drawing.Size(157, 23);
            this.barHealth.TabIndex = 8;
            this.barHealth.Value = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Energy:";
            // 
            // barEnergy
            // 
            this.barEnergy.Location = new System.Drawing.Point(18, 125);
            this.barEnergy.Name = "barEnergy";
            this.barEnergy.Size = new System.Drawing.Size(157, 23);
            this.barEnergy.TabIndex = 6;
            this.barEnergy.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tonus:";
            // 
            // barTonus
            // 
            this.barTonus.Location = new System.Drawing.Point(18, 183);
            this.barTonus.Name = "barTonus";
            this.barTonus.Size = new System.Drawing.Size(157, 23);
            this.barTonus.TabIndex = 4;
            this.barTonus.Value = 100;
            // 
            // bRest
            // 
            this.bRest.Location = new System.Drawing.Point(110, 292);
            this.bRest.Name = "bRest";
            this.bRest.Size = new System.Drawing.Size(67, 32);
            this.bRest.TabIndex = 3;
            this.bRest.Text = "Rest";
            this.bRest.UseVisualStyleBackColor = true;
            // 
            // bMove
            // 
            this.bMove.Location = new System.Drawing.Point(18, 292);
            this.bMove.Name = "bMove";
            this.bMove.Size = new System.Drawing.Size(67, 32);
            this.bMove.TabIndex = 1;
            this.bMove.Text = "Move";
            this.bMove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controls";
            // 
            // GameMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1162, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMap);
            this.Name = "GameMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Welcome to our world";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar barHealth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar barEnergy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar barTonus;
        private System.Windows.Forms.Button bRest;
        private System.Windows.Forms.Button bMove;
    }
}