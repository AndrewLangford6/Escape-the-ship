namespace Escape_the_ship
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenlabel = new System.Windows.Forms.Label();
            this.yellowlabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.controlsImage = new System.Windows.Forms.Label();
            this.yellowButtonLabel = new System.Windows.Forms.Label();
            this.greenButtonLabel = new System.Windows.Forms.Label();
            this.redButtonLabel = new System.Windows.Forms.Label();
            this.blueButtonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(33, 24);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 0;
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(65, 254);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(53, 13);
            this.blueLabel.TabIndex = 1;
            this.blueLabel.Text = "blueLabel";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(65, 190);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(48, 13);
            this.redLabel.TabIndex = 2;
            this.redLabel.Text = "redLabel";
            // 
            // greenlabel
            // 
            this.greenlabel.AutoSize = true;
            this.greenlabel.ForeColor = System.Drawing.Color.White;
            this.greenlabel.Location = new System.Drawing.Point(245, 190);
            this.greenlabel.Name = "greenlabel";
            this.greenlabel.Size = new System.Drawing.Size(60, 13);
            this.greenlabel.TabIndex = 7;
            this.greenlabel.Text = "greenLabel";
            // 
            // yellowlabel
            // 
            this.yellowlabel.AutoSize = true;
            this.yellowlabel.ForeColor = System.Drawing.Color.White;
            this.yellowlabel.Location = new System.Drawing.Point(243, 254);
            this.yellowlabel.Name = "yellowlabel";
            this.yellowlabel.Size = new System.Drawing.Size(62, 13);
            this.yellowlabel.TabIndex = 8;
            this.yellowlabel.Text = "yellowLabel";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(764, 269);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // controlsImage
            // 
            this.controlsImage.Image = ((System.Drawing.Image)(resources.GetObject("controlsImage.Image")));
            this.controlsImage.Location = new System.Drawing.Point(196, -12);
            this.controlsImage.Name = "controlsImage";
            this.controlsImage.Size = new System.Drawing.Size(426, 331);
            this.controlsImage.TabIndex = 10;
            this.controlsImage.Text = "label1";
            this.controlsImage.Visible = false;
            // 
            // yellowButtonLabel
            // 
            this.yellowButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.yellowButtonLabel.Image = global::Escape_the_ship.Properties.Resources.yellow_50x50;
            this.yellowButtonLabel.Location = new System.Drawing.Point(187, 234);
            this.yellowButtonLabel.Name = "yellowButtonLabel";
            this.yellowButtonLabel.Size = new System.Drawing.Size(50, 52);
            this.yellowButtonLabel.TabIndex = 6;
            this.yellowButtonLabel.Text = "N";
            this.yellowButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenButtonLabel
            // 
            this.greenButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.greenButtonLabel.Image = global::Escape_the_ship.Properties.Resources.green_50x50;
            this.greenButtonLabel.Location = new System.Drawing.Point(187, 171);
            this.greenButtonLabel.Name = "greenButtonLabel";
            this.greenButtonLabel.Size = new System.Drawing.Size(50, 56);
            this.greenButtonLabel.TabIndex = 5;
            this.greenButtonLabel.Text = "Space\r\nBar";
            this.greenButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redButtonLabel
            // 
            this.redButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.redButtonLabel.Image = global::Escape_the_ship.Properties.Resources.red_50x50;
            this.redButtonLabel.Location = new System.Drawing.Point(5, 174);
            this.redButtonLabel.Name = "redButtonLabel";
            this.redButtonLabel.Size = new System.Drawing.Size(54, 50);
            this.redButtonLabel.TabIndex = 4;
            this.redButtonLabel.Text = "M";
            this.redButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueButtonLabel
            // 
            this.blueButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.blueButtonLabel.Image = global::Escape_the_ship.Properties.Resources.blue_50x50;
            this.blueButtonLabel.Location = new System.Drawing.Point(5, 235);
            this.blueButtonLabel.Name = "blueButtonLabel";
            this.blueButtonLabel.Size = new System.Drawing.Size(54, 51);
            this.blueButtonLabel.TabIndex = 3;
            this.blueButtonLabel.Text = "B";
            this.blueButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(851, 304);
            this.Controls.Add(this.controlsImage);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.yellowlabel);
            this.Controls.Add(this.greenlabel);
            this.Controls.Add(this.yellowButtonLabel);
            this.Controls.Add(this.greenButtonLabel);
            this.Controls.Add(this.redButtonLabel);
            this.Controls.Add(this.blueButtonLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Escape The Ship";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueButtonLabel;
        private System.Windows.Forms.Label redButtonLabel;
        private System.Windows.Forms.Label greenButtonLabel;
        private System.Windows.Forms.Label yellowButtonLabel;
        private System.Windows.Forms.Label greenlabel;
        private System.Windows.Forms.Label yellowlabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label controlsImage;
    }
}

