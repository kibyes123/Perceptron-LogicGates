namespace Perceptron
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epochText = new System.Windows.Forms.TextBox();
            this.trainButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.andButton = new System.Windows.Forms.RadioButton();
            this.orButton = new System.Windows.Forms.RadioButton();
            this.xorButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 408);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INPUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EPOCH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // epochText
            // 
            this.epochText.Location = new System.Drawing.Point(97, 296);
            this.epochText.Name = "epochText";
            this.epochText.Size = new System.Drawing.Size(125, 20);
            this.epochText.TabIndex = 5;
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(124, 350);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(75, 23);
            this.trainButton.TabIndex = 6;
            this.trainButton.Text = "TRAIN";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(479, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 408);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(593, 197);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 9;
            this.executeButton.Text = "EXECUTE";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "OUTPUT";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(564, 296);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(125, 20);
            this.outputText.TabIndex = 11;
            // 
            // andButton
            // 
            this.andButton.AutoSize = true;
            this.andButton.Location = new System.Drawing.Point(352, 143);
            this.andButton.Name = "andButton";
            this.andButton.Size = new System.Drawing.Size(48, 17);
            this.andButton.TabIndex = 12;
            this.andButton.TabStop = true;
            this.andButton.Text = "AND";
            this.andButton.UseVisualStyleBackColor = true;
            this.andButton.CheckedChanged += new System.EventHandler(this.andButton_CheckedChanged);
            // 
            // orButton
            // 
            this.orButton.AutoSize = true;
            this.orButton.Location = new System.Drawing.Point(352, 181);
            this.orButton.Name = "orButton";
            this.orButton.Size = new System.Drawing.Size(41, 17);
            this.orButton.TabIndex = 13;
            this.orButton.TabStop = true;
            this.orButton.Text = "OR";
            this.orButton.UseVisualStyleBackColor = true;
            // 
            // xorButton
            // 
            this.xorButton.AutoSize = true;
            this.xorButton.Location = new System.Drawing.Point(352, 222);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(48, 17);
            this.xorButton.TabIndex = 14;
            this.xorButton.TabStop = true;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "LOGIC GATES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "W1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "W2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.orButton);
            this.Controls.Add(this.andButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.epochText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox epochText;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.RadioButton andButton;
        private System.Windows.Forms.RadioButton orButton;
        private System.Windows.Forms.RadioButton xorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

