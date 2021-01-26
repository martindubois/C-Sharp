
namespace TT_Calculator
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
            this.cOutput = new System.Windows.Forms.TextBox();
            this.cValue = new System.Windows.Forms.TextBox();
            this.cPush = new System.Windows.Forms.Button();
            this.cAdd = new System.Windows.Forms.Button();
            this.cSub = new System.Windows.Forms.Button();
            this.cMul = new System.Windows.Forms.Button();
            this.cDiv = new System.Windows.Forms.Button();
            this.cReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cOutput
            // 
            this.cOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cOutput.Location = new System.Drawing.Point(13, 13);
            this.cOutput.Multiline = true;
            this.cOutput.Name = "cOutput";
            this.cOutput.ReadOnly = true;
            this.cOutput.Size = new System.Drawing.Size(348, 425);
            this.cOutput.TabIndex = 0;
            this.cOutput.TabStop = false;
            // 
            // cValue
            // 
            this.cValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cValue.Location = new System.Drawing.Point(505, 13);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(202, 29);
            this.cValue.TabIndex = 1;
            this.cValue.TextChanged += new System.EventHandler(this.cValue_TextChanged);
            // 
            // cPush
            // 
            this.cPush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cPush.Location = new System.Drawing.Point(713, 13);
            this.cPush.Name = "cPush";
            this.cPush.Size = new System.Drawing.Size(75, 40);
            this.cPush.TabIndex = 2;
            this.cPush.Text = "Push";
            this.cPush.UseVisualStyleBackColor = true;
            this.cPush.Click += new System.EventHandler(this.cPush_Click);
            // 
            // cAdd
            // 
            this.cAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cAdd.Location = new System.Drawing.Point(505, 77);
            this.cAdd.Name = "cAdd";
            this.cAdd.Size = new System.Drawing.Size(50, 40);
            this.cAdd.TabIndex = 3;
            this.cAdd.Text = "+";
            this.cAdd.UseVisualStyleBackColor = true;
            this.cAdd.Click += new System.EventHandler(this.cAdd_Click);
            // 
            // cSub
            // 
            this.cSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cSub.Location = new System.Drawing.Point(561, 77);
            this.cSub.Name = "cSub";
            this.cSub.Size = new System.Drawing.Size(50, 40);
            this.cSub.TabIndex = 4;
            this.cSub.Text = "-";
            this.cSub.UseVisualStyleBackColor = true;
            this.cSub.Click += new System.EventHandler(this.cSub_Click);
            // 
            // cMul
            // 
            this.cMul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cMul.Location = new System.Drawing.Point(617, 77);
            this.cMul.Name = "cMul";
            this.cMul.Size = new System.Drawing.Size(50, 40);
            this.cMul.TabIndex = 5;
            this.cMul.Text = "*";
            this.cMul.UseVisualStyleBackColor = true;
            this.cMul.Click += new System.EventHandler(this.cMul_Click);
            // 
            // cDiv
            // 
            this.cDiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cDiv.Location = new System.Drawing.Point(673, 77);
            this.cDiv.Name = "cDiv";
            this.cDiv.Size = new System.Drawing.Size(50, 40);
            this.cDiv.TabIndex = 6;
            this.cDiv.Text = "/";
            this.cDiv.UseVisualStyleBackColor = true;
            this.cDiv.Click += new System.EventHandler(this.cDiv_Click);
            // 
            // cReset
            // 
            this.cReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cReset.Location = new System.Drawing.Point(688, 398);
            this.cReset.Name = "cReset";
            this.cReset.Size = new System.Drawing.Size(100, 40);
            this.cReset.TabIndex = 7;
            this.cReset.Text = "Reset";
            this.cReset.UseVisualStyleBackColor = true;
            this.cReset.Click += new System.EventHandler(this.cReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cReset);
            this.Controls.Add(this.cDiv);
            this.Controls.Add(this.cMul);
            this.Controls.Add(this.cSub);
            this.Controls.Add(this.cAdd);
            this.Controls.Add(this.cPush);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.cOutput);
            this.Name = "Form1";
            this.Text = "TT-Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cOutput;
        private System.Windows.Forms.TextBox cValue;
        private System.Windows.Forms.Button cPush;
        private System.Windows.Forms.Button cAdd;
        private System.Windows.Forms.Button cSub;
        private System.Windows.Forms.Button cMul;
        private System.Windows.Forms.Button cDiv;
        private System.Windows.Forms.Button cReset;
    }
}

