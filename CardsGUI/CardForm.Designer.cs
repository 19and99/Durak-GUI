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
            this.CharacterPic = new System.Windows.Forms.PictureBox();
            this.Suit = new System.Windows.Forms.PictureBox();
            this.Rank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suit)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterPic
            // 
            this.CharacterPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterPic.Location = new System.Drawing.Point(3, 3);
            this.CharacterPic.Name = "CharacterPic";
            this.CharacterPic.Size = new System.Drawing.Size(84, 114);
            this.CharacterPic.TabIndex = 3;
            this.CharacterPic.TabStop = false;
            // 
            // Suit
            // 
            this.Suit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Suit.Location = new System.Drawing.Point(3, 3);
            this.Suit.Name = "Suit";
            this.Suit.Size = new System.Drawing.Size(24, 24);
            this.Suit.TabIndex = 4;
            this.Suit.TabStop = false;
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank.Location = new System.Drawing.Point(19, 40);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(51, 55);
            this.Rank.TabIndex = 5;
            this.Rank.Text = "6";
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.Suit);
            this.Controls.Add(this.CharacterPic);
            this.Name = "CardForm";
            this.Size = new System.Drawing.Size(88, 118);
            this.Load += new System.EventHandler(this.CardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CharacterPic;
        private System.Windows.Forms.PictureBox Suit;
        private System.Windows.Forms.Label Rank;
    }
}
