namespace DataMatrixGenerator
{
    partial class MainForm
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
            this.encodeButton = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.TrackTextChange = new System.Windows.Forms.CheckBox();
            this.dataMatrixImage = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatrixImage)).BeginInit();
            this.SuspendLayout();
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(447, 539);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(65, 72);
            this.encodeButton.TabIndex = 0;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.EncodeClick);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 541);
            this.input.MaxLength = 3116;
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(429, 70);
            this.input.TabIndex = 3;
            // 
            // TrackTextChange
            // 
            this.TrackTextChange.AutoSize = true;
            this.TrackTextChange.Location = new System.Drawing.Point(12, 518);
            this.TrackTextChange.Name = "TrackTextChange";
            this.TrackTextChange.Size = new System.Drawing.Size(118, 17);
            this.TrackTextChange.TabIndex = 4;
            this.TrackTextChange.Text = "Track text changes";
            this.TrackTextChange.UseVisualStyleBackColor = true;
            this.TrackTextChange.CheckedChanged += new System.EventHandler(this.TrackTextChangeCheckedChanged);
            // 
            // dataMatrixImage
            // 
            this.dataMatrixImage.BackColor = System.Drawing.Color.White;
            this.dataMatrixImage.Location = new System.Drawing.Point(12, 12);
            this.dataMatrixImage.Name = "dataMatrixImage";
            this.dataMatrixImage.Size = new System.Drawing.Size(500, 500);
            this.dataMatrixImage.TabIndex = 5;
            this.dataMatrixImage.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(320, 617);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save to desktop";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Can\'t scan? Save to desktop, open the image and skan again!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataMatrixImage);
            this.Controls.Add(this.TrackTextChange);
            this.Controls.Add(this.input);
            this.Controls.Add(this.encodeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Data Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.dataMatrixImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.CheckBox TrackTextChange;
        private System.Windows.Forms.PictureBox dataMatrixImage;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
    }
}

