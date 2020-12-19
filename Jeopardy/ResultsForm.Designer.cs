namespace JeopardyGame
{
    partial class ResultsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentResults = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridGames = new System.Windows.Forms.DataGridView();
            this.GameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGames)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over!";
            // 
            // lblCurrentResults
            // 
            this.lblCurrentResults.AutoSize = true;
            this.lblCurrentResults.Location = new System.Drawing.Point(39, 119);
            this.lblCurrentResults.Name = "lblCurrentResults";
            this.lblCurrentResults.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentResults.TabIndex = 1;
            this.lblCurrentResults.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Game Results:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Past Games:";
            // 
            // gridGames
            // 
            this.gridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameDate,
            this.winnerName,
            this.winnerScore,
            this.secondPlace,
            this.thirdPlace});
            this.gridGames.Location = new System.Drawing.Point(12, 224);
            this.gridGames.Name = "gridGames";
            this.gridGames.Size = new System.Drawing.Size(550, 92);
            this.gridGames.TabIndex = 5;
            // 
            // GameDate
            // 
            this.GameDate.HeaderText = "Game Date";
            this.GameDate.Name = "GameDate";
            // 
            // winnerName
            // 
            this.winnerName.HeaderText = "Winner Name";
            this.winnerName.Name = "winnerName";
            // 
            // winnerScore
            // 
            this.winnerScore.HeaderText = "Winner Score";
            this.winnerScore.Name = "winnerScore";
            // 
            // secondPlace
            // 
            this.secondPlace.HeaderText = "Second Place";
            this.secondPlace.Name = "secondPlace";
            // 
            // thirdPlace
            // 
            this.thirdPlace.HeaderText = "Third Place";
            this.thirdPlace.Name = "thirdPlace";
            // 
            // btNewGame
            // 
            this.btNewGame.Location = new System.Drawing.Point(487, 28);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(75, 23);
            this.btNewGame.TabIndex = 6;
            this.btNewGame.Text = "New Game";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(584, 484);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.gridGames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentResults);
            this.Controls.Add(this.label1);
            this.Name = "ResultsForm";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.gridGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn winnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn winnerScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdPlace;
        private System.Windows.Forms.Button btNewGame;
    }
}