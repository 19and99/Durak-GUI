namespace CardsGUI
{
    partial class GameGUI
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
            this.Start = new System.Windows.Forms.Button();
            this.Collect = new System.Windows.Forms.Button();
            this.Bita = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.kozarPic = new System.Windows.Forms.PictureBox();
            this.kolodCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kozarPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(115, 19);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(97, 32);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Collect
            // 
            this.Collect.Location = new System.Drawing.Point(756, 25);
            this.Collect.Name = "Collect";
            this.Collect.Size = new System.Drawing.Size(105, 27);
            this.Collect.TabIndex = 3;
            this.Collect.Text = "Collect";
            this.Collect.UseVisualStyleBackColor = true;
            this.Collect.Click += new System.EventHandler(this.Collect_Click);
            // 
            // Bita
            // 
            this.Bita.Location = new System.Drawing.Point(637, 24);
            this.Bita.Name = "Bita";
            this.Bita.Size = new System.Drawing.Size(105, 27);
            this.Bita.TabIndex = 3;
            this.Bita.Text = "Bita";
            this.Bita.UseVisualStyleBackColor = true;
            this.Bita.Click += new System.EventHandler(this.Bita_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(235, 24);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(367, 25);
            this.Info.TabIndex = 4;
            this.Info.Text = "Press Start button to start a game";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kozarPic
            // 
            this.kozarPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kozarPic.Location = new System.Drawing.Point(13, 63);
            this.kozarPic.Name = "kozarPic";
            this.kozarPic.Size = new System.Drawing.Size(72, 72);
            this.kozarPic.TabIndex = 5;
            this.kozarPic.TabStop = false;
            // 
            // kolodCount
            // 
            this.kolodCount.AutoSize = true;
            this.kolodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolodCount.Location = new System.Drawing.Point(12, 138);
            this.kolodCount.Name = "kolodCount";
            this.kolodCount.Size = new System.Drawing.Size(0, 42);
            this.kolodCount.TabIndex = 6;
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1334, 681);
            this.Controls.Add(this.kolodCount);
            this.Controls.Add(this.kozarPic);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Bita);
            this.Controls.Add(this.Collect);
            this.Controls.Add(this.Start);
            this.Name = "GameGUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kozarPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Collect;
        private System.Windows.Forms.Button Bita;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.PictureBox kozarPic;
        private System.Windows.Forms.Label kolodCount;
    }
}

