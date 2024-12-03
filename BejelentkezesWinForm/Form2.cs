using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BejelentkezesKonzol;

namespace BejelentkezesWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void RegisztracioBtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            int isadmin = 0;

            if (name == "" || email == "" || password == "")
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
                return;
            }

            Felhasznalo felh = new Felhasznalo(name, email, password, isadmin);

            AdatbazisKezeles dbMegnyit = new AdatbazisKezeles("localhost", "bejelentkezes", "root", "");
            dbMegnyit.Csatlakoztatas();

            int ertek = dbMegnyit.FelhasznaloFeltoltese(felh);

            if (ertek > 0)
            {
                MessageBox.Show("Sikeres regisztráció!");
                this.Close();

                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Valami nem sikerült a regisztrációkor!");
            }
        }
    }
}
