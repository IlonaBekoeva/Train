namespace Train
{
    partial class FormMenu
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
            this.buttonOssetian = new System.Windows.Forms.Button();
            this.buttonArmenian = new System.Windows.Forms.Button();
            this.buttonGeorgian = new System.Windows.Forms.Button();
            this.labelLanguageSelection = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOssetian
            // 
            this.buttonOssetian.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOssetian.ForeColor = System.Drawing.Color.Maroon;
            this.buttonOssetian.Location = new System.Drawing.Point(9, 96);
            this.buttonOssetian.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOssetian.Name = "buttonOssetian";
            this.buttonOssetian.Size = new System.Drawing.Size(296, 63);
            this.buttonOssetian.TabIndex = 0;
            this.buttonOssetian.Tag = "";
            this.buttonOssetian.Text = "Осетинский";
            this.buttonOssetian.UseVisualStyleBackColor = true;
            this.buttonOssetian.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // buttonArmenian
            // 
            this.buttonArmenian.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F);
            this.buttonArmenian.ForeColor = System.Drawing.Color.Maroon;
            this.buttonArmenian.Location = new System.Drawing.Point(9, 172);
            this.buttonArmenian.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArmenian.Name = "buttonArmenian";
            this.buttonArmenian.Size = new System.Drawing.Size(296, 63);
            this.buttonArmenian.TabIndex = 1;
            this.buttonArmenian.Text = "Армянский";
            this.buttonArmenian.UseVisualStyleBackColor = true;
            this.buttonArmenian.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // buttonGeorgian
            // 
            this.buttonGeorgian.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F);
            this.buttonGeorgian.ForeColor = System.Drawing.Color.Maroon;
            this.buttonGeorgian.Location = new System.Drawing.Point(9, 248);
            this.buttonGeorgian.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGeorgian.Name = "buttonGeorgian";
            this.buttonGeorgian.Size = new System.Drawing.Size(296, 63);
            this.buttonGeorgian.TabIndex = 2;
            this.buttonGeorgian.Text = "Грузинский";
            this.buttonGeorgian.UseVisualStyleBackColor = true;
            this.buttonGeorgian.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // labelLanguageSelection
            // 
            this.labelLanguageSelection.AutoSize = true;
            this.labelLanguageSelection.Font = new System.Drawing.Font("Bahnschrift Condensed", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLanguageSelection.ForeColor = System.Drawing.Color.Black;
            this.labelLanguageSelection.Location = new System.Drawing.Point(-5, 0);
            this.labelLanguageSelection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLanguageSelection.Name = "labelLanguageSelection";
            this.labelLanguageSelection.Size = new System.Drawing.Size(330, 72);
            this.labelLanguageSelection.TabIndex = 3;
            this.labelLanguageSelection.Text = "Выберите язык";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.labelLanguageSelection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 83);
            this.panel1.TabIndex = 4;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(314, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGeorgian);
            this.Controls.Add(this.buttonArmenian);
            this.Controls.Add(this.buttonOssetian);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.Text = "меню";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOssetian;
        private System.Windows.Forms.Button buttonArmenian;
        private System.Windows.Forms.Button buttonGeorgian;
        private System.Windows.Forms.Label labelLanguageSelection;
        private System.Windows.Forms.Panel panel1;
    }
}