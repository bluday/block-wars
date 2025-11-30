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
            this.changePlayerSprite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.highscoreText = new System.Windows.Forms.Label();
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
            this.level.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axis
            // 
            this.axis.AutoSize = true;
            this.axis.ForeColor = System.Drawing.Color.White;
            this.axis.Location = new System.Drawing.Point(594, 34);
            this.axis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis.Name = "axis";
            this.axis.Size = new System.Drawing.Size(125, 20);
            this.axis.TabIndex = 1;
            this.axis.Text = "Coordinates: x, y";
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gameTitle.Location = new System.Drawing.Point(16, 14);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(309, 45);
            this.gameTitle.TabIndex = 1;
            this.gameTitle.Text = "Block Wars — BluDay";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerText
            // 
            this.timerText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerText.AutoSize = true;
            this.timerText.ForeColor = System.Drawing.Color.White;
            this.timerText.Location = new System.Drawing.Point(1374, 34);
            this.timerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(140, 20);
            this.timerText.TabIndex = 2;
            this.timerText.Text = "Score: 0 | Time: 0s";
            // 
            // level
            // 
            this.level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.level.BackColor = System.Drawing.SystemColors.MenuText;
            this.level.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level.Controls.Add(this.menuPanel);
            this.level.ForeColor = System.Drawing.Color.MidnightBlue;
            this.level.Location = new System.Drawing.Point(24, 71);
            this.level.Margin = new System.Windows.Forms.Padding(0);
            this.level.MaximumSize = new System.Drawing.Size(1536, 1575);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(1528, 692);
            this.level.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.MediumBlue;
            this.menuPanel.Controls.Add(this.changePlayerSprite);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.menuGameTitle);
            this.menuPanel.Controls.Add(this.playBtn);
            this.menuPanel.Location = new System.Drawing.Point(555, 75);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(440, 551);
            this.menuPanel.TabIndex = 0;
            // 
            // changePlayerSprite
            // 
            this.changePlayerSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changePlayerSprite.BackColor = System.Drawing.Color.Green;
            this.changePlayerSprite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePlayerSprite.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.changePlayerSprite.ForeColor = System.Drawing.Color.White;
            this.changePlayerSprite.Location = new System.Drawing.Point(201, 422);
            this.changePlayerSprite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changePlayerSprite.Name = "changePlayerSprite";
            this.changePlayerSprite.Size = new System.Drawing.Size(213, 102);
            this.changePlayerSprite.TabIndex = 9;
            this.changePlayerSprite.Text = "Change player sprite";
            this.changePlayerSprite.UseVisualStyleBackColor = false;
            this.changePlayerSprite.Click += new System.EventHandler(this.changePlayerSprite_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.highscoreText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(26, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 323);
            this.panel1.TabIndex = 8;
            // 
            // highscoreText
            // 
            this.highscoreText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highscoreText.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreText.ForeColor = System.Drawing.Color.White;
            this.highscoreText.Location = new System.Drawing.Point(26, 0);
            this.highscoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highscoreText.Name = "highscoreText";
            this.highscoreText.Size = new System.Drawing.Size(340, 74);
            this.highscoreText.TabIndex = 11;
            this.highscoreText.Text = "Highscore: 0 Points                 Time Highscore: 0 Seconds";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Negative Blocks +1P and -2 Speed";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Positive Blocks +1P and +2 Speed ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Regular Blocks +1P";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.BackColor = System.Drawing.Color.Purple;
            this.pictureBox5.Location = new System.Drawing.Point(0, 248);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 46);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(0, 174);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 46);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox3.Location = new System.Drawing.Point(108, 100);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 46);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(54, 100);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 46);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuGameTitle
            // 
            this.menuGameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuGameTitle.AutoSize = true;
            this.menuGameTitle.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.menuGameTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.menuGameTitle.Location = new System.Drawing.Point(98, 17);
            this.menuGameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuGameTitle.Name = "menuGameTitle";
            this.menuGameTitle.Size = new System.Drawing.Size(260, 54);
            this.menuGameTitle.TabIndex = 2;
            this.menuGameTitle.Text = "Block Wars 1.0";
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playBtn.BackColor = System.Drawing.Color.Green;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playBtn.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(26, 422);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(153, 102);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // playerMovementSpeed
            // 
            this.playerMovementSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerMovementSpeed.AutoSize = true;
            this.playerMovementSpeed.ForeColor = System.Drawing.Color.White;
            this.playerMovementSpeed.Location = new System.Drawing.Point(1014, 34);
            this.playerMovementSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerMovementSpeed.Name = "playerMovementSpeed";
            this.playerMovementSpeed.Size = new System.Drawing.Size(120, 20);
            this.playerMovementSpeed.TabIndex = 3;
            this.playerMovementSpeed.Text = "Player Speed: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1581, 788);
            this.Controls.Add(this.level);
            this.Controls.Add(this.playerMovementSpeed);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.axis);
            this.Controls.Add(this.gameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block Wars";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.level.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

