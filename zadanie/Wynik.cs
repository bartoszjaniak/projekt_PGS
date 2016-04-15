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
    public partial class Wynik : Form
    {
        public Wynik()
        {
            InitializeComponent();
            imie_txt.Text = User.imie;
            nazwisko_txt.Text = User.nazwisko;
            adres_txt.Text = User.adres;
            numer_txt.Text = User.numer;
        }
    }
}
