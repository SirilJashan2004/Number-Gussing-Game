namespace NumberGussingGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblMinAttempts = new System.Windows.Forms.Label();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.lblCurrentAttempts = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.btnPlayerList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Showcard Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(811, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(167, 35);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblMinAttempts
            // 
            this.lblMinAttempts.AutoSize = true;
            this.lblMinAttempts.Font = new System.Drawing.Font("Showcard Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAttempts.Location = new System.Drawing.Point(664, 127);
            this.lblMinAttempts.Name = "lblMinAttempts";
            this.lblMinAttempts.Size = new System.Drawing.Size(325, 35);
            this.lblMinAttempts.TabIndex = 1;
            this.lblMinAttempts.Text = "Minimum Attempts: ";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Font = new System.Drawing.Font("Showcard Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLogin.Location = new System.Drawing.Point(793, 78);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(196, 35);
            this.lblLastLogin.TabIndex = 2;
            this.lblLastLogin.Text = "Last Login: ";
            // 
            // lblCurrentAttempts
            // 
            this.lblCurrentAttempts.AutoSize = true;
            this.lblCurrentAttempts.Font = new System.Drawing.Font("Showcard Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAttempts.Location = new System.Drawing.Point(513, 461);
            this.lblCurrentAttempts.Name = "lblCurrentAttempts";
            this.lblCurrentAttempts.Size = new System.Drawing.Size(426, 35);
            this.lblCurrentAttempts.TabIndex = 3;
            this.lblCurrentAttempts.Text = "Current Game Attempts: 0";
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Showcard Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(546, 394);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(347, 42);
            this.txtGuess.TabIndex = 5;
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.Font = new System.Drawing.Font("Showcard Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitGuess.Location = new System.Drawing.Point(364, 519);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(406, 63);
            this.btnSubmitGuess.TabIndex = 6;
            this.btnSubmitGuess.Text = "Submit Guess";
            this.btnSubmitGuess.UseVisualStyleBackColor = true;
            this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Font = new System.Drawing.Font("Showcard Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.Location = new System.Drawing.Point(839, 520);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(314, 60);
            this.btnRestartGame.TabIndex = 7;
            this.btnRestartGame.Text = "Restart";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // btnPlayerList
            // 
            this.btnPlayerList.Font = new System.Drawing.Font("Showcard Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerList.Location = new System.Drawing.Point(50, 43);
            this.btnPlayerList.Name = "btnPlayerList";
            this.btnPlayerList.Size = new System.Drawing.Size(155, 87);
            this.btnPlayerList.TabIndex = 8;
            this.btnPlayerList.Text = "Players Details";
            this.btnPlayerList.UseVisualStyleBackColor = true;
            this.btnPlayerList.Click += new System.EventHandler(this.btnPlayerList_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1441, 641);
            this.Controls.Add(this.btnPlayerList);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.btnSubmitGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblCurrentAttempts);
            this.Controls.Add(this.lblLastLogin);
            this.Controls.Add(this.lblMinAttempts);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMinAttempts;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Label lblCurrentAttempts;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button btnPlayerList;
    }
}