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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ZH2
{
    public partial class UserControl1 : UserControl
    {
        Models.HotelsContext hotelsContext = new Models.HotelsContext();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public UserControl1()
        {
            InitializeComponent();
            ListHotels();
        }

        private void ListHotels()
        {
            var hotel = from x in hotelsContext.Szallashely
                        where x.SzallasNev.Contains(textHotel.Text)
                        select x;
            lbHotel.DataSource = hotel.ToList();
            lbHotel.DisplayMember = "Szallasnev";
        }

        private void textHotel_TextChanged(object sender, EventArgs e)
        {
            ListHotels();
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

        private void lbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var room = ((Models.Szoba)lbRoom.SelectedItem).SzobaId;

            var foglalas = from x in hotelsContext.Foglalas
                           where x.SzobaFk == room
                           select new Reservation
                           {
                               User = x.UgyfelFk,
                               FelnottSzam = x.FelnottSzam,
                               GyermekSzam = x.GyermekSzam
                           };

            reservationBindingSource.DataSource = foglalas.ToList();

            var adult = (from x in foglalas
                         select x.FelnottSzam).Sum();
            var kid = (from x in foglalas
                       select x.GyermekSzam).Sum();

            var count = (from x in foglalas
                         select x.User).Count();
            var total = adult + kid;


            txtResCount.Text = count.ToString();
            txtTotal.Text = total.ToString();
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
           CreateExcel();
        }
        
        void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = $"Error: {ex.Message}\nLine: {ex.Source}";
                MessageBox.Show(errMsg, "Error");
                xlWB.Close(false);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        void CreateTable()
        {
            xlSheet.Cells[1, 1] = "Szálláshely neve";
            xlSheet.Cells[1, 2] = "Szoba száma";
            xlSheet.Cells[1, 3] = "Felhasználó neve";
            xlSheet.Cells[1, 4] = "Felnőttek száma";
            xlSheet.Cells[1, 5] = "Gyerekek száma";

            Models.HotelsContext context = new Models.HotelsContext();
            var szallashelyek = context.Szallashely.ToList();
            int currentRow = 2;
            
            var query = from szallashely in context.Szallashely
                        join szoba in context.Szoba on szallashely.SzallasId equals szoba.SzallasFk
                        join foglalas in context.Foglalas on szoba.SzobaId equals foglalas.SzobaFk
                        select new
                        {
                            SzallasNev = szallashely.SzallasNev,
                            SzobaSzama = szoba.SzobaSzama,
                            UgyfelFk = foglalas.UgyfelFk,
                            FelnottSzam = foglalas.FelnottSzam,
                            GyermekSzam = foglalas.GyermekSzam
                        };


            foreach (var item in query.ToList())  // .ToList() hívása az azonnali végrehajtáshoz
            {
                xlSheet.Cells[currentRow, 1] = item.SzallasNev;
                xlSheet.Cells[currentRow, 2] = item.SzobaSzama;
                xlSheet.Cells[currentRow, 3] = item.UgyfelFk;
                xlSheet.Cells[currentRow, 4] = item.FelnottSzam;
                xlSheet.Cells[currentRow, 5] = item.GyermekSzam;
                currentRow++;
            }

            Excel.Range range = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[currentRow - 1, 5]];
            range.EntireColumn.AutoFit();

            Excel.Range headerRange = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
            headerRange.Font.Bold = true;
            headerRange.Interior.Color = Color.LightGray;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }
        
    }

}
