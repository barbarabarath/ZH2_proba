namespace ZH2
{
    partial class UserControl3
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ugyfelFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            vendegBindingSource = new BindingSource(components);
            szobaFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            szobaBindingSource = new BindingSource(components);
            mettolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meddigDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            felnottSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gyermekSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foglalasBindingSource = new BindingSource(components);
            btModify = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendegBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)szobaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 0;
            label1.Text = "Foglalások megjelenítése";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ugyfelFkDataGridViewTextBoxColumn, szobaFkDataGridViewTextBoxColumn, mettolDataGridViewTextBoxColumn, meddigDataGridViewTextBoxColumn, felnottSzamDataGridViewTextBoxColumn, gyermekSzamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = foglalasBindingSource;
            dataGridView1.Location = new Point(22, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(812, 376);
            dataGridView1.TabIndex = 3;
            // 
            // ugyfelFkDataGridViewTextBoxColumn
            // 
            ugyfelFkDataGridViewTextBoxColumn.DataPropertyName = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.DataSource = vendegBindingSource;
            ugyfelFkDataGridViewTextBoxColumn.DisplayMember = "Nev";
            ugyfelFkDataGridViewTextBoxColumn.HeaderText = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            ugyfelFkDataGridViewTextBoxColumn.Name = "ugyfelFkDataGridViewTextBoxColumn";
            ugyfelFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            ugyfelFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            ugyfelFkDataGridViewTextBoxColumn.ValueMember = "Usernev";
            ugyfelFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendegBindingSource
            // 
            vendegBindingSource.DataSource = typeof(Models.Vendeg);
            // 
            // szobaFkDataGridViewTextBoxColumn
            // 
            szobaFkDataGridViewTextBoxColumn.DataPropertyName = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.DataSource = szobaBindingSource;
            szobaFkDataGridViewTextBoxColumn.DisplayMember = "SzobaSzama";
            szobaFkDataGridViewTextBoxColumn.HeaderText = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            szobaFkDataGridViewTextBoxColumn.Name = "szobaFkDataGridViewTextBoxColumn";
            szobaFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            szobaFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            szobaFkDataGridViewTextBoxColumn.ValueMember = "SzobaId";
            szobaFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // szobaBindingSource
            // 
            szobaBindingSource.DataSource = typeof(Models.Szoba);
            // 
            // mettolDataGridViewTextBoxColumn
            // 
            mettolDataGridViewTextBoxColumn.DataPropertyName = "Mettol";
            mettolDataGridViewTextBoxColumn.HeaderText = "Mettol";
            mettolDataGridViewTextBoxColumn.MinimumWidth = 6;
            mettolDataGridViewTextBoxColumn.Name = "mettolDataGridViewTextBoxColumn";
            mettolDataGridViewTextBoxColumn.Width = 125;
            // 
            // meddigDataGridViewTextBoxColumn
            // 
            meddigDataGridViewTextBoxColumn.DataPropertyName = "Meddig";
            meddigDataGridViewTextBoxColumn.HeaderText = "Meddig";
            meddigDataGridViewTextBoxColumn.MinimumWidth = 6;
            meddigDataGridViewTextBoxColumn.Name = "meddigDataGridViewTextBoxColumn";
            meddigDataGridViewTextBoxColumn.Width = 125;
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
            // foglalasBindingSource
            // 
            foglalasBindingSource.DataSource = typeof(Models.Foglalas);
            // 
            // btModify
            // 
            btModify.Location = new Point(740, 20);
            btModify.Name = "btModify";
            btModify.Size = new Size(94, 29);
            btModify.TabIndex = 4;
            btModify.Text = "Módosítás";
            btModify.UseVisualStyleBackColor = true;
            btModify.Click += btModify_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btModify);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserControl3";
            Size = new Size(859, 468);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendegBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)szobaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource foglalasBindingSource;
        private BindingSource vendegBindingSource;
        private BindingSource szobaBindingSource;
        private DataGridViewComboBoxColumn ugyfelFkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn szobaFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mettolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meddigDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn felnottSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gyermekSzamDataGridViewTextBoxColumn;
        private Button btModify;
    }
}
