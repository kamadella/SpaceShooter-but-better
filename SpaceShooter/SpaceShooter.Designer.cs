namespace SpaceShooter
{
    partial class SpaceShooter
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelLife = new System.Windows.Forms.Label();
            this.LifeBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelScore
            // 
            this.LabelScore.BackColor = System.Drawing.Color.Black;
            this.LabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelScore.ForeColor = System.Drawing.Color.White;
            this.LabelScore.Location = new System.Drawing.Point(12, 9);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(130, 35);
            this.LabelScore.TabIndex = 0;
            this.LabelScore.Text = "Punkty: 0";
            // 
            // LabelLife
            // 
            this.LabelLife.BackColor = System.Drawing.Color.Black;
            this.LabelLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelLife.ForeColor = System.Drawing.Color.White;
            this.LabelLife.Location = new System.Drawing.Point(319, 9);
            this.LabelLife.Name = "LabelLife";
            this.LabelLife.Size = new System.Drawing.Size(86, 35);
            this.LabelLife.TabIndex = 1;
            this.LabelLife.Text = "Życie:";
            // 
            // LifeBar
            // 
            this.LifeBar.Location = new System.Drawing.Point(411, 12);
            this.LifeBar.Name = "LifeBar";
            this.LifeBar.Size = new System.Drawing.Size(155, 23);
            this.LifeBar.TabIndex = 2;
            this.LifeBar.Value = 100;
            // 
            // player
            // 
            this.player.Image = global::SpaceShooter.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(259, 749);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(75, 75);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTick);
            // 
            // SpaceShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Controls.Add(this.player);
            this.Controls.Add(this.LifeBar);
            this.Controls.Add(this.LabelLife);
            this.Controls.Add(this.LabelScore);
            this.Name = "SpaceShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.isKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelLife;
        private System.Windows.Forms.ProgressBar LifeBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
    }
}

