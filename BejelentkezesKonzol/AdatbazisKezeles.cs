using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BejelentkezesKonzol
{
    public class AdatbazisKezeles
    {
        public MySqlConnection Connection;
        public string Server;
        public string Database;
        public string Username;
        public string Password;

        public AdatbazisKezeles(string server, string database, string username, string password)
        {
            this.Server = server;
            this.Database = database;
            this.Username = username;
            this.Password = password;
        }

        public void Csatlakoztatas()
        {
            try
            {
                string connectionString = "SERVER=" + this.Server + ";" + "DATABASE=" +
                this.Database + ";" + "USERNAME=" + this.Username + ";" + "PASSWORD=" + this.Password + ";";

                this.Connection = new MySqlConnection(connectionString);

                this.Connection.Open();

                Console.WriteLine("Sikeres adatbázis csatlakozás!");

                this.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Valami hiba: {ex.Message}");
            }
        }

        public List<Felhasznalo> MindenFelhasznaloLekeres()
        {
            List<Felhasznalo> lista = new List<Felhasznalo>();

            try
            {
                this.Connection.Open();

                string query = "SELECT * FROM felhasznalok";

                MySqlCommand cmd = new MySqlCommand(query, this.Connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Felhasznalo felh = new Felhasznalo(
                        dataReader["name"].ToString(),
                        dataReader["email"].ToString(),
                        dataReader["password"].ToString(),
                        Int32.Parse(dataReader["isadmin"].ToString())
                    );

                    lista.Add(felh);
                }

                this.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Valami hiba: {ex.Message}");
            }

            return lista;
        }

        public int FelhasznaloFeltoltese(Felhasznalo felh)
        {
            int ertek = 0;

            try
            {
                this.Connection.Open();

                string query = "INSERT INTO felhasznalok (name, email, password, isadmin) " +
                    $"VALUES('{felh.Name}', '{felh.Email}', '{felh.Password}', {felh.IsAdmin})";
                
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                
                ertek = cmd.ExecuteNonQuery();

                this.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Valami hiba: {ex.Message}");
            }

            return ertek;
        }
    }
}
