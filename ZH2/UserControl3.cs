using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2
{
    public partial class UserControl3 : UserControl
    {
        Models.HotelsContext hotelsContext = new Models.HotelsContext();
        public UserControl3()
        {
            InitializeComponent();
            vendegBindingSource.DataSource = hotelsContext.Vendeg.ToList();
            szobaBindingSource.DataSource = hotelsContext.Szoba.ToList();
            dataGridView1.DataSource = hotelsContext.Foglalas.ToList();

        }

        private void btModify_Click(object sender, EventArgs e)
        {
            try
            {
                hotelsContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
