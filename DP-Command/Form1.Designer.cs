
namespace DP_Command
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
            this.cRedo = new System.Windows.Forms.Button();
            this.cUndo = new System.Windows.Forms.Button();
            this.cColor_Black = new System.Windows.Forms.Button();
            this.cColor_Green = new System.Windows.Forms.Button();
            this.cColor_Red = new System.Windows.Forms.Button();
            this.cSize_Larger = new System.Windows.Forms.Button();
            this.cSize_Normal = new System.Windows.Forms.Button();
            this.cSize_Smaller = new System.Windows.Forms.Button();
            this.cLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cRedo
            // 
            this.cRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cRedo.Location = new System.Drawing.Point(654, 385);
            this.cRedo.Name = "cRedo";
            this.cRedo.Size = new System.Drawing.Size(121, 41);
            this.cRedo.TabIndex = 0;
            this.cRedo.Text = "Redo";
            this.cRedo.UseVisualStyleBackColor = true;
            this.cRedo.Click += new System.EventHandler(this.cRedo_Click);
            // 
            // cUndo
            // 
            this.cUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cUndo.Location = new System.Drawing.Point(654, 338);
            this.cUndo.Name = "cUndo";
            this.cUndo.Size = new System.Drawing.Size(121, 41);
            this.cUndo.TabIndex = 1;
            this.cUndo.Text = "Undo";
            this.cUndo.UseVisualStyleBackColor = true;
            this.cUndo.Click += new System.EventHandler(this.cUndo_Click);
            // 
            // cColor_Black
            // 
            this.cColor_Black.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cColor_Black.Location = new System.Drawing.Point(514, 12);
            this.cColor_Black.Name = "cColor_Black";
            this.cColor_Black.Size = new System.Drawing.Size(121, 41);
            this.cColor_Black.TabIndex = 2;
            this.cColor_Black.Text = "Black";
            this.cColor_Black.UseVisualStyleBackColor = true;
            this.cColor_Black.Click += new System.EventHandler(this.cColor_Black_Click);
            // 
            // cColor_Green
            // 
            this.cColor_Green.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cColor_Green.Location = new System.Drawing.Point(514, 59);
            this.cColor_Green.Name = "cColor_Green";
            this.cColor_Green.Size = new System.Drawing.Size(121, 41);
            this.cColor_Green.TabIndex = 3;
            this.cColor_Green.Text = "Green";
            this.cColor_Green.UseVisualStyleBackColor = true;
            this.cColor_Green.Click += new System.EventHandler(this.cColor_Green_Click);
            // 
            // cColor_Red
            // 
            this.cColor_Red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cColor_Red.Location = new System.Drawing.Point(514, 106);
            this.cColor_Red.Name = "cColor_Red";
            this.cColor_Red.Size = new System.Drawing.Size(121, 41);
            this.cColor_Red.TabIndex = 4;
            this.cColor_Red.Text = "Red";
            this.cColor_Red.UseVisualStyleBackColor = true;
            this.cColor_Red.Click += new System.EventHandler(this.cColor_Red_Click);
            // 
            // cSize_Larger
            // 
            this.cSize_Larger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cSize_Larger.Location = new System.Drawing.Point(654, 12);
            this.cSize_Larger.Name = "cSize_Larger";
            this.cSize_Larger.Size = new System.Drawing.Size(121, 41);
            this.cSize_Larger.TabIndex = 5;
            this.cSize_Larger.Text = "Larger";
            this.cSize_Larger.UseVisualStyleBackColor = true;
            this.cSize_Larger.Click += new System.EventHandler(this.cSize_Larger_Click);
            // 
            // cSize_Normal
            // 
            this.cSize_Normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cSize_Normal.Location = new System.Drawing.Point(654, 59);
            this.cSize_Normal.Name = "cSize_Normal";
            this.cSize_Normal.Size = new System.Drawing.Size(121, 41);
            this.cSize_Normal.TabIndex = 6;
            this.cSize_Normal.Text = "Normal";
            this.cSize_Normal.UseVisualStyleBackColor = true;
            this.cSize_Normal.Click += new System.EventHandler(this.cSize_Normal_Click);
            // 
            // cSize_Smaller
            // 
            this.cSize_Smaller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cSize_Smaller.Location = new System.Drawing.Point(654, 106);
            this.cSize_Smaller.Name = "cSize_Smaller";
            this.cSize_Smaller.Size = new System.Drawing.Size(121, 41);
            this.cSize_Smaller.TabIndex = 7;
            this.cSize_Smaller.Text = "Smaller";
            this.cSize_Smaller.UseVisualStyleBackColor = true;
            this.cSize_Smaller.Click += new System.EventHandler(this.cSize_Smaller_Click);
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(22, 27);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(124, 25);
            this.cLabel.TabIndex = 8;
            this.cLabel.Text = "Hello, World!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.cSize_Smaller);
            this.Controls.Add(this.cSize_Normal);
            this.Controls.Add(this.cSize_Larger);
            this.Controls.Add(this.cColor_Red);
            this.Controls.Add(this.cColor_Green);
            this.Controls.Add(this.cColor_Black);
            this.Controls.Add(this.cUndo);
            this.Controls.Add(this.cRedo);
            this.Name = "Form1";
            this.Text = "DP-Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cRedo;
        private System.Windows.Forms.Button cUndo;
        private System.Windows.Forms.Button cColor_Black;
        private System.Windows.Forms.Button cColor_Green;
        private System.Windows.Forms.Button cColor_Red;
        private System.Windows.Forms.Button cSize_Larger;
        private System.Windows.Forms.Button cSize_Normal;
        private System.Windows.Forms.Button cSize_Smaller;
        private System.Windows.Forms.Label cLabel;
    }
}

