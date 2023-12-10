namespace ZH2
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            comboBoxUser = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxRoom = new ComboBox();
            comboBoxHotel = new ComboBox();
            txtAdult = new TextBox();
            txtKid = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            errorProvider1 = new ErrorProvider(components);
            foglalasBindingSource = new BindingSource(components);
            btnQuit = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUser
            // 
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(169, 26);
            comboBoxUser.MaxDropDownItems = 5;
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(151, 28);
            comboBoxUser.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 29);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 16;
            label6.Text = "Felhasználó:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 63);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 17;
            label7.Text = "Hotel neve:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 97);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 18;
            label5.Text = "Szoba száma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 19;
            label2.Text = "Felnőttek száma:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 20;
            label1.Text = "Gyerekek száma:";
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new Point(169, 94);
            comboBoxRoom.MaxDropDownItems = 5;
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new Size(151, 28);
            comboBoxRoom.TabIndex = 24;
            // 
            // comboBoxHotel
            // 
            comboBoxHotel.FormattingEnabled = true;
            comboBoxHotel.Location = new Point(169, 60);
            comboBoxHotel.MaxDropDownItems = 5;
            comboBoxHotel.Name = "comboBoxHotel";
            comboBoxHotel.Size = new Size(151, 28);
            comboBoxHotel.TabIndex = 23;
            comboBoxHotel.SelectedIndexChanged += comboBoxHotel_SelectedIndexChanged;
            // 
            // txtAdult
            // 
            txtAdult.Location = new Point(169, 128);
            txtAdult.Name = "txtAdult";
            txtAdult.Size = new Size(55, 27);
            txtAdult.TabIndex = 22;
            txtAdult.Validating += txtAdult_Validating;
            txtAdult.Validated += txtAdult_Validated;
            // 
            // txtKid
            // 
            txtKid.Location = new Point(169, 161);
            txtKid.Name = "txtKid";
            txtKid.Size = new Size(55, 27);
            txtKid.TabIndex = 21;
            txtKid.Validating += txtKid_Validating;
            txtKid.Validated += txtKid_Validated;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "\"yyyy-MM-dd\"";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(169, 227);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "\"yyyy-MM-dd\"";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(169, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 232);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 26;
            label4.Text = "Tartózkodás vége:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 25;
            label3.Text = "Tartózkodás kezdete:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(85, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Hozzáadás";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // foglalasBindingSource
            // 
            foglalasBindingSource.DataSource = typeof(Models.Foglalas);
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(246, 298);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 30;
            btnQuit.Text = "Mégse";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 345);
            Controls.Add(btnQuit);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxRoom);
            Controls.Add(comboBoxHotel);
            Controls.Add(txtAdult);
            Controls.Add(txtKid);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxUser);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUser;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxRoom;
        private ComboBox comboBoxHotel;
        private TextBox txtAdult;
        private TextBox txtKid;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Button btnAdd;
        private ErrorProvider errorProvider1;
        private BindingSource foglalasBindingSource;
        private Button btnQuit;
        private BindingSource bindingSource1;
    }
}