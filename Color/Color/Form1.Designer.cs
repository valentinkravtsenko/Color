namespace Color
{
    partial class Form1
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
            this.redLabel = new System.Windows.Forms.Label();
            this.Greenlabel = new System.Windows.Forms.Label();
            this.Bluelabel = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.ColorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(25, 33);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(27, 13);
            this.redLabel.TabIndex = 0;
            this.redLabel.Text = "Red";
            // 
            // Greenlabel
            // 
            this.Greenlabel.AutoSize = true;
            this.Greenlabel.Location = new System.Drawing.Point(25, 70);
            this.Greenlabel.Name = "Greenlabel";
            this.Greenlabel.Size = new System.Drawing.Size(36, 13);
            this.Greenlabel.TabIndex = 0;
            this.Greenlabel.Text = "Green";
            // 
            // Bluelabel
            // 
            this.Bluelabel.AutoSize = true;
            this.Bluelabel.Location = new System.Drawing.Point(25, 106);
            this.Bluelabel.Name = "Bluelabel";
            this.Bluelabel.Size = new System.Drawing.Size(28, 13);
            this.Bluelabel.TabIndex = 0;
            this.Bluelabel.Text = "Blue";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(100, 33);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(172, 45);
            this.trackBarRed.TabIndex = 1;
            this.trackBarRed.Scroll += new System.EventHandler(this.ChangeColor);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(100, 70);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(172, 45);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.Scroll += new System.EventHandler(this.ChangeColor);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(100, 106);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(172, 45);
            this.trackBarBlue.TabIndex = 1;
            this.trackBarBlue.Scroll += new System.EventHandler(this.ChangeColor);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(144, 164);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.Bluelabel);
            this.Controls.Add(this.Greenlabel);
            this.Controls.Add(this.redLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label Greenlabel;
        private System.Windows.Forms.Label Bluelabel;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label ColorLabel;
    }
}

