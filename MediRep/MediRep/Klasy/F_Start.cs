using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediRep.Klasy
{
    public class F_Start
    {
        string stringConnection = Klasy.SQL.stringConnection;
        
        //DODANIE ŚRODKÓW Z BAZY DO LISTY W KLASIE ŚRODKI
        public void DaneListyŚrodkówWSystemie()
        {
            Środki.lista_środków_w_systemie.Clear();

            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Środki", con);

                //Using DataSet
                DataSet ds = new DataSet();

                da.Fill(ds, "Środki");

                foreach (DataRow row in ds.Tables["Środki"].Rows)
                {
                    int id = 0;
                    // SPRAWDZIC CZY OBJECT NIE JEST NULL - ODPOWIEDNI WARUNEK DO KLASY ŚRODKI
                    if (row["Id_Pakietu"] == null || row["Id_Pakietu"] == DBNull.Value)
                    {
                        id = 0;
                    }
                    else
                    {
                        id = Convert.ToInt32(row["Id_Pakietu"]);
                    }

                    Środki.lista_środków_w_systemie.Add(new Środki()
                    {
                        Id = (int)row["Id"],
                        Id_Pakietu = id,
                        Nazwa = (string)row["Nazwa"],
                        Postać = (string)row["Postać"],
                        Jednostka_miary = (string)row["Jednostka_miary"],
                        Jednostka = (string)row["Jednostka"]
                    });
                }
            }
        }

        //DODANIE PACJETÓW Z BAZY DO LISTY W KLASIE PACJENT
        public void DaneListyPacjentówWSystemie()
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pacjent", con);

                DataSet ds = new DataSet();

                da.Fill(ds, "Pacjent");

                Klasy.Pacjent.lista_pacjętów.Clear();

                foreach (DataRow row in ds.Tables["Pacjent"].Rows)
                {
                    Klasy.Pacjent.lista_pacjętów.Add(new Klasy.Pacjent()
                    {
                        Id = (int)row["Id"],
                        Imię = (string)row["Imię"],
                        Nazwisko = (string)row["Nazwisko"],
                        Pesel = (string)row["Pesel"]
                    });
                }
            }
        }
        //DODANIE PAKIETÓW Z BAZY DO LISTY W KLASIE PAKIET
        public void DaneListyPakietówWSystemie()
        {
            Pakiet.lista_pakietów.Clear();

            using (SqlConnection con = new SqlConnection(stringConnection))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pakiet", con);

                DataSet ds = new DataSet();

                da.Fill(ds, "Pakiet");

                foreach (DataRow row in ds.Tables["Pakiet"].Rows)
                {
                    Pakiet.lista_pakietów.Add(new Pakiet()
                    {
                        Id = (int)row["Id"],
                        Nazwa = (string)row["Nazwa"],
                    });
                }
            }
        }
        //DODANIE POZYCJI Z BAZY DO LISTY W KLASIE POZYCJA_RAPORTU
        public void DaneListyPozycjiWRaporcieWSystemie()
        {
            Pozycja_Raportu.lista_Pozycji.Clear();
            using (SqlConnection con = new SqlConnection(stringConnection))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Pozycja_raportu AS pr INNER JOIN dbo.Środki s ON pr.Id_Środku = s.Id", con);

                DataSet ds = new DataSet();

                da.Fill(ds, "Pozycja");

                foreach (DataRow row in ds.Tables["Pozycja"].Rows)
                {
                    int id;
                    // SPRAWDZIC CZY OBJECT NIE JEST NULL - ODPOWIEDNI WARUNEK DO KLASY
                    if (row["Id_Pakietu"] == null || row["Id_Pakietu"] == DBNull.Value)
                    {
                        id = 0;
                    }
                    else
                    {
                        id = Convert.ToInt32(row["Id_Pakietu"]);
                    }

                    Pozycja_Raportu.lista_Pozycji.Add(new Pozycja_Raportu()
                    {

                        Id = (int)row["Id"],
                        Id_środka = (int)row["Id_Środku"],
                        Id_raportu = (int)row["Id_Raportu"],
                        Ilość_podana = (decimal)row["Ilość_podana"],
                        Ilość_pobrana = (decimal)row["Ilość_pobrana"],
                        Dawka = (string)row["Dawka"],
                        Id_pakietu = id,
                        Nazwa = (string)row["Nazwa"],
                        Postać = (string)row["Postać"],
                        Jednostka_miary = (string)row["Jednostka_miary"],
                        Jednostka = (string)row["Jednostka"],
                    });
                }
            }
        }
    }
}
