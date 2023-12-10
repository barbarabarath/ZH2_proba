using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2.Models;

namespace ZH2
{
    public partial class Form4 : Form
    {
        Models.HotelsContext hotelsContext = new HotelsContext();
        public Form4()
        {
            InitializeComponent();

            foglalasBindingSource.DataSource = hotelsContext.Foglalas.ToList();

            var user = from x in hotelsContext.Vendeg
                       select x.Usernev;
            comboBoxUser.DataSource = user.ToList();

            var hotel = from x in hotelsContext.Szallashely
                        select x.SzallasNev;
            comboBoxHotel.DataSource = hotel.ToList();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosenHotelName = comboBoxHotel.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(chosenHotelName))
            {
                var rooms = from x in hotelsContext.Szoba
                            where x.SzallasFkNavigation.SzallasNev == chosenHotelName
                            select x.SzobaSzama;

                comboBoxRoom.DataSource = rooms.ToList();
            }
            else
            {
                comboBoxRoom.DataSource = null;
            }

        }

        private bool CheckIfFull(string data)
        {
            return !string.IsNullOrEmpty(data);
        }

        private bool CheckIfMore(string data)
        {
            Regex r = new Regex("[0-9]");
            return r.IsMatch(data);

        }

        //validating rész

        private void txtKid_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtKid, "");

        }

        private void txtKid_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckIfMore(txtKid.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtKid, "A mezőt kötelező számformátummal kitölteni!");
            }

        }

        private void txtAdult_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAdult, "");

        }

        private void txtAdult_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckIfFull(txtAdult.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAdult, "A felnőttek száma mező nem lehet üres!");
            }
        }


        //Validatin rész vége

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztos hozzá szeretné adni?", "Hozzáadás", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    Models.Foglalas ujfoglalas = new Models.Foglalas()
                    {
                        UgyfelFk = comboBoxUser.Text,
                        SzobaFk = Int32.Parse(comboBoxRoom.Text),
                        Mettol = dateTimePicker1.Value,
                        Meddig = dateTimePicker2.Value,
                        FelnottSzam = Int32.Parse(txtAdult.Text),
                        GyermekSzam = Int32.Parse(txtKid.Text),
                    };

                    hotelsContext.Foglalas.Add(ujfoglalas);
                    hotelsContext.SaveChanges();

                    MessageBox.Show("A foglalás hozzáadása sikeres!");
                    foglalasBindingSource.DataSource = hotelsContext.Foglalas.ToList();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt a foglalás hozzáadásakor:\n" + ex.Message);
                }
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
