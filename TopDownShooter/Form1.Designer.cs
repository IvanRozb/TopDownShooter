namespace TopDownShooter
{
    partial class Form1
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
            this.AmmoAmountText = new System.Windows.Forms.Label();
            this.KillAmountText = new System.Windows.Forms.Label();
            this.HealthText = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Soldier = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier)).BeginInit();
            this.SuspendLayout();
            // 
            // AmmoAmountText
            // 
            this.AmmoAmountText.AutoSize = true;
            this.AmmoAmountText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.AmmoAmountText.Font = new System.Drawing.Font("DejaVu Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmmoAmountText.ForeColor = System.Drawing.Color.White;
            this.AmmoAmountText.Location = new System.Drawing.Point(12, 9);
            this.AmmoAmountText.Name = "AmmoAmountText";
            this.AmmoAmountText.Size = new System.Drawing.Size(115, 26);
            this.AmmoAmountText.TabIndex = 0;
            this.AmmoAmountText.Text = "Ammo: 0";
            // 
            // KillAmountText
            // 
            this.KillAmountText.AutoSize = true;
            this.KillAmountText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.KillAmountText.Font = new System.Drawing.Font("DejaVu Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillAmountText.ForeColor = System.Drawing.Color.White;
            this.KillAmountText.Location = new System.Drawing.Point(422, 9);
            this.KillAmountText.Name = "KillAmountText";
            this.KillAmountText.Size = new System.Drawing.Size(90, 26);
            this.KillAmountText.TabIndex = 1;
            this.KillAmountText.Text = "Kills: 0";
            // 
            // HealthText
            // 
            this.HealthText.AutoSize = true;
            this.HealthText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.HealthText.Font = new System.Drawing.Font("DejaVu Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthText.ForeColor = System.Drawing.Color.White;
            this.HealthText.Location = new System.Drawing.Point(949, 12);
            this.HealthText.Name = "HealthText";
            this.HealthText.Size = new System.Drawing.Size(97, 26);
            this.HealthText.TabIndex = 2;
            this.HealthText.Text = "Health:";
            // 
            // HealthBar
            // 
            this.HealthBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.HealthBar.ForeColor = System.Drawing.Color.DarkBlue;
            this.HealthBar.Location = new System.Drawing.Point(1052, 12);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(198, 26);
            this.HealthBar.TabIndex = 3;
            this.HealthBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.Update);
            // 
            // Soldier
            // 
            this.Soldier.Image = global::TopDownShooter.Properties.Resources.Soldier;
            this.Soldier.Location = new System.Drawing.Point(582, 335);
            this.Soldier.Name = "Soldier";
            this.Soldier.Size = new System.Drawing.Size(100, 150);
            this.Soldier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Soldier.TabIndex = 4;
            this.Soldier.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1262, 1055);
            this.Controls.Add(this.Soldier);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.HealthText);
            this.Controls.Add(this.KillAmountText);
            this.Controls.Add(this.AmmoAmountText);
            this.Name = "Form1";
            this.Text = "TDShooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Soldier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmmoAmountText;
        private System.Windows.Forms.Label KillAmountText;
        private System.Windows.Forms.Label HealthText;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.PictureBox Soldier;
        private System.Windows.Forms.Timer GameTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

