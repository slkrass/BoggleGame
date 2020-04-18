namespace BoggleGame
{
    partial class Boggle
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
            this.components = new System.ComponentModel.Container();
            this.uxStartLittleBog = new System.Windows.Forms.Button();
            this.uxReset = new System.Windows.Forms.Button();
            this.uxMinLabel = new System.Windows.Forms.Label();
            this.uxColonLabel = new System.Windows.Forms.Label();
            this.uxSecLabel = new System.Windows.Forms.Label();
            this.uxCountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.uxDisplay = new System.Windows.Forms.TextBox();
            this.uxStartBigBog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxStartLittleBog
            // 
            this.uxStartLittleBog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartLittleBog.Location = new System.Drawing.Point(12, 12);
            this.uxStartLittleBog.Name = "uxStartLittleBog";
            this.uxStartLittleBog.Size = new System.Drawing.Size(172, 50);
            this.uxStartLittleBog.TabIndex = 0;
            this.uxStartLittleBog.Text = "Play Little Boggle";
            this.uxStartLittleBog.UseVisualStyleBackColor = true;
            this.uxStartLittleBog.Click += new System.EventHandler(this.uxStart_Click);
            // 
            // uxReset
            // 
            this.uxReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReset.Location = new System.Drawing.Point(368, 12);
            this.uxReset.Name = "uxReset";
            this.uxReset.Size = new System.Drawing.Size(172, 50);
            this.uxReset.TabIndex = 1;
            this.uxReset.Text = "Reset";
            this.uxReset.UseVisualStyleBackColor = true;
            this.uxReset.Click += new System.EventHandler(this.uxReset_Click);
            // 
            // uxMinLabel
            // 
            this.uxMinLabel.AutoSize = true;
            this.uxMinLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMinLabel.Location = new System.Drawing.Point(577, 12);
            this.uxMinLabel.Name = "uxMinLabel";
            this.uxMinLabel.Size = new System.Drawing.Size(51, 55);
            this.uxMinLabel.TabIndex = 2;
            this.uxMinLabel.Text = "3";
            this.uxMinLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uxColonLabel
            // 
            this.uxColonLabel.AutoSize = true;
            this.uxColonLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxColonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxColonLabel.Location = new System.Drawing.Point(612, 9);
            this.uxColonLabel.Name = "uxColonLabel";
            this.uxColonLabel.Size = new System.Drawing.Size(34, 51);
            this.uxColonLabel.TabIndex = 3;
            this.uxColonLabel.Text = ":";
            // 
            // uxSecLabel
            // 
            this.uxSecLabel.AutoSize = true;
            this.uxSecLabel.BackColor = System.Drawing.Color.Transparent;
            this.uxSecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSecLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxSecLabel.Location = new System.Drawing.Point(631, 12);
            this.uxSecLabel.Name = "uxSecLabel";
            this.uxSecLabel.Size = new System.Drawing.Size(78, 55);
            this.uxSecLabel.TabIndex = 4;
            this.uxSecLabel.Text = "00";
            // 
            // uxCountDownTimer
            // 
            this.uxCountDownTimer.Interval = 1000;
            this.uxCountDownTimer.Tick += new System.EventHandler(this.uxCountDownTimer_Tick);
            // 
            // uxDisplay
            // 
            this.uxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDisplay.Location = new System.Drawing.Point(12, 83);
            this.uxDisplay.Multiline = true;
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.Size = new System.Drawing.Size(768, 546);
            this.uxDisplay.TabIndex = 5;
            // 
            // uxStartBigBog
            // 
            this.uxStartBigBog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartBigBog.Location = new System.Drawing.Point(190, 12);
            this.uxStartBigBog.Name = "uxStartBigBog";
            this.uxStartBigBog.Size = new System.Drawing.Size(172, 50);
            this.uxStartBigBog.TabIndex = 6;
            this.uxStartBigBog.Text = "Play Big Boggle";
            this.uxStartBigBog.UseVisualStyleBackColor = true;
            this.uxStartBigBog.Click += new System.EventHandler(this.uxStart_Click);
            // 
            // Boggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 641);
            this.Controls.Add(this.uxSecLabel);
            this.Controls.Add(this.uxStartBigBog);
            this.Controls.Add(this.uxDisplay);
            this.Controls.Add(this.uxColonLabel);
            this.Controls.Add(this.uxMinLabel);
            this.Controls.Add(this.uxReset);
            this.Controls.Add(this.uxStartLittleBog);
            this.Name = "Boggle";
            this.Text = "Boggle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxStartLittleBog;
        private System.Windows.Forms.Button uxReset;
        private System.Windows.Forms.Label uxMinLabel;
        private System.Windows.Forms.Label uxColonLabel;
        private System.Windows.Forms.Label uxSecLabel;
        private System.Windows.Forms.Timer uxCountDownTimer;
        private System.Windows.Forms.TextBox uxDisplay;
        private System.Windows.Forms.Button uxStartBigBog;
    }
}