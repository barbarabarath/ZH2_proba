namespace ZH2
{
    partial class UserControl2
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
            dataGridView1 = new DataGridView();
            foglalasPkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szobaFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mettolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meddigDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            felnottSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gyermekSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foglalasBindingSource = new BindingSource(components);
            btnAdd = new Button();
            errorProvider1 = new ErrorProvider(components);
            btn_Remove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { foglalasPkDataGridViewTextBoxColumn, ugyfelFkDataGridViewTextBoxColumn, szobaFkDataGridViewTextBoxColumn, mettolDataGridViewTextBoxColumn, meddigDataGridViewTextBoxColumn, felnottSzamDataGridViewTextBoxColumn, gyermekSzamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = foglalasBindingSource;
            dataGridView1.Location = new Point(3, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(957, 396);
            dataGridView1.TabIndex = 0;
            // 
            // foglalasPkDataGridViewTextBoxColumn
            // 
            foglalasPkDataGridViewTextBoxColumn.DataPropertyName = "FoglalasPk";
            foglalasPkDataGridViewTextBoxColumn.HeaderText = "FoglalasPk";
            foglalasPkDataGridViewTextBoxColumn.MinimumWidth = 6;
            foglalasPkDataGridViewTextBoxColumn.Name = "foglalasPkDataGridViewTextBoxColumn";
            foglalasPkDataGridViewTextBoxColumn.Width = 125;
            // 
            // ugyfelFkDataGridViewTextBoxColumn
            // 
            ugyfelFkDataGridViewTextBoxColumn.DataPropertyName = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.HeaderText = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            ugyfelFkDataGridViewTextBoxColumn.Name = "ugyfelFkDataGridViewTextBoxColumn";
            ugyfelFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // szobaFkDataGridViewTextBoxColumn
            // 
            szobaFkDataGridViewTextBoxColumn.DataPropertyName = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.HeaderText = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            szobaFkDataGridViewTextBoxColumn.Name = "szobaFkDataGridViewTextBoxColumn";
            szobaFkDataGridViewTextBoxColumn.Width = 125;
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
            // btnAdd
            // 
            btnAdd.Location = new Point(347, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Hozzáadás";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(477, 14);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(94, 29);
            btn_Remove.TabIndex = 19;
            btn_Remove.Text = "Törlés";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Remove);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "UserControl2";
            Size = new Size(974, 468);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private ErrorProvider errorProvider1;
        private BindingSource foglalasBindingSource;
        private DataGridViewTextBoxColumn foglalasPkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szobaFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mettolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meddigDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn felnottSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gyermekSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szobaFkNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelFkNavigationDataGridViewTextBoxColumn;
        private Button btn_Remove;
    }
}
