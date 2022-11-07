namespace CardGame2022
{
    partial class NumberPlayer
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
            this.NumberOfPlayer = new System.Windows.Forms.NumericUpDown();
            this.AskingNP = new System.Windows.Forms.Label();
            this.PlayerNumberValidation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfPlayer
            // 
            this.NumberOfPlayer.Location = new System.Drawing.Point(370, 98);
            this.NumberOfPlayer.Name = "NumberOfPlayer";
            this.NumberOfPlayer.Size = new System.Drawing.Size(33, 20);
            this.NumberOfPlayer.TabIndex = 0;
            this.NumberOfPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AskingNP
            // 
            this.AskingNP.AutoSize = true;
            this.AskingNP.Location = new System.Drawing.Point(308, 25);
            this.AskingNP.Name = "AskingNP";
            this.AskingNP.Size = new System.Drawing.Size(178, 13);
            this.AskingNP.TabIndex = 1;
            this.AskingNP.Text = "A combien de joueurs voulez jouer ?";
            // 
            // PlayerNumberValidation
            // 
            this.PlayerNumberValidation.Location = new System.Drawing.Point(355, 227);
            this.PlayerNumberValidation.Name = "PlayerNumberValidation";
            this.PlayerNumberValidation.Size = new System.Drawing.Size(75, 23);
            this.PlayerNumberValidation.TabIndex = 2;
            this.PlayerNumberValidation.Text = "Valider";
            this.PlayerNumberValidation.UseVisualStyleBackColor = true;
            this.PlayerNumberValidation.Click += new System.EventHandler(this.PlayerNumberValidation_Click);
            // 
            // NumberPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerNumberValidation);
            this.Controls.Add(this.AskingNP);
            this.Controls.Add(this.NumberOfPlayer);
            this.Name = "NumberPlayer";
            this.Text = "NumberPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumberOfPlayer;
        private System.Windows.Forms.Label AskingNP;
        private System.Windows.Forms.Button PlayerNumberValidation;
    }
}