namespace ZH2
{
    partial class Form3
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
            label1 = new Label();
            lbHotel = new ListBox();
            szallashelyBindingSource = new BindingSource(components);
            lbStay = new ListBox();
            lbUsers = new ListBox();
            label2 = new Label();
            textHotel = new TextBox();
            textUser = new TextBox();
            btn_Add = new Button();
            btn_Remove = new Button();
            lbRoom = new ListBox();
            ((System.ComponentModel.ISupportInitialize)szallashelyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Szálláshelyek:";
            // 
            // lbHotel
            // 
            lbHotel.DataSource = szallashelyBindingSource;
            lbHotel.DisplayMember = "SzallasNev";
            lbHotel.FormattingEnabled = true;
            lbHotel.ItemHeight = 20;
            lbHotel.Location = new Point(15, 69);
            lbHotel.Name = "lbHotel";
            lbHotel.Size = new Size(143, 364);
            lbHotel.TabIndex = 1;
            lbHotel.SelectedIndexChanged += lbHotel_SelectedIndexChanged;
            // 
            // szallashelyBindingSource
            // 
            szallashelyBindingSource.DataSource = typeof(Models.Szallashely);
            // 
            // lbStay
            // 
            lbStay.FormattingEnabled = true;
            lbStay.ItemHeight = 20;
            lbStay.Location = new Point(325, 69);
            lbStay.Name = "lbStay";
            lbStay.Size = new Size(189, 364);
            lbStay.TabIndex = 2;
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 20;
            lbUsers.Location = new Point(594, 69);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(178, 364);
            lbUsers.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Vendégek";
            // 
            // textHotel
            // 
            textHotel.Location = new Point(15, 36);
            textHotel.Name = "textHotel";
            textHotel.Size = new Size(178, 27);
            textHotel.TabIndex = 5;
            textHotel.TextChanged += textHotel_TextChanged;
            // 
            // textUser
            // 
            textUser.Location = new Point(594, 36);
            textUser.Name = "textUser";
            textUser.Size = new Size(178, 27);
            textUser.TabIndex = 6;
            textUser.TextChanged += textUser_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(520, 145);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(68, 67);
            btn_Add.TabIndex = 7;
            btn_Add.Text = "+";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(520, 284);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(68, 67);
            btn_Remove.TabIndex = 8;
            btn_Remove.Text = "-";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // lbRoom
            // 
            lbRoom.FormattingEnabled = true;
            lbRoom.ItemHeight = 20;
            lbRoom.Location = new Point(183, 69);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new Size(117, 364);
            lbRoom.TabIndex = 9;
            lbRoom.SelectedIndexChanged += lbRoom_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbRoom);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Add);
            Controls.Add(textUser);
            Controls.Add(textHotel);
            Controls.Add(label2);
            Controls.Add(lbUsers);
            Controls.Add(lbStay);
            Controls.Add(lbHotel);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)szallashelyBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbHotel;
        private ListBox lbStay;
        private ListBox lbUsers;
        private Label label2;
        private TextBox textHotel;
        private TextBox textUser;
        private Button btn_Add;
        private Button btn_Remove;
        private BindingSource szallashelyBindingSource;
        private ListBox lbRoom;
    }
}