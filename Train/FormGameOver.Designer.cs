namespace Train
{
    partial class FormGameOver
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
            this.pictureBoxPlayAgain = new System.Windows.Forms.PictureBox();
            this.pictureBoxGameOver = new System.Windows.Forms.PictureBox();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayAgain
            // 
            this.pictureBoxPlayAgain.Image = global::Train.Properties.Resources.play_again;
            this.pictureBoxPlayAgain.Location = new System.Drawing.Point(56, 144);
            this.pictureBoxPlayAgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPlayAgain.Name = "pictureBoxPlayAgain";
            this.pictureBoxPlayAgain.Size = new System.Drawing.Size(194, 84);
            this.pictureBoxPlayAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayAgain.TabIndex = 1;
            this.pictureBoxPlayAgain.TabStop = false;
            // 
            // pictureBoxGameOver
            // 
            this.pictureBoxGameOver.Image = global::Train.Properties.Resources.game_over2;
            this.pictureBoxGameOver.Location = new System.Drawing.Point(-1, 2);
            this.pictureBoxGameOver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxGameOver.Name = "pictureBoxGameOver";
            this.pictureBoxGameOver.Size = new System.Drawing.Size(314, 170);
            this.pictureBoxGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGameOver.TabIndex = 0;
            this.pictureBoxGameOver.TabStop = false;
            // 
            // buttonYes
            // 
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYes.Location = new System.Drawing.Point(26, 247);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(100, 54);
            this.buttonYes.TabIndex = 2;
            this.buttonYes.Text = "YES";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F);
            this.buttonNo.Location = new System.Drawing.Point(181, 247);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(100, 54);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "NO";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 322);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.pictureBoxPlayAgain);
            this.Controls.Add(this.pictureBoxGameOver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGameOver";
            this.Text = "FormGameOver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameOver;
        private System.Windows.Forms.PictureBox pictureBoxPlayAgain;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
    }
}