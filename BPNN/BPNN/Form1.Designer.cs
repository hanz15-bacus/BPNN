namespace BPNN
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.InputC = new System.Windows.Forms.TextBox();
            this.InputD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "create BPNN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Train the neural net";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(22, 90);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 22);
            this.InputA.TabIndex = 2;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(137, 90);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 22);
            this.InputB.TabIndex = 3;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(492, 90);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(249, 22);
            this.Output.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InputC
            // 
            this.InputC.Location = new System.Drawing.Point(243, 90);
            this.InputC.Name = "InputC";
            this.InputC.Size = new System.Drawing.Size(100, 22);
            this.InputC.TabIndex = 5;
            // 
            // InputD
            // 
            this.InputD.Location = new System.Drawing.Point(349, 90);
            this.InputD.Name = "InputD";
            this.InputD.Size = new System.Drawing.Size(100, 22);
            this.InputD.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputD);
            this.Controls.Add(this.InputC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox InputC;
        private System.Windows.Forms.TextBox InputD;
    }
}

