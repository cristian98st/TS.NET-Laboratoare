namespace Calculator
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
            this.Addition = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.InputOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.Erase = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(395, 162);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(117, 94);
            this.Addition.TabIndex = 6;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(518, 162);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(117, 94);
            this.Substraction.TabIndex = 2;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.Substraction_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(395, 262);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(117, 94);
            this.Multiplication.TabIndex = 3;
            this.Multiplication.Text = "X";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(518, 262);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(117, 94);
            this.Division.TabIndex = 4;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(641, 162);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(117, 194);
            this.Equal.TabIndex = 5;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // InputOutput
            // 
            this.InputOutput.Location = new System.Drawing.Point(130, 81);
            this.InputOutput.Name = "InputOutput";
            this.InputOutput.Size = new System.Drawing.Size(363, 22);
            this.InputOutput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 61);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(68, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 61);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 61);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(242, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 61);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(68, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 61);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(155, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 61);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(242, 295);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 61);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(155, 358);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(81, 61);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Erase
            // 
            this.Erase.Location = new System.Drawing.Point(499, 81);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(75, 23);
            this.Erase.TabIndex = 17;
            this.Erase.Text = "<-";
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(580, 80);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "C";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(661, 81);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 19;
            this.Reset.Text = "CC";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(457, 358);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(117, 61);
            this.dotButton.TabIndex = 20;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorBox.Location = new System.Drawing.Point(127, 122);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(0, 17);
            this.ErrorBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Erase);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputOutput);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.TextBox InputOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Label ErrorBox;
    }
}

