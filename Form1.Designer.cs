namespace WinFormsApp8
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
            listBox1 = new ListBox();
            buttonKeyB = new Button();
            buttonFile = new Button();
            buttonRandom = new Button();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(162, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(147, 199);
            listBox1.TabIndex = 0;
            // 
            // buttonKeyB
            // 
            buttonKeyB.Font = new Font("Segoe UI", 11F);
            buttonKeyB.Location = new Point(315, 202);
            buttonKeyB.Name = "buttonKeyB";
            buttonKeyB.Size = new Size(176, 30);
            buttonKeyB.TabIndex = 1;
            buttonKeyB.Text = "Ввести з клавіатури";
            buttonKeyB.UseVisualStyleBackColor = true;
            buttonKeyB.Click += buttonKeyB_Click;
            // 
            // buttonFile
            // 
            buttonFile.Font = new Font("Segoe UI", 11F);
            buttonFile.Location = new Point(315, 269);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(176, 31);
            buttonFile.TabIndex = 2;
            buttonFile.Text = "Завантажити з файла";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonRandom
            // 
            buttonRandom.Font = new Font("Segoe UI", 11F);
            buttonRandom.Location = new Point(15, 188);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(141, 32);
            buttonRandom.TabIndex = 3;
            buttonRandom.Text = "Згенерувати";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += buttonRandom_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(497, 138);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(169, 199);
            listBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(162, 75);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 39);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(418, 20);
            label1.TabIndex = 7;
            label1.Text = "Введіть кількість чисел для генерування випадкових чисел";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(buttonRandom);
            Controls.Add(buttonFile);
            Controls.Add(buttonKeyB);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Завдання";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button buttonKeyB;
        private Button buttonFile;
        private Button buttonRandom;
        private ListBox listBox2;
        private TextBox textBox1;
        private Label label1;
    }
}
