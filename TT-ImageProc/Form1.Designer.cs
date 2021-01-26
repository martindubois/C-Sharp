
namespace TT_ImageProc
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
            this.cTakePicture = new System.Windows.Forms.Button();
            this.cPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cTakePicture
            // 
            this.cTakePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTakePicture.Location = new System.Drawing.Point(638, 12);
            this.cTakePicture.Name = "cTakePicture";
            this.cTakePicture.Size = new System.Drawing.Size(150, 40);
            this.cTakePicture.TabIndex = 0;
            this.cTakePicture.Text = "Take picture";
            this.cTakePicture.UseVisualStyleBackColor = true;
            this.cTakePicture.Click += new System.EventHandler(this.cTakePicture_Click);
            // 
            // cPictureBox
            // 
            this.cPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cPictureBox.Name = "cPictureBox";
            this.cPictureBox.Size = new System.Drawing.Size(604, 426);
            this.cPictureBox.TabIndex = 1;
            this.cPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cPictureBox);
            this.Controls.Add(this.cTakePicture);
            this.Name = "Form1";
            this.Text = "TT-ImageProc";
            ((System.ComponentModel.ISupportInitialize)(this.cPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cTakePicture;
        private System.Windows.Forms.PictureBox cPictureBox;
    }
}

