
namespace Witch_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ghost1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ghost3 = new System.Windows.Forms.PictureBox();
            this.ghost2 = new System.Windows.Forms.PictureBox();
            this.ghost4 = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.Label();
            this.gameover2 = new System.Windows.Forms.Label();
            this.reward1 = new System.Windows.Forms.PictureBox();
            this.reward2 = new System.Windows.Forms.PictureBox();
            this.reward3 = new System.Windows.Forms.PictureBox();
            this.points = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(1050, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 554);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox5.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 554);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(33, 451);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(145, 87);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // ghost1
            // 
            this.ghost1.Image = ((System.Drawing.Image)(resources.GetObject("ghost1.Image")));
            this.ghost1.Location = new System.Drawing.Point(786, 334);
            this.ghost1.Name = "ghost1";
            this.ghost1.Size = new System.Drawing.Size(94, 64);
            this.ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost1.TabIndex = 7;
            this.ghost1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(441, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(405, 451);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // ghost3
            // 
            this.ghost3.Image = ((System.Drawing.Image)(resources.GetObject("ghost3.Image")));
            this.ghost3.Location = new System.Drawing.Point(61, 27);
            this.ghost3.Name = "ghost3";
            this.ghost3.Size = new System.Drawing.Size(90, 64);
            this.ghost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost3.TabIndex = 10;
            this.ghost3.TabStop = false;
            // 
            // ghost2
            // 
            this.ghost2.Image = ((System.Drawing.Image)(resources.GetObject("ghost2.Image")));
            this.ghost2.Location = new System.Drawing.Point(197, 141);
            this.ghost2.Name = "ghost2";
            this.ghost2.Size = new System.Drawing.Size(94, 64);
            this.ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost2.TabIndex = 11;
            this.ghost2.TabStop = false;
            // 
            // ghost4
            // 
            this.ghost4.Image = ((System.Drawing.Image)(resources.GetObject("ghost4.Image")));
            this.ghost4.Location = new System.Drawing.Point(851, 12);
            this.ghost4.Name = "ghost4";
            this.ghost4.Size = new System.Drawing.Size(94, 64);
            this.ghost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost4.TabIndex = 12;
            this.ghost4.TabStop = false;
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.Color.Fuchsia;
            this.gameover.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.Location = new System.Drawing.Point(378, 186);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(305, 69);
            this.gameover.TabIndex = 13;
            this.gameover.Text = "OH NO :(";
            this.gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameover2
            // 
            this.gameover2.BackColor = System.Drawing.Color.Fuchsia;
            this.gameover2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover2.Location = new System.Drawing.Point(378, 355);
            this.gameover2.Name = "gameover2";
            this.gameover2.Size = new System.Drawing.Size(305, 69);
            this.gameover2.TabIndex = 14;
            this.gameover2.Text = "THORNS :(";
            this.gameover2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reward1
            // 
            this.reward1.Image = ((System.Drawing.Image)(resources.GetObject("reward1.Image")));
            this.reward1.Location = new System.Drawing.Point(163, 304);
            this.reward1.Name = "reward1";
            this.reward1.Size = new System.Drawing.Size(58, 68);
            this.reward1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reward1.TabIndex = 15;
            this.reward1.TabStop = false;
            // 
            // reward2
            // 
            this.reward2.Image = ((System.Drawing.Image)(resources.GetObject("reward2.Image")));
            this.reward2.Location = new System.Drawing.Point(48, 187);
            this.reward2.Name = "reward2";
            this.reward2.Size = new System.Drawing.Size(58, 68);
            this.reward2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reward2.TabIndex = 16;
            this.reward2.TabStop = false;
            // 
            // reward3
            // 
            this.reward3.Image = ((System.Drawing.Image)(resources.GetObject("reward3.Image")));
            this.reward3.Location = new System.Drawing.Point(802, 171);
            this.reward3.Name = "reward3";
            this.reward3.Size = new System.Drawing.Size(58, 68);
            this.reward3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reward3.TabIndex = 17;
            this.reward3.TabStop = false;
            // 
            // points
            // 
            this.points.BackColor = System.Drawing.Color.Fuchsia;
            this.points.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.Location = new System.Drawing.Point(872, 481);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(154, 60);
            this.points.TabIndex = 18;
            this.points.Text = "POINTS = 0";
            this.points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(492, 97);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(109, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1070, 553);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.points);
            this.Controls.Add(this.reward3);
            this.Controls.Add(this.reward2);
            this.Controls.Add(this.reward1);
            this.Controls.Add(this.gameover2);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.ghost4);
            this.Controls.Add(this.ghost2);
            this.Controls.Add(this.ghost3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ghost1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ghost1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox ghost3;
        private System.Windows.Forms.PictureBox ghost2;
        private System.Windows.Forms.PictureBox ghost4;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label gameover2;
        private System.Windows.Forms.PictureBox reward1;
        private System.Windows.Forms.PictureBox reward2;
        private System.Windows.Forms.PictureBox reward3;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

