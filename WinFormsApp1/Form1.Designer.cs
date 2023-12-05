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
            textBox1 = new TextBox();
            ToSend = new Button();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 384);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 23);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "e";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ToSend
            // 
            ToSend.Location = new Point(570, 384);
            ToSend.Name = "ToSend";
            ToSend.Size = new Size(79, 23);
            ToSend.TabIndex = 1;
            ToSend.Text = "Отправить";
            ToSend.UseVisualStyleBackColor = true;
            ToSend.Click += ToSend_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ScrollBar;
            richTextBox1.Location = new Point(271, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(378, 366);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(655, 12);
            button1.Name = "button1";
            button1.Size = new Size(129, 55);
            button1.TabIndex = 4;
            button1.Text = "Подключиться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 355);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(136, 384);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 6;
            button2.Text = "Сохранить имя";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(ToSend);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button ToSend;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
    }
}