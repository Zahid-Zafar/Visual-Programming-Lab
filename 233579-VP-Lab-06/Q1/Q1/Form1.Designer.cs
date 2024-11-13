namespace Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 119);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter 1st number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 168);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter 2nd number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 222);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Result:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 32);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 32);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 32);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(55, 325);
            button1.Name = "button1";
            button1.Size = new Size(106, 31);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(190, 325);
            button2.Name = "button2";
            button2.Size = new Size(103, 31);
            button2.TabIndex = 7;
            button2.Text = "Subtract";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(313, 325);
            button3.Name = "button3";
            button3.Size = new Size(105, 31);
            button3.TabIndex = 8;
            button3.Text = "Multiply";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(444, 325);
            button4.Name = "button4";
            button4.Size = new Size(109, 31);
            button4.TabIndex = 9;
            button4.Text = "Divide";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(55, 51);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 10;
            label4.Text = "Simple Calculator:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 424);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
    }
}