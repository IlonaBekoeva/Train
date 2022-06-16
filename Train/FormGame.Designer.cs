namespace Train
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerTrainMove = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxLife = new System.Windows.Forms.PictureBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLife)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTrainMove
            // 
            this.timerTrainMove.Interval = 5;
            this.timerTrainMove.Tick += new System.EventHandler(this.timerTrainMove_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(9, 700);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(170, 80);
            this.buttonStart.TabIndex = 23;
            this.buttonStart.Text = "start game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxLife
            // 
            this.pictureBoxLife.Image = global::Train.Properties.Resources._5;
            this.pictureBoxLife.Location = new System.Drawing.Point(1179, 700);
            this.pictureBoxLife.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLife.Name = "pictureBoxLife";
            this.pictureBoxLife.Size = new System.Drawing.Size(338, 80);
            this.pictureBoxLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLife.TabIndex = 24;
            this.pictureBoxLife.TabStop = false;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(184, 700);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(133, 80);
            this.buttonCheck.TabIndex = 25;
            this.buttonCheck.Text = "check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(321, 700);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 80);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.pictureBoxLife);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGame";
            this.Text = "Поезд";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLife)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerTrainMove;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxLife;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonExit;
    }
}

