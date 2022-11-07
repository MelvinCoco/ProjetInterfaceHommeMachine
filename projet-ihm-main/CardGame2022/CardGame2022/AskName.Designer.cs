namespace CardGame2022
{
    partial class AskName
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
            this.NameValidation = new System.Windows.Forms.Button();
            this.LabelToAskName = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameValidation
            // 
            this.NameValidation.Location = new System.Drawing.Point(343, 280);
            this.NameValidation.Name = "NameValidation";
            this.NameValidation.Size = new System.Drawing.Size(75, 23);
            this.NameValidation.TabIndex = 0;
            this.NameValidation.Text = "Valider";
            this.NameValidation.UseVisualStyleBackColor = true;
            // 
            // LabelToAskName
            // 
            this.LabelToAskName.AutoSize = true;
            this.LabelToAskName.Location = new System.Drawing.Point(273, 110);
            this.LabelToAskName.Name = "LabelToAskName";
            this.LabelToAskName.Size = new System.Drawing.Size(248, 13);
            this.LabelToAskName.TabIndex = 1;
            this.LabelToAskName.Text = "Quel est le nom du premier et du deuxième joueur ?";
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(276, 198);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(100, 20);
            this.Player1Name.TabIndex = 2;
            this.Player1Name.Text = "Player 1...";
            this.Player1Name.TextChanged += new System.EventHandler(this.Player1Name_TextChanged);
            // 
            // Player2Name
            // 
            this.Player2Name.Location = new System.Drawing.Point(421, 198);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(100, 20);
            this.Player2Name.TabIndex = 3;
            this.Player2Name.Text = "Player 2...";
            this.Player2Name.TextChanged += new System.EventHandler(this.Player2Name_TextChanged);
            // 
            // AskName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.LabelToAskName);
            this.Controls.Add(this.NameValidation);
            this.Name = "AskName";
            this.Text = "AskName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NameValidation;
        private System.Windows.Forms.Label LabelToAskName;
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.TextBox Player2Name;
    }
}