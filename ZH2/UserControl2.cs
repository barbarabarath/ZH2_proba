using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ZH2.Models;

namespace ZH2
{
    public partial class UserControl2 : UserControl
    {
        Models.HotelsContext hotelsContext = new Models.HotelsContext();
        public UserControl2()
        {
            InitializeComponent();

            foglalasBindingSource.DataSource = hotelsContext.Foglalas.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

            form4.FormClosed += Form4_FormClosed;
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            foglalasBindingSource.DataSource = hotelsContext.Foglalas.ToList();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Models.Foglalas selectedFoglalas = (Models.Foglalas)dataGridView1.SelectedRows[0].DataBoundItem;

                try
                {
                    hotelsContext.Foglalas.Remove(selectedFoglalas);
                    hotelsContext.SaveChanges();

                    MessageBox.Show("A foglalás törlése sikeres!");

                    foglalasBindingSource.DataSource = hotelsContext.Foglalas.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt a foglalás törlésekor:\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt foglalás a törléshez.");
            }
        }

    }
}
