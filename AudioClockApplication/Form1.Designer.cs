namespace WindowsFormsApplication1
{
    partial class AudioClockForm
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.hourCheckBox = new System.Windows.Forms.CheckBox();
            this.quarterHourCheckBox = new System.Windows.Forms.CheckBox();
            this.halfHourCheckBox = new System.Windows.Forms.CheckBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.allMinutesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(28, 230);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // hourCheckBox
            // 
            this.hourCheckBox.AutoSize = true;
            this.hourCheckBox.Location = new System.Drawing.Point(28, 23);
            this.hourCheckBox.Name = "hourCheckBox";
            this.hourCheckBox.Size = new System.Drawing.Size(49, 17);
            this.hourCheckBox.TabIndex = 1;
            this.hourCheckBox.Text = "Hour";
            this.hourCheckBox.UseVisualStyleBackColor = true;
            // 
            // quarterHourCheckBox
            // 
            this.quarterHourCheckBox.AutoSize = true;
            this.quarterHourCheckBox.Location = new System.Drawing.Point(28, 47);
            this.quarterHourCheckBox.Name = "quarterHourCheckBox";
            this.quarterHourCheckBox.Size = new System.Drawing.Size(87, 17);
            this.quarterHourCheckBox.TabIndex = 2;
            this.quarterHourCheckBox.Text = "Quarter Hour";
            this.quarterHourCheckBox.UseVisualStyleBackColor = true;
            // 
            // halfHourCheckBox
            // 
            this.halfHourCheckBox.AutoSize = true;
            this.halfHourCheckBox.Location = new System.Drawing.Point(28, 71);
            this.halfHourCheckBox.Name = "halfHourCheckBox";
            this.halfHourCheckBox.Size = new System.Drawing.Size(71, 17);
            this.halfHourCheckBox.TabIndex = 3;
            this.halfHourCheckBox.Text = "Half Hour";
            this.halfHourCheckBox.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(53, 143);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(174, 46);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "00:00:00";
            // 
            // allMinutesCheckBox
            // 
            this.allMinutesCheckBox.AutoSize = true;
            this.allMinutesCheckBox.Location = new System.Drawing.Point(28, 95);
            this.allMinutesCheckBox.Name = "allMinutesCheckBox";
            this.allMinutesCheckBox.Size = new System.Drawing.Size(77, 17);
            this.allMinutesCheckBox.TabIndex = 5;
            this.allMinutesCheckBox.Text = "All Minutes";
            this.allMinutesCheckBox.UseVisualStyleBackColor = true;
            // 
            // AudioClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.allMinutesCheckBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.halfHourCheckBox);
            this.Controls.Add(this.quarterHourCheckBox);
            this.Controls.Add(this.hourCheckBox);
            this.Controls.Add(this.PlayButton);
            this.Name = "AudioClockForm";
            this.Text = "Audio Clock";
            this.Load += new System.EventHandler(this.AudioClockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.CheckBox hourCheckBox;
        private System.Windows.Forms.CheckBox quarterHourCheckBox;
        private System.Windows.Forms.CheckBox halfHourCheckBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.CheckBox allMinutesCheckBox;
    }
}

