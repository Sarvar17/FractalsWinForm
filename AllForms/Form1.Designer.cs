namespace FractalsWinForm
{
    partial class ChooseFractalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFractalLabel = new System.Windows.Forms.Label();
            this.FirstFractalButton = new System.Windows.Forms.Button();
            this.SecondFractalButton = new System.Windows.Forms.Button();
            this.ThirdFractalButton = new System.Windows.Forms.Button();
            this.FourthFractalButton = new System.Windows.Forms.Button();
            this.FifthFractalButton = new System.Windows.Forms.Button();
            this.SixthFractal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseFractalLabel
            // 
            this.chooseFractalLabel.AutoSize = true;
            this.chooseFractalLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseFractalLabel.Location = new System.Drawing.Point(12, 48);
            this.chooseFractalLabel.Name = "chooseFractalLabel";
            this.chooseFractalLabel.Size = new System.Drawing.Size(358, 27);
            this.chooseFractalLabel.TabIndex = 0;
            this.chooseFractalLabel.Text = "Choose one of these fractals to draw :";
            this.chooseFractalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstFractalButton
            // 
            this.FirstFractalButton.FlatAppearance.BorderSize = 0;
            this.FirstFractalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FirstFractalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstFractalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstFractalButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstFractalButton.Location = new System.Drawing.Point(47, 90);
            this.FirstFractalButton.Name = "FirstFractalButton";
            this.FirstFractalButton.Size = new System.Drawing.Size(282, 40);
            this.FirstFractalButton.TabIndex = 1;
            this.FirstFractalButton.Text = "Fractal Tree";
            this.FirstFractalButton.UseVisualStyleBackColor = true;
            this.FirstFractalButton.Click += new System.EventHandler(this.FirstFractalButton_Click);
            // 
            // SecondFractalButton
            // 
            this.SecondFractalButton.FlatAppearance.BorderSize = 0;
            this.SecondFractalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SecondFractalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SecondFractalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondFractalButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondFractalButton.Location = new System.Drawing.Point(47, 136);
            this.SecondFractalButton.Name = "SecondFractalButton";
            this.SecondFractalButton.Size = new System.Drawing.Size(282, 40);
            this.SecondFractalButton.TabIndex = 1;
            this.SecondFractalButton.Text = "Koch Curve";
            this.SecondFractalButton.UseVisualStyleBackColor = true;
            this.SecondFractalButton.Click += new System.EventHandler(this.SecondFractalButton_Click);
            // 
            // ThirdFractalButton
            // 
            this.ThirdFractalButton.FlatAppearance.BorderSize = 0;
            this.ThirdFractalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ThirdFractalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThirdFractalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdFractalButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdFractalButton.Location = new System.Drawing.Point(47, 182);
            this.ThirdFractalButton.Name = "ThirdFractalButton";
            this.ThirdFractalButton.Size = new System.Drawing.Size(282, 40);
            this.ThirdFractalButton.TabIndex = 1;
            this.ThirdFractalButton.Text = "Sierpinski Carpet";
            this.ThirdFractalButton.UseVisualStyleBackColor = true;
            this.ThirdFractalButton.Click += new System.EventHandler(this.ThirdFractalButton_Click);
            // 
            // FourthFractalButton
            // 
            this.FourthFractalButton.FlatAppearance.BorderSize = 0;
            this.FourthFractalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FourthFractalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FourthFractalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourthFractalButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FourthFractalButton.Location = new System.Drawing.Point(47, 228);
            this.FourthFractalButton.Name = "FourthFractalButton";
            this.FourthFractalButton.Size = new System.Drawing.Size(282, 40);
            this.FourthFractalButton.TabIndex = 1;
            this.FourthFractalButton.Text = "Sierpinski Triangle";
            this.FourthFractalButton.UseVisualStyleBackColor = true;
            this.FourthFractalButton.Click += new System.EventHandler(this.FourthFractalButton_Click);
            // 
            // FifthFractalButton
            // 
            this.FifthFractalButton.FlatAppearance.BorderSize = 0;
            this.FifthFractalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FifthFractalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FifthFractalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FifthFractalButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FifthFractalButton.Location = new System.Drawing.Point(46, 274);
            this.FifthFractalButton.Name = "FifthFractalButton";
            this.FifthFractalButton.Size = new System.Drawing.Size(282, 40);
            this.FifthFractalButton.TabIndex = 1;
            this.FifthFractalButton.Text = "Cantor\'s Set";
            this.FifthFractalButton.UseVisualStyleBackColor = true;
            this.FifthFractalButton.Click += new System.EventHandler(this.FifthFractalButton_Click);
            // 
            // SixthFractal
            // 
            this.SixthFractal.FlatAppearance.BorderSize = 0;
            this.SixthFractal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SixthFractal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SixthFractal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixthFractal.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SixthFractal.Location = new System.Drawing.Point(46, 320);
            this.SixthFractal.Name = "SixthFractal";
            this.SixthFractal.Size = new System.Drawing.Size(282, 40);
            this.SixthFractal.TabIndex = 1;
            this.SixthFractal.Text = "Beautiful Tree";
            this.SixthFractal.UseVisualStyleBackColor = true;
            this.SixthFractal.Click += new System.EventHandler(this.SixthFractalButton_Click);
            // 
            // ChooseFractalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(379, 411);
            this.Controls.Add(this.SixthFractal);
            this.Controls.Add(this.FifthFractalButton);
            this.Controls.Add(this.FourthFractalButton);
            this.Controls.Add(this.ThirdFractalButton);
            this.Controls.Add(this.SecondFractalButton);
            this.Controls.Add(this.FirstFractalButton);
            this.Controls.Add(this.chooseFractalLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 450);
            this.MinimizeBox = false;
            this.Name = "ChooseFractalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseFractalLabel;
        private System.Windows.Forms.Button FirstFractalButton;
        private System.Windows.Forms.Button SecondFractalButton;
        private System.Windows.Forms.Button ThirdFractalButton;
        private System.Windows.Forms.Button FourthFractalButton;
        private System.Windows.Forms.Button FifthFractalButton;
        private System.Windows.Forms.Button SixthFractal;
    }
}

