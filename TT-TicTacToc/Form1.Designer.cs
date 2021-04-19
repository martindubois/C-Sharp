
namespace TT_TicTacToc
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
            this.cLabel_J1 = new System.Windows.Forms.Label();
            this.cLabel_J2 = new System.Windows.Forms.Label();
            this.cLabel_O = new System.Windows.Forms.Label();
            this.cLabel_X = new System.Windows.Forms.Label();
            this.cButton_Person = new System.Windows.Forms.RadioButton();
            this.cButton_Computer = new System.Windows.Forms.RadioButton();
            this.cButton_0 = new System.Windows.Forms.Button();
            this.cButton_1 = new System.Windows.Forms.Button();
            this.cButton_2 = new System.Windows.Forms.Button();
            this.cButton_5 = new System.Windows.Forms.Button();
            this.cButton_4 = new System.Windows.Forms.Button();
            this.cButton_3 = new System.Windows.Forms.Button();
            this.cButton_8 = new System.Windows.Forms.Button();
            this.cButton_7 = new System.Windows.Forms.Button();
            this.cButton_6 = new System.Windows.Forms.Button();
            this.cButton_Begin = new System.Windows.Forms.Button();
            this.cText_Instruction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cLabel_J1
            // 
            this.cLabel_J1.AutoSize = true;
            this.cLabel_J1.Location = new System.Drawing.Point(12, 9);
            this.cLabel_J1.Name = "cLabel_J1";
            this.cLabel_J1.Size = new System.Drawing.Size(89, 25);
            this.cLabel_J1.TabIndex = 0;
            this.cLabel_J1.Text = "Joueur 1";
            // 
            // cLabel_J2
            // 
            this.cLabel_J2.AutoSize = true;
            this.cLabel_J2.Location = new System.Drawing.Point(699, 9);
            this.cLabel_J2.Name = "cLabel_J2";
            this.cLabel_J2.Size = new System.Drawing.Size(89, 25);
            this.cLabel_J2.TabIndex = 1;
            this.cLabel_J2.Text = "Joueur 2";
            // 
            // cLabel_O
            // 
            this.cLabel_O.AutoSize = true;
            this.cLabel_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel_O.Location = new System.Drawing.Point(13, 38);
            this.cLabel_O.Name = "cLabel_O";
            this.cLabel_O.Size = new System.Drawing.Size(53, 48);
            this.cLabel_O.TabIndex = 2;
            this.cLabel_O.Text = "O";
            // 
            // cLabel_X
            // 
            this.cLabel_X.AutoSize = true;
            this.cLabel_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel_X.Location = new System.Drawing.Point(740, 38);
            this.cLabel_X.Name = "cLabel_X";
            this.cLabel_X.Size = new System.Drawing.Size(48, 48);
            this.cLabel_X.TabIndex = 3;
            this.cLabel_X.Text = "X";
            // 
            // cButton_Person
            // 
            this.cButton_Person.AutoSize = true;
            this.cButton_Person.Location = new System.Drawing.Point(667, 91);
            this.cButton_Person.Name = "cButton_Person";
            this.cButton_Person.Size = new System.Drawing.Size(121, 29);
            this.cButton_Person.TabIndex = 4;
            this.cButton_Person.Text = "Personne";
            this.cButton_Person.UseVisualStyleBackColor = true;
            // 
            // cButton_Computer
            // 
            this.cButton_Computer.AutoSize = true;
            this.cButton_Computer.Checked = true;
            this.cButton_Computer.Location = new System.Drawing.Point(667, 126);
            this.cButton_Computer.Name = "cButton_Computer";
            this.cButton_Computer.Size = new System.Drawing.Size(129, 29);
            this.cButton_Computer.TabIndex = 5;
            this.cButton_Computer.TabStop = true;
            this.cButton_Computer.Text = "Ordinateur";
            this.cButton_Computer.UseVisualStyleBackColor = true;
            // 
            // cButton_0
            // 
            this.cButton_0.Enabled = false;
            this.cButton_0.Location = new System.Drawing.Point(232, 55);
            this.cButton_0.Name = "cButton_0";
            this.cButton_0.Size = new System.Drawing.Size(75, 75);
            this.cButton_0.TabIndex = 6;
            this.cButton_0.TabStop = false;
            this.cButton_0.UseVisualStyleBackColor = true;
            this.cButton_0.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_1
            // 
            this.cButton_1.Enabled = false;
            this.cButton_1.Location = new System.Drawing.Point(352, 55);
            this.cButton_1.Name = "cButton_1";
            this.cButton_1.Size = new System.Drawing.Size(75, 75);
            this.cButton_1.TabIndex = 7;
            this.cButton_1.TabStop = false;
            this.cButton_1.UseVisualStyleBackColor = true;
            this.cButton_1.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_2
            // 
            this.cButton_2.Enabled = false;
            this.cButton_2.Location = new System.Drawing.Point(472, 55);
            this.cButton_2.Name = "cButton_2";
            this.cButton_2.Size = new System.Drawing.Size(75, 75);
            this.cButton_2.TabIndex = 8;
            this.cButton_2.TabStop = false;
            this.cButton_2.UseVisualStyleBackColor = true;
            this.cButton_2.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_5
            // 
            this.cButton_5.Enabled = false;
            this.cButton_5.Location = new System.Drawing.Point(472, 175);
            this.cButton_5.Name = "cButton_5";
            this.cButton_5.Size = new System.Drawing.Size(75, 75);
            this.cButton_5.TabIndex = 11;
            this.cButton_5.TabStop = false;
            this.cButton_5.UseVisualStyleBackColor = true;
            this.cButton_5.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_4
            // 
            this.cButton_4.Enabled = false;
            this.cButton_4.Location = new System.Drawing.Point(352, 175);
            this.cButton_4.Name = "cButton_4";
            this.cButton_4.Size = new System.Drawing.Size(75, 75);
            this.cButton_4.TabIndex = 10;
            this.cButton_4.TabStop = false;
            this.cButton_4.UseVisualStyleBackColor = true;
            this.cButton_4.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_3
            // 
            this.cButton_3.Enabled = false;
            this.cButton_3.Location = new System.Drawing.Point(232, 175);
            this.cButton_3.Name = "cButton_3";
            this.cButton_3.Size = new System.Drawing.Size(75, 75);
            this.cButton_3.TabIndex = 9;
            this.cButton_3.TabStop = false;
            this.cButton_3.UseVisualStyleBackColor = true;
            this.cButton_3.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_8
            // 
            this.cButton_8.Enabled = false;
            this.cButton_8.Location = new System.Drawing.Point(470, 295);
            this.cButton_8.Name = "cButton_8";
            this.cButton_8.Size = new System.Drawing.Size(75, 75);
            this.cButton_8.TabIndex = 14;
            this.cButton_8.TabStop = false;
            this.cButton_8.UseVisualStyleBackColor = true;
            this.cButton_8.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_7
            // 
            this.cButton_7.Enabled = false;
            this.cButton_7.Location = new System.Drawing.Point(352, 295);
            this.cButton_7.Name = "cButton_7";
            this.cButton_7.Size = new System.Drawing.Size(75, 75);
            this.cButton_7.TabIndex = 13;
            this.cButton_7.TabStop = false;
            this.cButton_7.UseVisualStyleBackColor = true;
            this.cButton_7.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_6
            // 
            this.cButton_6.Enabled = false;
            this.cButton_6.Location = new System.Drawing.Point(232, 295);
            this.cButton_6.Name = "cButton_6";
            this.cButton_6.Size = new System.Drawing.Size(75, 75);
            this.cButton_6.TabIndex = 12;
            this.cButton_6.TabStop = false;
            this.cButton_6.UseVisualStyleBackColor = true;
            this.cButton_6.Click += new System.EventHandler(this.cButton_Click);
            // 
            // cButton_Begin
            // 
            this.cButton_Begin.Location = new System.Drawing.Point(681, 418);
            this.cButton_Begin.Name = "cButton_Begin";
            this.cButton_Begin.Size = new System.Drawing.Size(107, 40);
            this.cButton_Begin.TabIndex = 15;
            this.cButton_Begin.Text = "Debuter";
            this.cButton_Begin.UseVisualStyleBackColor = true;
            this.cButton_Begin.Click += new System.EventHandler(this.cButton_Begin_Click);
            // 
            // cText_Instruction
            // 
            this.cText_Instruction.Enabled = false;
            this.cText_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cText_Instruction.Location = new System.Drawing.Point(12, 418);
            this.cText_Instruction.Name = "cText_Instruction";
            this.cText_Instruction.Size = new System.Drawing.Size(663, 39);
            this.cText_Instruction.TabIndex = 16;
            this.cText_Instruction.Text = "Cliquer \"Debuter\" pour commencer la partie!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.cText_Instruction);
            this.Controls.Add(this.cButton_Begin);
            this.Controls.Add(this.cButton_8);
            this.Controls.Add(this.cButton_7);
            this.Controls.Add(this.cButton_6);
            this.Controls.Add(this.cButton_5);
            this.Controls.Add(this.cButton_4);
            this.Controls.Add(this.cButton_3);
            this.Controls.Add(this.cButton_2);
            this.Controls.Add(this.cButton_1);
            this.Controls.Add(this.cButton_0);
            this.Controls.Add(this.cButton_Computer);
            this.Controls.Add(this.cButton_Person);
            this.Controls.Add(this.cLabel_X);
            this.Controls.Add(this.cLabel_O);
            this.Controls.Add(this.cLabel_J2);
            this.Controls.Add(this.cLabel_J1);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cLabel_J1;
        private System.Windows.Forms.Label cLabel_J2;
        private System.Windows.Forms.Label cLabel_O;
        private System.Windows.Forms.Label cLabel_X;
        private System.Windows.Forms.RadioButton cButton_Person;
        private System.Windows.Forms.RadioButton cButton_Computer;
        private System.Windows.Forms.Button cButton_0;
        private System.Windows.Forms.Button cButton_1;
        private System.Windows.Forms.Button cButton_2;
        private System.Windows.Forms.Button cButton_5;
        private System.Windows.Forms.Button cButton_4;
        private System.Windows.Forms.Button cButton_3;
        private System.Windows.Forms.Button cButton_8;
        private System.Windows.Forms.Button cButton_7;
        private System.Windows.Forms.Button cButton_6;
        private System.Windows.Forms.Button cButton_Begin;
        private System.Windows.Forms.TextBox cText_Instruction;
    }
}

