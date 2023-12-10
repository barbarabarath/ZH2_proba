namespace ZH2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textLogin = new TextBox();
            textPassword = new TextBox();
            btnBelepes = new Button();
            btnMegse = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Belépés:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Jelszó:";
            // 
            // textLogin
            // 
            textLogin.Location = new Point(121, 21);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(125, 27);
            textLogin.TabIndex = 2;
            textLogin.Validating += textLogin_Validating;
            textLogin.Validated += textLogin_Validated;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(121, 57);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(125, 27);
            textPassword.TabIndex = 3;
            textPassword.Validating += textPassword_Validating;
            textPassword.Validated += textPassword_Validated;
            // 
            // btnBelepes
            // 
            btnBelepes.Location = new Point(44, 105);
            btnBelepes.Name = "btnBelepes";
            btnBelepes.Size = new Size(94, 29);
            btnBelepes.TabIndex = 4;
            btnBelepes.Text = "Belépés";
            btnBelepes.UseVisualStyleBackColor = true;
            btnBelepes.Click += btnBelepes_Click;
            // 
            // btnMegse
            // 
            btnMegse.CausesValidation = false;
            btnMegse.DialogResult = DialogResult.Cancel;
            btnMegse.Location = new Point(167, 105);
            btnMegse.Name = "btnMegse";
            btnMegse.Size = new Size(94, 29);
            btnMegse.TabIndex = 5;
            btnMegse.Text = "Mégse";
            btnMegse.UseVisualStyleBackColor = true;
            btnMegse.Click += btnMegse_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(310, 148);
            Controls.Add(btnMegse);
            Controls.Add(btnBelepes);
            Controls.Add(textPassword);
            Controls.Add(textLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textLogin;
        private TextBox textPassword;
        private Button btnBelepes;
        private Button btnMegse;
        private ErrorProvider errorProvider1;
    }
}