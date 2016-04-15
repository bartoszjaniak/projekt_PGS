using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie
{
    public partial class Magic : Form
    {
        public Magic()
        {
            InitializeComponent();
        }

        private void wyswietl(object sender, EventArgs e)
        {

            Wynik wynik = new Wynik();
            wynik.ShowDialog();
        }

        private void dalej(object sender, EventArgs e)
        {
            tabBox.SelectedIndex = (tabBox.SelectedIndex + 1 < tabBox.TabCount) ?
                             tabBox.SelectedIndex + 1 : tabBox.SelectedIndex;
        }

        private void wstecz(object sender, EventArgs e)
        {
            tabBox.SelectedIndex = (tabBox.SelectedIndex - 1 >= 0) ?
                             tabBox.SelectedIndex - 1 : tabBox.SelectedIndex;
        }

        private void zapisz_imie(object sender, EventArgs e)
        {
            User.imie = imie_txt.Text; 
        }

        private void zapisz_nazwisko(object sender, EventArgs e)
        {
            User.nazwisko = nazwisko_txt.Text; 
        }

        private void zapisz_adres(object sender, EventArgs e)
        {
            User.adres = adres_txt.Text; 
        }

        private void zapisz_numer(object sender, EventArgs e)
        {
            User.numer = numer_txt.Text; 
        }
    }
}
