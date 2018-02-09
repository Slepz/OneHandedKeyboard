namespace OneHandedKeyboard
{
    partial class CharacterPreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThumbLabel = new System.Windows.Forms.Label();
            this.PinkyLabel = new System.Windows.Forms.Label();
            this.RingLabel = new System.Windows.Forms.Label();
            this.MiddleLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThumbLabel
            // 
            this.ThumbLabel.AutoSize = true;
            this.ThumbLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ThumbLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThumbLabel.Font = new System.Drawing.Font("Liberation Mono", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThumbLabel.Location = new System.Drawing.Point(0, 0);
            this.ThumbLabel.Name = "ThumbLabel";
            this.ThumbLabel.Size = new System.Drawing.Size(96, 100);
            this.ThumbLabel.TabIndex = 0;
            this.ThumbLabel.Text = "A";
            this.ThumbLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PinkyLabel
            // 
            this.PinkyLabel.AutoSize = true;
            this.PinkyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PinkyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinkyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PinkyLabel.Font = new System.Drawing.Font("Liberation Mono", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinkyLabel.Location = new System.Drawing.Point(504, 0);
            this.PinkyLabel.Name = "PinkyLabel";
            this.PinkyLabel.Size = new System.Drawing.Size(96, 100);
            this.PinkyLabel.TabIndex = 1;
            this.PinkyLabel.Text = "A";
            this.PinkyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RingLabel
            // 
            this.RingLabel.AutoSize = true;
            this.RingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RingLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RingLabel.Font = new System.Drawing.Font("Liberation Mono", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RingLabel.Location = new System.Drawing.Point(408, 0);
            this.RingLabel.Name = "RingLabel";
            this.RingLabel.Size = new System.Drawing.Size(96, 100);
            this.RingLabel.TabIndex = 2;
            this.RingLabel.Text = "A";
            this.RingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MiddleLabel
            // 
            this.MiddleLabel.AutoSize = true;
            this.MiddleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MiddleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MiddleLabel.Font = new System.Drawing.Font("Liberation Mono", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleLabel.Location = new System.Drawing.Point(312, 0);
            this.MiddleLabel.Name = "MiddleLabel";
            this.MiddleLabel.Size = new System.Drawing.Size(96, 100);
            this.MiddleLabel.TabIndex = 3;
            this.MiddleLabel.Text = "A";
            this.MiddleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IndexLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IndexLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.IndexLabel.Font = new System.Drawing.Font("Liberation Mono", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexLabel.Location = new System.Drawing.Point(216, 0);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(96, 100);
            this.IndexLabel.TabIndex = 4;
            this.IndexLabel.Text = "A";
            this.IndexLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CharacterPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.MiddleLabel);
            this.Controls.Add(this.RingLabel);
            this.Controls.Add(this.PinkyLabel);
            this.Controls.Add(this.ThumbLabel);
            this.Name = "CharacterPreview";
            this.Size = new System.Drawing.Size(600, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThumbLabel;
        private System.Windows.Forms.Label PinkyLabel;
        private System.Windows.Forms.Label RingLabel;
        private System.Windows.Forms.Label MiddleLabel;
        private System.Windows.Forms.Label IndexLabel;
    }
}
