namespace JeopardyGame
{
    partial class OptionsForm
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
            this.cmBxNumPlayers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGo = new System.Windows.Forms.Button();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.lblPlayerThree = new System.Windows.Forms.Label();
            this.txtBxPlayer1 = new System.Windows.Forms.TextBox();
            this.txtBxPlayer2 = new System.Windows.Forms.TextBox();
            this.txtBxPlayer3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmBxNumPlayers
            // 
            this.cmBxNumPlayers.FormattingEnabled = true;
            this.cmBxNumPlayers.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmBxNumPlayers.Location = new System.Drawing.Point(210, 112);
            this.cmBxNumPlayers.Name = "cmBxNumPlayers";
            this.cmBxNumPlayers.Size = new System.Drawing.Size(67, 21);
            this.cmBxNumPlayers.TabIndex = 0;
            this.cmBxNumPlayers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Players";
            // 
            // btGo
            // 
            this.btGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGo.Location = new System.Drawing.Point(389, 367);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(50, 40);
            this.btGo.TabIndex = 2;
            this.btGo.Text = "GO";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerOne.Location = new System.Drawing.Point(26, 170);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(111, 20);
            this.lblPlayerOne.TabIndex = 3;
            this.lblPlayerOne.Text = "Player 1 Name";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerTwo.Location = new System.Drawing.Point(26, 220);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(111, 20);
            this.lblPlayerTwo.TabIndex = 6;
            this.lblPlayerTwo.Text = "Player 2 Name";
            this.lblPlayerTwo.Visible = false;
            // 
            // lblPlayerThree
            // 
            this.lblPlayerThree.AutoSize = true;
            this.lblPlayerThree.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerThree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerThree.Location = new System.Drawing.Point(26, 280);
            this.lblPlayerThree.Name = "lblPlayerThree";
            this.lblPlayerThree.Size = new System.Drawing.Size(111, 20);
            this.lblPlayerThree.TabIndex = 7;
            this.lblPlayerThree.Text = "Player 3 Name";
            this.lblPlayerThree.Visible = false;
            // 
            // txtBxPlayer1
            // 
            this.txtBxPlayer1.Location = new System.Drawing.Point(210, 170);
            this.txtBxPlayer1.Name = "txtBxPlayer1";
            this.txtBxPlayer1.Size = new System.Drawing.Size(160, 20);
            this.txtBxPlayer1.TabIndex = 8;
            // 
            // txtBxPlayer2
            // 
            this.txtBxPlayer2.Location = new System.Drawing.Point(210, 222);
            this.txtBxPlayer2.Name = "txtBxPlayer2";
            this.txtBxPlayer2.Size = new System.Drawing.Size(160, 20);
            this.txtBxPlayer2.TabIndex = 9;
            this.txtBxPlayer2.Visible = false;
            // 
            // txtBxPlayer3
            // 
            this.txtBxPlayer3.Location = new System.Drawing.Point(210, 280);
            this.txtBxPlayer3.Name = "txtBxPlayer3";
            this.txtBxPlayer3.Size = new System.Drawing.Size(160, 20);
            this.txtBxPlayer3.TabIndex = 10;
            this.txtBxPlayer3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player Options";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(451, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxPlayer3);
            this.Controls.Add(this.txtBxPlayer2);
            this.Controls.Add(this.txtBxPlayer1);
            this.Controls.Add(this.lblPlayerThree);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBxNumPlayers);
            this.Name = "OptionsForm";
            this.Text = "Jeopardy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBxNumPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Label lblPlayerThree;
        private System.Windows.Forms.TextBox txtBxPlayer1;
        private System.Windows.Forms.TextBox txtBxPlayer2;
        private System.Windows.Forms.TextBox txtBxPlayer3;
        private System.Windows.Forms.Label label2;
    }
}

