namespace SayisalLoto
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
            sayi2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 89);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "1.sayı";
            // 
            // sayi2
            // 
            sayi2.AutoSize = true;
            sayi2.Location = new Point(266, 89);
            sayi2.Name = "sayi2";
            sayi2.Size = new Size(45, 20);
            sayi2.TabIndex = 1;
            sayi2.Text = "2.sayı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 89);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "3.sayı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(609, 89);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "4.sayı";
            // 
            // button1
            // 
            button1.Location = new Point(297, 263);
            button1.Name = "button1";
            button1.Size = new Size(162, 55);
            button1.TabIndex = 4;
            button1.Text = "başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(594, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(91, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(418, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 27);
            textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(sayi2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label sayi2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
