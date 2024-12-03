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
using System.Threading;

namespace BejelentkezesWinForm
{
    public partial class Form1 : Form
    {
        Thread th;

        public static bool Belepett = true;

        public Form1()
        {
            InitializeComponent();

        }

        public Form1(bool ertek)
        {
            InitializeComponent();

            Belepett = ertek;
        }

        private void RegLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(UrlapNyitForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void UrlapNyitForm2()
        {
            Application.Run(new Form2());
        }
        public void UrlapNyitForm3()
        {
            Application.Run(new Form3());
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(UrlapNyitForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Belepett)
            {
                label2.Visible = true;
                label3.Visible = true;
                RegLink.Visible = true;
                LoginLink.Visible = true;
                label4.Visible = false;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                RegLink.Visible = false;
                LoginLink.Visible = false;
                label4.Visible = true;
            }
        }
    }
}
