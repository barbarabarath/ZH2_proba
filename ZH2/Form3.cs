using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZH2
{
    public partial class Form3 : Form
    {
        Models.HotelsContext hotelsContext = new Models.HotelsContext();
        public Form3()
        {
            InitializeComponent();
            ListHotels();
            ListUsers();
        }

        private void ListHotels()
        {
            var hotel = from x in hotelsContext.Szallashely
                        where x.SzallasNev.Contains(textHotel.Text)
                        select x;
            lbHotel.DataSource = hotel.ToList();
            lbHotel.DisplayMember = "Szallasnev";
        }

        private void ListUsers()
        {
            var user = from x in hotelsContext.Vendeg
                       where x.Usernev.Contains(textUser.Text)
                       select x;
            lbUsers.DataSource = user.ToList();
            lbUsers.DisplayMember = "Usernev";
        }

        private void ListUsersForHotels()
        {
            var szallashely = ((Models.Szallashely)lbHotel.SelectedItem);

            var room = ((Models.Szoba)lbRoom.SelectedItem);


            if (szallashely != null && room != null)
            {
                var foglalasok = from x in hotelsContext.Foglalas
                                 where x.SzobaFk == room.SzobaId && szallashely.SzallasId == room.SzallasFk
                                 select new Staying
                                 {
                                     User = x.UgyfelFk,
                                     Room = x.FoglalasPk
                                 };

                lbStay.DataSource = foglalasok.ToList();
                lbStay.DisplayMember = "User";
            }

            else { MessageBox.Show("baj"); }
        }
        private void textHotel_TextChanged(object sender, EventArgs e)
        {
            ListHotels();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            ListUsers();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            Szallashely szallashely = (Szallashely)lbHotel.SelectedItem;
            Vendeg user = (Vendeg)lbUsers.SelectedItem;
            Szoba room = (Szoba)lbRoom.SelectedItem;

            Foglalas foglalas = new Foglalas();
            foglalas.UgyfelFk = user.Usernev;
            foglalas.SzobaFk = room.SzobaId;
            hotelsContext.Foglalas.Local.Add(foglalas);

            try
            {
                hotelsContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            ListUsersForHotels();

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            
            var szallashely = ((Models.Szallashely)lbHotel.SelectedItem);

            var room = ((Models.Szoba)lbRoom.SelectedItem);

            var user = (Staying)lbStay.SelectedItem;
            
            var od = from x in hotelsContext.Foglalas
                     where x.UgyfelFk == user.User &&  x.SzobaFk == room.SzobaId && szallashely.SzallasId == room.SzallasFk
                     select x;

            hotelsContext.Foglalas.Remove(od.FirstOrDefault());
            hotelsContext.SaveChanges();

            ListUsersForHotels();
        }

        private void lbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListUsersForHotels();

        }

        private void lbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hotel = ((Models.Szallashely)lbHotel.SelectedItem).SzallasId;

            var room = from x in hotelsContext.Szoba
                       where x.SzallasFk == hotel
                       select x;

            lbRoom.DataSource = room.ToList();
            lbRoom.DisplayMember = "SzobaSzama";
        }
    }
}
