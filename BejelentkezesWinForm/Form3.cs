using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BejelentkezesKonzol;

namespace BejelentkezesWinForm
{
    public partial class Form3 : Form
    {
        Thread th;

        public Form3()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
                return;
            }

            AdatbazisKezeles dbMegnyit = new AdatbazisKezeles("localhost", "bejelentkezes", "root", "");
            dbMegnyit.Csatlakoztatas();

            List<Felhasznalo> felhLista = dbMegnyit.MindenFelhasznaloLekeres();

            bool letezik = false;

            foreach (Felhasznalo item in felhLista)
            {
                if (item.Email == email && item.Password == password)
                {
                    letezik = true;
                    break;
                }
            }

            if (letezik)
            {
                MessageBox.Show("Sikeresen beléptél!");
                this.Close();
                Form1.Belepett = true;

                th = new Thread(UrlapNyitForm1);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Ilyen adatokkal felhasználó nem létezik!");
            }
        }

        public void UrlapNyitForm1()
        {
            Application.Run(new Form1(false));
        }
    }
}
