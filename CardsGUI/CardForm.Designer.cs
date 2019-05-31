namespace CardsGUI
{
    partial class CardForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rank = new System.Windows.Forms.Label();
            this.Suit = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Suit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            this.SuspendLayout();
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank.Location = new System.Drawing.Point(3, 67);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(36, 39);
            this.Rank.TabIndex = 1;
            this.Rank.Text = "6";
            // 
            // Suit
            // 
            this.Suit.Location = new System.Drawing.Point(3, 3);
            this.Suit.Name = "Suit";
            this.Suit.Size = new System.Drawing.Size(35, 35);
            this.Suit.TabIndex = 2;
            this.Suit.TabStop = false;
            // 
            // Character
            // 
            this.Character.Location = new System.Drawing.Point(3, 42);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(84, 78);
            this.Character.TabIndex = 3;
            this.Character.TabStop = false;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Suit);
            this.Controls.Add(this.Rank);
            this.Name = "CardForm";
            this.Size = new System.Drawing.Size(90, 120);
            this.Load += new System.EventHandler(this.CardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Suit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.PictureBox Suit;
        private System.Windows.Forms.PictureBox Character;
    }
}
