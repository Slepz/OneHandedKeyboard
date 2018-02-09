namespace OneHandedKeyboard
{
    partial class LevelSelect
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.ThumbCheckBox = new System.Windows.Forms.CheckBox();
            this.IndexCheckBox = new System.Windows.Forms.CheckBox();
            this.MiddleCheckBox = new System.Windows.Forms.CheckBox();
            this.RingCheckBox = new System.Windows.Forms.CheckBox();
            this.PinkyCheckBox = new System.Windows.Forms.CheckBox();
            this.SymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(0, 197);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(183, 48);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // ThumbCheckBox
            // 
            this.ThumbCheckBox.AutoSize = true;
            this.ThumbCheckBox.Location = new System.Drawing.Point(12, 12);
            this.ThumbCheckBox.Name = "ThumbCheckBox";
            this.ThumbCheckBox.Size = new System.Drawing.Size(138, 24);
            this.ThumbCheckBox.TabIndex = 1;
            this.ThumbCheckBox.Text = "Thumb Letters";
            this.ThumbCheckBox.UseVisualStyleBackColor = true;
            this.ThumbCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // IndexCheckBox
            // 
            this.IndexCheckBox.AutoSize = true;
            this.IndexCheckBox.Location = new System.Drawing.Point(12, 42);
            this.IndexCheckBox.Name = "IndexCheckBox";
            this.IndexCheckBox.Size = new System.Drawing.Size(128, 24);
            this.IndexCheckBox.TabIndex = 2;
            this.IndexCheckBox.Text = "Index Letters";
            this.IndexCheckBox.UseVisualStyleBackColor = true;
            this.IndexCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // MiddleCheckBox
            // 
            this.MiddleCheckBox.AutoSize = true;
            this.MiddleCheckBox.Location = new System.Drawing.Point(12, 72);
            this.MiddleCheckBox.Name = "MiddleCheckBox";
            this.MiddleCheckBox.Size = new System.Drawing.Size(135, 24);
            this.MiddleCheckBox.TabIndex = 3;
            this.MiddleCheckBox.Text = "Middle Letters";
            this.MiddleCheckBox.UseVisualStyleBackColor = true;
            this.MiddleCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // RingCheckBox
            // 
            this.RingCheckBox.AutoSize = true;
            this.RingCheckBox.Location = new System.Drawing.Point(12, 102);
            this.RingCheckBox.Name = "RingCheckBox";
            this.RingCheckBox.Size = new System.Drawing.Size(122, 24);
            this.RingCheckBox.TabIndex = 4;
            this.RingCheckBox.Text = "Ring Letters";
            this.RingCheckBox.UseVisualStyleBackColor = true;
            this.RingCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // PinkyCheckBox
            // 
            this.PinkyCheckBox.AutoSize = true;
            this.PinkyCheckBox.Location = new System.Drawing.Point(12, 132);
            this.PinkyCheckBox.Name = "PinkyCheckBox";
            this.PinkyCheckBox.Size = new System.Drawing.Size(126, 24);
            this.PinkyCheckBox.TabIndex = 5;
            this.PinkyCheckBox.Text = "Pinky Letters";
            this.PinkyCheckBox.UseVisualStyleBackColor = true;
            this.PinkyCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SymbolCheckBox
            // 
            this.SymbolCheckBox.AutoSize = true;
            this.SymbolCheckBox.Location = new System.Drawing.Point(12, 162);
            this.SymbolCheckBox.Name = "SymbolCheckBox";
            this.SymbolCheckBox.Size = new System.Drawing.Size(165, 24);
            this.SymbolCheckBox.TabIndex = 6;
            this.SymbolCheckBox.Text = "Rare and Symbols";
            this.SymbolCheckBox.UseVisualStyleBackColor = true;
            this.SymbolCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // LevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(183, 245);
            this.ControlBox = false;
            this.Controls.Add(this.SymbolCheckBox);
            this.Controls.Add(this.PinkyCheckBox);
            this.Controls.Add(this.RingCheckBox);
            this.Controls.Add(this.MiddleCheckBox);
            this.Controls.Add(this.IndexCheckBox);
            this.Controls.Add(this.ThumbCheckBox);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form2";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckBox ThumbCheckBox;
        private System.Windows.Forms.CheckBox IndexCheckBox;
        private System.Windows.Forms.CheckBox MiddleCheckBox;
        private System.Windows.Forms.CheckBox RingCheckBox;
        private System.Windows.Forms.CheckBox PinkyCheckBox;
        private System.Windows.Forms.CheckBox SymbolCheckBox;
    }
}