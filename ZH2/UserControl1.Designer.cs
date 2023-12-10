namespace ZH2
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbHotel = new ListBox();
            textHotel = new TextBox();
            lbRoom = new ListBox();
            dataGridView1 = new DataGridView();
            User = new DataGridViewTextBoxColumn();
            felnottSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gyermekSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationBindingSource = new BindingSource(components);
            label1 = new Label();
            txtTotal = new TextBox();
            txtResCount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bt_excel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbHotel
            // 
            lbHotel.FormattingEnabled = true;
            lbHotel.ItemHeight = 20;
            lbHotel.Location = new Point(15, 105);
            lbHotel.Name = "lbHotel";
            lbHotel.Size = new Size(194, 304);
            lbHotel.TabIndex = 0;
            lbHotel.SelectedIndexChanged += lbHotel_SelectedIndexChanged;
            // 
            // textHotel
            // 
            textHotel.Location = new Point(15, 58);
            textHotel.Name = "textHotel";
            textHotel.Size = new Size(194, 27);
            textHotel.TabIndex = 2;
            textHotel.TextChanged += textHotel_TextChanged;
            // 
            // lbRoom
            // 
            lbRoom.FormattingEnabled = true;
            lbRoom.ItemHeight = 20;
            lbRoom.Location = new Point(225, 105);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new Size(70, 304);
            lbRoom.TabIndex = 5;
            lbRoom.SelectedIndexChanged += lbRoom_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { User, felnottSzamDataGridViewTextBoxColumn, gyermekSzamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reservationBindingSource;
            dataGridView1.Location = new Point(337, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(429, 304);
            dataGridView1.TabIndex = 6;
            // 
            // User
            // 
            User.DataPropertyName = "User";
            User.HeaderText = "User";
            User.MinimumWidth = 6;
            User.Name = "User";
            User.Width = 125;
            // 
            // felnottSzamDataGridViewTextBoxColumn
            // 
            felnottSzamDataGridViewTextBoxColumn.DataPropertyName = "FelnottSzam";
            felnottSzamDataGridViewTextBoxColumn.HeaderText = "FelnottSzam";
            felnottSzamDataGridViewTextBoxColumn.MinimumWidth = 6;
            felnottSzamDataGridViewTextBoxColumn.Name = "felnottSzamDataGridViewTextBoxColumn";
            felnottSzamDataGridViewTextBoxColumn.Width = 125;
            // 
            // gyermekSzamDataGridViewTextBoxColumn
            // 
            gyermekSzamDataGridViewTextBoxColumn.DataPropertyName = "GyermekSzam";
            gyermekSzamDataGridViewTextBoxColumn.HeaderText = "GyermekSzam";
            gyermekSzamDataGridViewTextBoxColumn.MinimumWidth = 6;
            gyermekSzamDataGridViewTextBoxColumn.Name = "gyermekSzamDataGridViewTextBoxColumn";
            gyermekSzamDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(Reservation);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 425);
            label1.Name = "label1";
            label1.Size = new Size(322, 20);
            label1.TabIndex = 7;
            label1.Text = "Szobában megszállt vendégek száma összesen:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(343, 422);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(61, 27);
            txtTotal.TabIndex = 8;
            // 
            // txtResCount
            // 
            txtResCount.Location = new Point(705, 422);
            txtResCount.Name = "txtResCount";
            txtResCount.Size = new Size(61, 27);
            txtResCount.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(561, 425);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 10;
            label2.Text = "Foglalások száma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 16);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 11;
            label3.Text = "Szoba száma:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 16);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 12;
            label4.Text = "Szálláshely neve:";
            // 
            // bt_excel
            // 
            bt_excel.Location = new Point(609, 16);
            bt_excel.Name = "bt_excel";
            bt_excel.Size = new Size(157, 29);
            bt_excel.TabIndex = 13;
            bt_excel.Text = "Adatok letöltése";
            bt_excel.UseVisualStyleBackColor = true;
            bt_excel.Click += bt_excel_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bt_excel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResCount);
            Controls.Add(txtTotal);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(lbRoom);
            Controls.Add(textHotel);
            Controls.Add(lbHotel);
            Name = "UserControl1";
            Size = new Size(790, 473);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbHotel;
        private TextBox textHotel;
        private ListBox lbRoom;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtTotal;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private TextBox txtResCount;
        private Label label2;
        private BindingSource reservationBindingSource;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn felnottSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gyermekSzamDataGridViewTextBoxColumn;
        private Label label3;
        private Label label4;
        private Button bt_excel;
    }
}
