namespace Snap
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
            this.pcCardOne = new System.Windows.Forms.PictureBox();
            this.pcCardTwo = new System.Windows.Forms.PictureBox();
            this.cardImgs = new System.Windows.Forms.ImageList(this.components);
            this.dealTimer = new System.Windows.Forms.Timer(this.components);
            this.lbPlayer1Score = new System.Windows.Forms.Label();
            this.lbPlayer2Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCardTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcCardOne
            // 
            this.pcCardOne.Location = new System.Drawing.Point(13, 13);
            this.pcCardOne.Name = "pcCardOne";
            this.pcCardOne.Size = new System.Drawing.Size(89, 128);
            this.pcCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcCardOne.TabIndex = 0;
            this.pcCardOne.TabStop = false;
            // 
            // pcCardTwo
            // 
            this.pcCardTwo.Location = new System.Drawing.Point(164, 12);
            this.pcCardTwo.Name = "pcCardTwo";
            this.pcCardTwo.Size = new System.Drawing.Size(89, 128);
            this.pcCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcCardTwo.TabIndex = 1;
            this.pcCardTwo.TabStop = false;
            // 
            // cardImgs
            // 
            this.cardImgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardImgs.ImageStream")));
            this.cardImgs.TransparentColor = System.Drawing.Color.Transparent;
            this.cardImgs.Images.SetKeyName(0, "1.png");
            this.cardImgs.Images.SetKeyName(1, "2.png");
            this.cardImgs.Images.SetKeyName(2, "3.png");
            this.cardImgs.Images.SetKeyName(3, "4.png");
            this.cardImgs.Images.SetKeyName(4, "5.png");
            this.cardImgs.Images.SetKeyName(5, "6.png");
            this.cardImgs.Images.SetKeyName(6, "7.png");
            this.cardImgs.Images.SetKeyName(7, "8.png");
            this.cardImgs.Images.SetKeyName(8, "9.png");
            this.cardImgs.Images.SetKeyName(9, "10.png");
            this.cardImgs.Images.SetKeyName(10, "11.png");
            this.cardImgs.Images.SetKeyName(11, "12.png");
            this.cardImgs.Images.SetKeyName(12, "13.png");
            this.cardImgs.Images.SetKeyName(13, "14.png");
            this.cardImgs.Images.SetKeyName(14, "15.png");
            this.cardImgs.Images.SetKeyName(15, "16.png");
            this.cardImgs.Images.SetKeyName(16, "17.png");
            this.cardImgs.Images.SetKeyName(17, "18.png");
            this.cardImgs.Images.SetKeyName(18, "19.png");
            this.cardImgs.Images.SetKeyName(19, "20.png");
            this.cardImgs.Images.SetKeyName(20, "21.png");
            this.cardImgs.Images.SetKeyName(21, "22.png");
            this.cardImgs.Images.SetKeyName(22, "23.png");
            this.cardImgs.Images.SetKeyName(23, "24.png");
            this.cardImgs.Images.SetKeyName(24, "25.png");
            this.cardImgs.Images.SetKeyName(25, "26.png");
            this.cardImgs.Images.SetKeyName(26, "27.png");
            this.cardImgs.Images.SetKeyName(27, "28.png");
            this.cardImgs.Images.SetKeyName(28, "29.png");
            this.cardImgs.Images.SetKeyName(29, "30.png");
            this.cardImgs.Images.SetKeyName(30, "31.png");
            this.cardImgs.Images.SetKeyName(31, "32.png");
            this.cardImgs.Images.SetKeyName(32, "33.png");
            this.cardImgs.Images.SetKeyName(33, "34.png");
            this.cardImgs.Images.SetKeyName(34, "35.png");
            this.cardImgs.Images.SetKeyName(35, "36.png");
            this.cardImgs.Images.SetKeyName(36, "37.png");
            this.cardImgs.Images.SetKeyName(37, "38.png");
            this.cardImgs.Images.SetKeyName(38, "39.png");
            this.cardImgs.Images.SetKeyName(39, "40.png");
            this.cardImgs.Images.SetKeyName(40, "41.png");
            this.cardImgs.Images.SetKeyName(41, "42.png");
            this.cardImgs.Images.SetKeyName(42, "43.png");
            this.cardImgs.Images.SetKeyName(43, "44.png");
            this.cardImgs.Images.SetKeyName(44, "45.png");
            this.cardImgs.Images.SetKeyName(45, "46.png");
            this.cardImgs.Images.SetKeyName(46, "47.png");
            this.cardImgs.Images.SetKeyName(47, "48.png");
            this.cardImgs.Images.SetKeyName(48, "49.png");
            this.cardImgs.Images.SetKeyName(49, "50.png");
            this.cardImgs.Images.SetKeyName(50, "51.png");
            this.cardImgs.Images.SetKeyName(51, "52.png");
            // 
            // dealTimer
            // 
            this.dealTimer.Tick += new System.EventHandler(this.dealTimer_Tick);
            // 
            // lbPlayer1Score
            // 
            this.lbPlayer1Score.AutoSize = true;
            this.lbPlayer1Score.Location = new System.Drawing.Point(13, 159);
            this.lbPlayer1Score.Name = "lbPlayer1Score";
            this.lbPlayer1Score.Size = new System.Drawing.Size(70, 13);
            this.lbPlayer1Score.TabIndex = 2;
            this.lbPlayer1Score.Text = "Player1Score";
            // 
            // lbPlayer2Score
            // 
            this.lbPlayer2Score.AutoSize = true;
            this.lbPlayer2Score.Location = new System.Drawing.Point(161, 159);
            this.lbPlayer2Score.Name = "lbPlayer2Score";
            this.lbPlayer2Score.Size = new System.Drawing.Size(70, 13);
            this.lbPlayer2Score.TabIndex = 3;
            this.lbPlayer2Score.Text = "Player2Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(265, 241);
            this.Controls.Add(this.lbPlayer2Score);
            this.Controls.Add(this.lbPlayer1Score);
            this.Controls.Add(this.pcCardTwo);
            this.Controls.Add(this.pcCardOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcCardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCardTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcCardOne;
        private System.Windows.Forms.PictureBox pcCardTwo;
        private System.Windows.Forms.ImageList cardImgs;
        private System.Windows.Forms.Timer dealTimer;
        private System.Windows.Forms.Label lbPlayer1Score;
        private System.Windows.Forms.Label lbPlayer2Score;
    }
}

