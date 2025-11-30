using System.Windows.Forms;

namespace BlockWars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel level;

        private Label axis;

        private Label gameTitle;

        private Label timerText;

        private Label playerMovementSpeed;

        private Button playBtn;

        private Label menuGameTitle;

        private Panel menuPanel;

        private PictureBox pictureBox5;

        private PictureBox pictureBox4;

        private PictureBox pictureBox3;

        private PictureBox pictureBox2;

        private PictureBox pictureBox1;

        private Panel panel1;

        private Label label3;

        private Label label2;

        private Label label1;

        private Label highscoreText;

        private Button changePlayerSprite;

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
            this.axis = new System.Windows.Forms.Label();
            this.gameTitle = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuGameTitle = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.playerMovementSpeed = new System.Windows.Forms.Label();
            this.highscoreText = new System.Windows.Forms.Label();
            this.changePlayerSprite = new System.Windows.Forms.Button();
            this.level.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            base.SuspendLayout();
            this.axis.AutoSize = true;
            this.axis.ForeColor = System.Drawing.Color.White;
            this.axis.Location = new System.Drawing.Point(396, 22);
            this.axis.Name = "axis";
            this.axis.Size = new System.Drawing.Size(85, 13);
            this.axis.TabIndex = 1;
            this.axis.Text = "Coordinates: x, y";
            this.gameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Segoe UI Light", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.gameTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gameTitle.Location = new System.Drawing.Point(11, 9);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(382, 30);
            this.gameTitle.TabIndex = 1;
            this.gameTitle.Text = "Block Wars — BluDay";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timerText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.timerText.AutoSize = true;
            this.timerText.ForeColor = System.Drawing.Color.White;
            this.timerText.Location = new System.Drawing.Point(916, 22);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(95, 13);
            this.timerText.TabIndex = 2;
            this.timerText.Text = "Score: 0 | Time: 0s";
            this.level.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.level.BackColor = System.Drawing.SystemColors.MenuText;
            this.level.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level.Controls.Add(this.menuPanel);
            this.level.ForeColor = System.Drawing.Color.MidnightBlue;
            this.level.Location = new System.Drawing.Point(16, 46);
            this.level.Margin = new System.Windows.Forms.Padding(0);
            this.level.MaximumSize = new System.Drawing.Size(1024, 1024);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(1019, 450);
            this.level.TabIndex = 0;
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.menuPanel.BackColor = System.Drawing.Color.MediumBlue;
            this.menuPanel.Controls.Add(this.changePlayerSprite);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.menuGameTitle);
            this.menuPanel.Controls.Add(this.playBtn);
            this.menuPanel.Location = new System.Drawing.Point(370, 49);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(293, 358);
            this.menuPanel.TabIndex = 0;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.highscoreText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(17, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 210);
            this.panel1.TabIndex = 8;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Negative Blocks +1P and -2 Speed";
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Positive Blocks +1P and +2 Speed ";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Regular Blocks +1P";
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.BackColor = System.Drawing.Color.Purple;
            this.pictureBox5.Location = new System.Drawing.Point(0, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(0, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox3.Location = new System.Drawing.Point(72, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(36, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(0, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.menuGameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.menuGameTitle.AutoSize = true;
            this.menuGameTitle.Font = new System.Drawing.Font("Segoe UI Light", 20f);
            this.menuGameTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.menuGameTitle.Location = new System.Drawing.Point(65, 11);
            this.menuGameTitle.Name = "menuGameTitle";
            this.menuGameTitle.Size = new System.Drawing.Size(175, 37);
            this.menuGameTitle.TabIndex = 2;
            this.menuGameTitle.Text = "Block Wars 1.0";
            this.playBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.playBtn.BackColor = System.Drawing.Color.Green;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playBtn.Font = new System.Drawing.Font("Segoe UI Light", 13f);
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(17, 274);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(102, 66);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(playBtn_Click);
            this.playerMovementSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.playerMovementSpeed.AutoSize = true;
            this.playerMovementSpeed.ForeColor = System.Drawing.Color.White;
            this.playerMovementSpeed.Location = new System.Drawing.Point(676, 22);
            this.playerMovementSpeed.Name = "playerMovementSpeed";
            this.playerMovementSpeed.Size = new System.Drawing.Size(82, 13);
            this.playerMovementSpeed.TabIndex = 3;
            this.playerMovementSpeed.Text = "Player Speed: 0";
            this.highscoreText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.highscoreText.Font = new System.Drawing.Font("Segoe UI Light", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.highscoreText.ForeColor = System.Drawing.Color.White;
            this.highscoreText.Location = new System.Drawing.Point(17, 0);
            this.highscoreText.Name = "highscoreText";
            this.highscoreText.Size = new System.Drawing.Size(227, 48);
            this.highscoreText.TabIndex = 11;
            this.highscoreText.Text = "Highscore: 0 Points                 Time Highscore: 0 Seconds";
            this.changePlayerSprite.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.changePlayerSprite.BackColor = System.Drawing.Color.Green;
            this.changePlayerSprite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePlayerSprite.Font = new System.Drawing.Font("Segoe UI Light", 13f);
            this.changePlayerSprite.ForeColor = System.Drawing.Color.White;
            this.changePlayerSprite.Location = new System.Drawing.Point(134, 274);
            this.changePlayerSprite.Name = "changePlayerSprite";
            this.changePlayerSprite.Size = new System.Drawing.Size(142, 66);
            this.changePlayerSprite.TabIndex = 9;
            this.changePlayerSprite.Text = "Change player sprite";
            this.changePlayerSprite.UseVisualStyleBackColor = false;
            this.changePlayerSprite.Click += new System.EventHandler(changePlayerSprite_Click);
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            base.ClientSize = new System.Drawing.Size(1054, 512);
            base.Controls.Add(this.level);
            base.Controls.Add(this.playerMovementSpeed);
            base.Controls.Add(this.timerText);
            base.Controls.Add(this.axis);
            base.Controls.Add(this.gameTitle);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Form1";
            base.ShowIcon = false;
            base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block Wars";
            base.TopMost = true;
            base.Load += new System.EventHandler(Form1_Load);
            base.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            this.level.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
    }
}

