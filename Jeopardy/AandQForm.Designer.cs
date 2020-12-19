namespace JeopardyGame
{
    partial class AandQForm
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtBxResponse = new System.Windows.Forms.TextBox();
            this.cmBoxPlayers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(36, 31);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(70, 26);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "label1";
            // 
            // txtBxResponse
            // 
            this.txtBxResponse.Location = new System.Drawing.Point(41, 199);
            this.txtBxResponse.Name = "txtBxResponse";
            this.txtBxResponse.Size = new System.Drawing.Size(450, 20);
            this.txtBxResponse.TabIndex = 2;
            // 
            // cmBoxPlayers
            // 
            this.cmBoxPlayers.FormattingEnabled = true;
            this.cmBoxPlayers.Location = new System.Drawing.Point(41, 128);
            this.cmBoxPlayers.Name = "cmBoxPlayers";
            this.cmBoxPlayers.Size = new System.Drawing.Size(121, 21);
            this.cmBoxPlayers.TabIndex = 3;
            this.cmBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.cmBoxPlayers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Which Player Is Answering:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player\'s Response:";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(41, 257);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(97, 23);
            this.btSubmit.TabIndex = 6;
            this.btSubmit.Text = "Submit Guess";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // AandQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(541, 311);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBoxPlayers);
            this.Controls.Add(this.txtBxResponse);
            this.Controls.Add(this.lblAnswer);
            this.Name = "AandQForm";
            this.Text = "Jeopardy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtBxResponse;
        private System.Windows.Forms.ComboBox cmBoxPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSubmit;
    }
}