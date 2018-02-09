namespace OneHandedKeyboard
{
    partial class Main
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.LevelButton = new OneHandedKeyboard.UnfocusableButton();
            this.ScoreButton = new OneHandedKeyboard.UnfocusableButton();
            this.CharacterPreview = new OneHandedKeyboard.CharacterPreview();
            this.StartButton = new OneHandedKeyboard.UnfocusableButton();
            this.StopButton = new OneHandedKeyboard.UnfocusableButton();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(878, 94);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TargetLabel
            // 
            this.TargetLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TargetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetLabel.Location = new System.Drawing.Point(0, 94);
            this.TargetLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(878, 141);
            this.TargetLabel.TabIndex = 1;
            // 
            // LevelButton
            // 
            this.LevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelButton.Location = new System.Drawing.Point(0, 344);
            this.LevelButton.Name = "LevelButton";
            this.LevelButton.Size = new System.Drawing.Size(133, 100);
            this.LevelButton.TabIndex = 2;
            this.LevelButton.TabStop = false;
            this.LevelButton.Text = "Levels";
            this.LevelButton.UseVisualStyleBackColor = true;
            this.LevelButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LevelButton_MouseUp);
            // 
            // ScoreButton
            // 
            this.ScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.Location = new System.Drawing.Point(745, 344);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(133, 100);
            this.ScoreButton.TabIndex = 3;
            this.ScoreButton.TabStop = false;
            this.ScoreButton.Text = "Scores";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScoreButton_MouseUp);
            // 
            // CharacterPreview
            // 
            this.CharacterPreview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CharacterPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharacterPreview.Enabled = false;
            this.CharacterPreview.Location = new System.Drawing.Point(139, 344);
            this.CharacterPreview.Name = "CharacterPreview";
            this.CharacterPreview.Size = new System.Drawing.Size(600, 100);
            this.CharacterPreview.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(0, 238);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(133, 100);
            this.StartButton.TabIndex = 4;
            this.StartButton.TabStop = false;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseUp);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(745, 238);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(133, 100);
            this.StopButton.TabIndex = 5;
            this.StopButton.TabStop = false;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopButton_MouseUp);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(140, 239);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(599, 99);
            this.TimerLabel.TabIndex = 6;
            this.TimerLabel.Text = "0:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.LevelButton);
            this.Controls.Add(this.TargetLabel);
            this.Controls.Add(this.CharacterPreview);
            this.Controls.Add(this.OutputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "One-Handed Keyboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private CharacterPreview CharacterPreview;
        private System.Windows.Forms.Label TargetLabel;
        private UnfocusableButton LevelButton;
        private UnfocusableButton ScoreButton;
        private UnfocusableButton StartButton;
        private UnfocusableButton StopButton;
        private System.Windows.Forms.Label TimerLabel;
    }
}

