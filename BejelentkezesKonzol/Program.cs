using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BejelentkezesKonzol
{
    class Program
    {
        static void Main(string[] args)
        {
            AdatbazisKezeles dbMegnyit = new AdatbazisKezeles("localhost", "bejelentkezes", "root", "");
            dbMegnyit.Csatlakoztatas();
            List<Felhasznalo> felhasznaloLista = dbMegnyit.MindenFelhasznaloLekeres();

            Console.ReadKey(true);
        }
    }
}
