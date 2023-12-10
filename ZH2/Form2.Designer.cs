namespace ZH2
{
    partial class Form2
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 449);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(22, 476);
            button1.Name = "button1";
            button1.Size = new Size(223, 29);
            button1.TabIndex = 1;
            button1.Text = "Szálláshelyek összehasonlítása";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 476);
            button2.Name = "button2";
            button2.Size = new Size(160, 29);
            button2.TabIndex = 2;
            button2.Text = "Új foglalás rögzítése";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(492, 476);
            button3.Name = "button3";
            button3.Size = new Size(191, 29);
            button3.TabIndex = 3;
            button3.Text = "Foglalások megjelenítése";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(744, 476);
            button4.Name = "button4";
            button4.Size = new Size(160, 29);
            button4.TabIndex = 4;
            button4.Text = "Új foglalás rögzítése";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 517);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}