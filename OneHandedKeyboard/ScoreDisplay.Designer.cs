namespace OneHandedKeyboard
{
    partial class ScoreDisplay
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
            this.ScoresView = new System.Windows.Forms.ListView();
            this.ThumbCheckBox = new System.Windows.Forms.CheckBox();
            this.IndexCheckBox = new System.Windows.Forms.CheckBox();
            this.MiddleCheckBox = new System.Windows.Forms.CheckBox();
            this.RingCheckBox = new System.Windows.Forms.CheckBox();
            this.PinkyCheckBox = new System.Windows.Forms.CheckBox();
            this.SymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoresView
            // 
            this.ScoresView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoresView.Font = new System.Drawing.Font("Liberation Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresView.Location = new System.Drawing.Point(108, 0);
            this.ScoresView.Name = "ScoresView";
            this.ScoresView.Size = new System.Drawing.Size(311, 404);
            this.ScoresView.TabIndex = 0;
            this.ScoresView.UseCompatibleStateImageBehavior = false;
            this.ScoresView.View = System.Windows.Forms.View.List;
            // 
            // ThumbCheckBox
            // 
            this.ThumbCheckBox.AutoSize = true;
            this.ThumbCheckBox.Location = new System.Drawing.Point(13, 13);
            this.ThumbCheckBox.Name = "ThumbCheckBox";
            this.ThumbCheckBox.Size = new System.Drawing.Size(84, 24);
            this.ThumbCheckBox.TabIndex = 1;
            this.ThumbCheckBox.Text = "Thumb";
            this.ThumbCheckBox.ThreeState = true;
            this.ThumbCheckBox.UseVisualStyleBackColor = true;
            this.ThumbCheckBox.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // IndexCheckBox
            // 
            this.IndexCheckBox.AutoSize = true;
            this.IndexCheckBox.Location = new System.Drawing.Point(13, 44);
            this.IndexCheckBox.Name = "IndexCheckBox";
            this.IndexCheckBox.Size = new System.Drawing.Size(74, 24);
            this.IndexCheckBox.TabIndex = 2;
            this.IndexCheckBox.Text = "Index";
            this.IndexCheckBox.ThreeState = true;
            this.IndexCheckBox.UseVisualStyleBackColor = true;
            this.IndexCheckBox.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // MiddleCheckBox
            // 
            this.MiddleCheckBox.AutoSize = true;
            this.MiddleCheckBox.Location = new System.Drawing.Point(13, 75);
            this.MiddleCheckBox.Name = "MiddleCheckBox";
            this.MiddleCheckBox.Size = new System.Drawing.Size(81, 24);
            this.MiddleCheckBox.TabIndex = 3;
            this.MiddleCheckBox.Text = "Middle";
            this.MiddleCheckBox.ThreeState = true;
            this.MiddleCheckBox.UseVisualStyleBackColor = true;
            this.MiddleCheckBox.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // RingCheckBox
            // 
            this.RingCheckBox.AutoSize = true;
            this.RingCheckBox.Location = new System.Drawing.Point(13, 106);
            this.RingCheckBox.Name = "RingCheckBox";
            this.RingCheckBox.Size = new System.Drawing.Size(68, 24);
            this.RingCheckBox.TabIndex = 4;
            this.RingCheckBox.Text = "Ring";
            this.RingCheckBox.ThreeState = true;
            this.RingCheckBox.UseVisualStyleBackColor = true;
            this.RingCheckBox.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // PinkyCheckBox
            // 
            this.PinkyCheckBox.AutoSize = true;
            this.PinkyCheckBox.Location = new System.Drawing.Point(13, 137);
            this.PinkyCheckBox.Name = "PinkyCheckBox";
            this.PinkyCheckBox.Size = new System.Drawing.Size(72, 24);
            this.PinkyCheckBox.TabIndex = 5;
            this.PinkyCheckBox.Text = "Pinky";
            this.PinkyCheckBox.ThreeState = true;
            this.PinkyCheckBox.UseVisualStyleBackColor = true;
            this.PinkyCheckBox.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // SymbolCheckBox
            // 
            this.SymbolCheckBox.AutoSize = true;
            this.SymbolCheckBox.Location = new System.Drawing.Point(13, 168);
            this.SymbolCheckBox.Name = "SymbolCheckBox";
            this.SymbolCheckBox.Size = new System.Drawing.Size(87, 24);
            this.SymbolCheckBox.TabIndex = 6;
            this.SymbolCheckBox.Text = "Symbol";
            this.SymbolCheckBox.ThreeState = true;
            this.SymbolCheckBox.UseVisualStyleBackColor = true;
            this.SymbolCheckBox.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(-1, 360);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(109, 46);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // ScoreDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(420, 405);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SymbolCheckBox);
            this.Controls.Add(this.PinkyCheckBox);
            this.Controls.Add(this.RingCheckBox);
            this.Controls.Add(this.MiddleCheckBox);
            this.Controls.Add(this.IndexCheckBox);
            this.Controls.Add(this.ThumbCheckBox);
            this.Controls.Add(this.ScoresView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(420, 405);
            this.Name = "ScoreDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ScoreDisplay";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ScoresView;
        private System.Windows.Forms.CheckBox ThumbCheckBox;
        private System.Windows.Forms.CheckBox IndexCheckBox;
        private System.Windows.Forms.CheckBox MiddleCheckBox;
        private System.Windows.Forms.CheckBox RingCheckBox;
        private System.Windows.Forms.CheckBox PinkyCheckBox;
        private System.Windows.Forms.CheckBox SymbolCheckBox;
        private System.Windows.Forms.Button CloseButton;
    }
}