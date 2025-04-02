namespace WinFormsApp1
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 83);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 13);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 2;
            label1.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 3;
            label2.Text = "b";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 57);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 5;
            label3.Text = "c";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "1";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(107, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(52, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 323);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private ComboBox comboBox1;
    }
}
