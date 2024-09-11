namespace AstroBlast
{
    partial class AstroBlast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroBlast));
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblStart = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.picAlien = new System.Windows.Forms.PictureBox();
            this.picGas = new System.Windows.Forms.PictureBox();
            this.picRocket = new System.Windows.Forms.PictureBox();
            this.picTopSat = new System.Windows.Forms.PictureBox();
            this.picBotSat = new System.Windows.Forms.PictureBox();
            this.picOTopSat = new System.Windows.Forms.PictureBox();
            this.picBossAlien = new System.Windows.Forms.PictureBox();
            this.picEnergy1 = new System.Windows.Forms.PictureBox();
            this.picEnergy2 = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOTopSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnergy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnergy2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(120, 158);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(417, 78);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Press ENTER to start!\r\nPress M for instructions!";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGas.ForeColor = System.Drawing.Color.White;
            this.lblGas.Location = new System.Drawing.Point(486, 9);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(52, 20);
            this.lblGas.TabIndex = 6;
            this.lblGas.Text = "Gas: ";
            this.lblGas.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(106, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 20);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: ";
            this.lblScore.Visible = false;
            // 
            // picAlien
            // 
            this.picAlien.Image = global::AstroBlast.Resource1.Alien;
            this.picAlien.Location = new System.Drawing.Point(450, 51);
            this.picAlien.Name = "picAlien";
            this.picAlien.Size = new System.Drawing.Size(121, 53);
            this.picAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlien.TabIndex = 9;
            this.picAlien.TabStop = false;
            this.picAlien.Visible = false;
            // 
            // picGas
            // 
            this.picGas.Image = ((System.Drawing.Image)(resources.GetObject("picGas.Image")));
            this.picGas.Location = new System.Drawing.Point(419, 306);
            this.picGas.Name = "picGas";
            this.picGas.Size = new System.Drawing.Size(41, 48);
            this.picGas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGas.TabIndex = 5;
            this.picGas.TabStop = false;
            this.picGas.Visible = false;
            // 
            // picRocket
            // 
            this.picRocket.BackColor = System.Drawing.Color.Transparent;
            this.picRocket.Image = ((System.Drawing.Image)(resources.GetObject("picRocket.Image")));
            this.picRocket.Location = new System.Drawing.Point(66, 173);
            this.picRocket.Name = "picRocket";
            this.picRocket.Size = new System.Drawing.Size(109, 46);
            this.picRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRocket.TabIndex = 1;
            this.picRocket.TabStop = false;
            this.picRocket.Visible = false;
            // 
            // picTopSat
            // 
            this.picTopSat.BackColor = System.Drawing.Color.Transparent;
            this.picTopSat.Image = ((System.Drawing.Image)(resources.GetObject("picTopSat.Image")));
            this.picTopSat.Location = new System.Drawing.Point(302, -178);
            this.picTopSat.Name = "picTopSat";
            this.picTopSat.Size = new System.Drawing.Size(71, 322);
            this.picTopSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopSat.TabIndex = 4;
            this.picTopSat.TabStop = false;
            this.picTopSat.Visible = false;
            // 
            // picBotSat
            // 
            this.picBotSat.BackColor = System.Drawing.Color.Transparent;
            this.picBotSat.Image = ((System.Drawing.Image)(resources.GetObject("picBotSat.Image")));
            this.picBotSat.Location = new System.Drawing.Point(255, 253);
            this.picBotSat.Name = "picBotSat";
            this.picBotSat.Size = new System.Drawing.Size(72, 298);
            this.picBotSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBotSat.TabIndex = 3;
            this.picBotSat.TabStop = false;
            this.picBotSat.Visible = false;
            // 
            // picOTopSat
            // 
            this.picOTopSat.Image = ((System.Drawing.Image)(resources.GetObject("picOTopSat.Image")));
            this.picOTopSat.Location = new System.Drawing.Point(301, -184);
            this.picOTopSat.Name = "picOTopSat";
            this.picOTopSat.Size = new System.Drawing.Size(168, 328);
            this.picOTopSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOTopSat.TabIndex = 8;
            this.picOTopSat.TabStop = false;
            this.picOTopSat.Visible = false;
            // 
            // picBossAlien
            // 
            this.picBossAlien.Image = global::AstroBlast.Resource1.BossAlien;
            this.picBossAlien.Location = new System.Drawing.Point(839, 107);
            this.picBossAlien.Name = "picBossAlien";
            this.picBossAlien.Size = new System.Drawing.Size(322, 157);
            this.picBossAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBossAlien.TabIndex = 10;
            this.picBossAlien.TabStop = false;
            this.picBossAlien.Visible = false;
            // 
            // picEnergy1
            // 
            this.picEnergy1.Image = global::AstroBlast.Resource1.Red_Square;
            this.picEnergy1.Location = new System.Drawing.Point(861, 196);
            this.picEnergy1.Name = "picEnergy1";
            this.picEnergy1.Size = new System.Drawing.Size(17, 16);
            this.picEnergy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnergy1.TabIndex = 11;
            this.picEnergy1.TabStop = false;
            this.picEnergy1.Visible = false;
            // 
            // picEnergy2
            // 
            this.picEnergy2.Image = global::AstroBlast.Resource1.Red_Square;
            this.picEnergy2.Location = new System.Drawing.Point(930, 215);
            this.picEnergy2.Name = "picEnergy2";
            this.picEnergy2.Size = new System.Drawing.Size(17, 16);
            this.picEnergy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnergy2.TabIndex = 12;
            this.picEnergy2.TabStop = false;
            this.picEnergy2.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(487, 347);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(530, 224);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            this.lblInstructions.Visible = false;
            // 
            // AstroBlast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.picEnergy2);
            this.Controls.Add(this.picEnergy1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picRocket);
            this.Controls.Add(this.picBossAlien);
            this.Controls.Add(this.picGas);
            this.Controls.Add(this.picAlien);
            this.Controls.Add(this.picTopSat);
            this.Controls.Add(this.picOTopSat);
            this.Controls.Add(this.picBotSat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AstroBlast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AstroBlast_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AstroBlast_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOTopSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnergy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnergy2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox picRocket;
        private System.Windows.Forms.PictureBox picBotSat;
        private System.Windows.Forms.PictureBox picTopSat;
        private System.Windows.Forms.PictureBox picGas;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picOTopSat;
        private System.Windows.Forms.PictureBox picAlien;
        private System.Windows.Forms.PictureBox picBossAlien;
        private System.Windows.Forms.PictureBox picEnergy1;
        private System.Windows.Forms.PictureBox picEnergy2;
        private System.Windows.Forms.Label lblInstructions;
    }
}

