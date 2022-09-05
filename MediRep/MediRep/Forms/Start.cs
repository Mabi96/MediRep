using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;

namespace MediRep
{
    public partial class Start : Form
    {

        string stringConnection = Klasy.SQL.stringConnection;
        Klasy.F_Start f_Start = new Klasy.F_Start();
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            //Dodanie z DataSet danych do klasy Pacjent
            f_Start.DaneListyPacjentówWSystemie();
            //Dodanie z DataSet danych do klasy Środki
            f_Start.DaneListyŚrodkówWSystemie();
            //Dodanie z DataSet danych do klasy Pakiet
            f_Start.DaneListyPakietówWSystemie();
            //Dodanie z DataSet danych do klasy Pozycji_Raportu
            f_Start.DaneListyPozycjiWRaporcieWSystemie();
            //Wyświetlanie Pakietów w combobox'ie
            if (Pakiet_comboBox.Items != null)
            {
                WyświetlListęPakietów();
            }
            //Wyświetlanie Pacjętów w combobox'ie
            WyświetlListęPacjętów();
            //USTAWIENIE PIERWSZEGA POCJĘTA ORAZ PAKIETU
            Pacjent_comboBox.SelectedIndex = 0;

        }

        void WyświetlListęPacjętów()
        {
            foreach (Klasy.Pacjent p in Klasy.Pacjent.lista_pacjętów)
            {
                Pacjent_comboBox.Items.Add(p);
            }

        }

        void WyświetlListęPakietów()
        {
            Pakiet_comboBox.Items.Clear();

            if (Pakiet.lista_pakietów.Count != 0)
            {
                foreach (Pakiet p in Pakiet.lista_pakietów)
                {
                    Pakiet_comboBox.Items.Add(p);
                }

                Pakiet_comboBox.SelectedIndex = 0;
            }
            else
            {
                Pakiet_comboBox.Text = "";
            }
        }

        //TWORZENIE NOWYCH PAKIETÓW
        private void NowyPakietButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pakiet nowy_pakiet = new Pakiet();
                Forms.Form_Dodaj_Pakiet f = new Forms.Form_Dodaj_Pakiet(nowy_pakiet);

                if (f.ShowDialog() != DialogResult.OK)
                    return;

                f_Start.DaneListyPakietówWSystemie();
                f_Start.DaneListyŚrodkówWSystemie();
                WyświetlListęPakietów();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //WYBRANIE PAKIETU
        private void WybierzPakietButton_Click(object sender, EventArgs e)
        {
            Pakiet p = (Pakiet)Pakiet_comboBox.SelectedItem;
            Klasy.Pacjent pacjentID = (Klasy.Pacjent)Pacjent_comboBox.SelectedItem;

            try
            {
                if (p == null)
                {
                    MessageBox.Show("Proszę wybrać Pakiet lub go utworzyć");
                }
                else { 

                foreach (Pakiet pakietZListy in Pakiet.lista_pakietów)
                {
                    
                    if (p.CzyTenSamPakiet(p, pakietZListy))
                    {
                            //WYSZUKANIE ŚRODKÓW Z ODPOWIEDNIMI WARTOŚCIAMI ID ZGADZAJĄCYMI SIĘ Z ID PAKIETU => POŁĄCZENIE
                            using (SqlConnection con = new SqlConnection(stringConnection))
                            {
                                con.Open();
                                //WYSZUKANIE ID PAKIETU
                                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Środki WHERE id_Pakietu = " + p.Id + "", con);
                                DataSet ds = new DataSet();
                                da.Fill(ds, "Środki");
                                //WYSZUKANIE ID RAPORTU
                                SqlDataAdapter da2 = new SqlDataAdapter("SELECT r.Id FROM dbo.Raport AS r WHERE r.Id_Pacjenta = '" + pacjentID.Id + "';", con);
                                DataSet ds2 = new DataSet();
                                da2.Fill(ds2, "Raport");

                                //ZROBIĆ INSERTA DO BAZY DANYCH I REFRESH DATA GRIDVIEW
                                foreach (DataRow row2 in ds2.Tables["Raport"].Rows)
                                {
                                    int id_Raportu_Pacjęta = (int)row2["Id"];

                                    //MessageBox.Show(id_Raportu_Pacjęta.ToString());

                                    foreach (DataRow row in ds.Tables["Środki"].Rows)
                                    {
                                        string środek_Nazwa = (string)row["Nazwa"];

                                        foreach (Środki ś in Środki.lista_środków_w_systemie)
                                        {
                                            if (ś.Nazwa == środek_Nazwa && ś.Id_Pakietu == 0)
                                            {
                                                //MessageBox.Show(id_Raportu_Pacjęta.ToString());

                                                //WYSZUKANIE ŚRODKÓW Z ODPOWIEDNIMI WARTOŚCIAMI ID ZGADZAJĄCYMI SIĘ Z ID PAKIETU => POŁĄCZENIE
                                                string queryINSERT = "INSERT INTO dbo.Pozycja_Raportu (Id_Środku, Id_Raportu, Ilość_podana, Ilość_pobrana, Dawka) " +
                                                "VALUES(" + ś.Id + ", " + id_Raportu_Pacjęta + ", 0, 0, '-');";

                                                //WYSZUKANIE ŚRODKÓW Z ODPOWIEDNIMI WARTOŚCIAMI ID ZGADZAJĄCYMI SIĘ Z ID PAKIETU => POŁĄCZENIE
                                                SqlCommand myCommand = new SqlCommand(queryINSERT, con);
                                                myCommand.ExecuteNonQuery();

                                                //PONOWNE WPISANIE DANYCH DO KLASY POZYCJA_RAPORTU
                                                f_Start.DaneListyPozycjiWRaporcieWSystemie();
                                                //RESET DATA GRID VIEW
                                                showDataInDataGridView(pacjentID);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.ToString());
            }
        }

        //MODYFIKACJA PAKIETU
        private void ModyfikujPakietButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pakiet pakiet = (Pakiet)Pakiet_comboBox.SelectedItem;
                if (pakiet == null)
                {
                    MessageBox.Show("Brak możliwości modyfikacji. Proszę utworzyć Pakiet");
                }
                else
                {
                    Forms.Form_Dodaj_Pakiet f = new Forms.Form_Dodaj_Pakiet(pakiet);

                    if (f.ShowDialog() != DialogResult.OK)
                        return;

                    f_Start.DaneListyPakietówWSystemie();
                    f_Start.DaneListyŚrodkówWSystemie();
                    WyświetlListęPakietów();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //PRZYCISK USUŃ PAKIET
        private void UsuńPakietButton_Click(object sender, EventArgs e)
        {
            Pakiet p = (Pakiet)Pakiet_comboBox.SelectedItem;

            try
            {
                if (p == null)
                {
                    MessageBox.Show("Brak możliwości usunięcia. Proszę utworzyć nowy Pakiet");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(stringConnection))
                    {
                        //DELETE PAKIET ORAZ ŚRODEK Z ID PAKIETU
                        //PROCES USUWANIA
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.DeleteCommand = con.CreateCommand();
                        da.DeleteCommand.CommandText = "DELETE FROM dbo.Środki WHERE Id_Pakietu = " + p.Id + "";
                        //"DBCC CHECKIDENT ('dbo.Pozycja_raportu', RESEED, "+ id +");"; RESET INCREMENT ID
                        da.DeleteCommand.ExecuteNonQuery();

                        SqlDataAdapter da2 = new SqlDataAdapter();
                        da2.DeleteCommand = con.CreateCommand();
                        da2.DeleteCommand.CommandText = "DELETE FROM dbo.Pakiet WHERE Id = " + p.Id + "";
                        //"DBCC CHECKIDENT ('dbo.Pozycja_raportu', RESEED, "+ id +");"; RESET INCREMENT ID
                        da2.DeleteCommand.ExecuteNonQuery();
                    }

                    f_Start.DaneListyPakietówWSystemie();
                    WyświetlListęPakietów();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //WYBÓR Z LISTY
        private void ListaŚrodkówButton_Click(object sender, EventArgs e)
        {
            try
            {
                Klasy.Pacjent pacjentID = (Klasy.Pacjent)Pacjent_comboBox.SelectedItem;

                Środki środek = new Środki();
                Forms.Form_Lista_Środków f = new Forms.Form_Lista_Środków(środek);

                if (f.ShowDialog() != DialogResult.OK)
                    return;

                MessageBox.Show(środek.Id.ToString());

                //ZNALEZIENIE ID_RAPORTU _PACJENA SPRAWDZAJĄC W KLASIE ID WYBRANEGO PACJENTA NA PODSTAWIE COMBOBOX'a Z ID_RAPORTU W KLASIE Pozycja_Raportu

                using (SqlConnection con = new SqlConnection(stringConnection))
                {
                    // ZNALEZIENIE ID_RAPORTU DLA SZUKANEGO PACJENTA
                    SqlDataAdapter da = new SqlDataAdapter("SELECT r.Id FROM dbo.Raport AS r WHERE r.Id_Pacjenta = '" + pacjentID.Id + "';", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Raport");

                    MessageBox.Show(środek.Id.ToString());

                    foreach (DataRow row in ds.Tables["Raport"].Rows)
                    {
                        int id_Raportu_Pacjęta = (int)row["Id"];

                            //MessageBox.Show(środek.Id.ToString());
                            try
                            {
                                //MessageBox.Show(id_Raportu_Pacjęta.ToString());
                                string queryINSERT = "INSERT INTO dbo.Pozycja_Raportu (Id_Środku, Id_Raportu, Ilość_podana, Ilość_pobrana, Dawka) VALUES(" + środek.Id + ", " + id_Raportu_Pacjęta + ", 0, 0, '-');";

                                //WYSZUKANIE ŚRODKÓW Z ODPOWIEDNIMI WARTOŚCIAMI ID ZGADZAJĄCYMI SIĘ Z ID PAKIETU => POŁĄCZENIE
                                con.Open();
                                SqlCommand myCommand = new SqlCommand(queryINSERT, con);
                                myCommand.ExecuteNonQuery();

                                f_Start.DaneListyPozycjiWRaporcieWSystemie();
                                showDataInDataGridView(pacjentID);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        //WYBÓR PACJĘTA - POKAZANIE LEKARZA I PIELĘGNIARKI I ZESTAWU ŚRODKÓW POZABIEGOWYCH
        private void Pacjent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(stringConnection))
                {
                    Klasy.Pacjent pacjentID = (Klasy.Pacjent)Pacjent_comboBox.SelectedItem;

                    showDataInDataGridView(pacjentID);

                    SqlDataAdapter da = new SqlDataAdapter("SELECT l.Imię, l.Nazwisko FROM dbo.Lekarz AS l " +
                        "INNER JOIN dbo.Raport AS r ON l.Id = r.Id_Lekarza WHERE r.Id_Pacjenta = '" + pacjentID.Id + "';", con);

                    //Using DataSet
                    DataSet ds = new DataSet();

                    da.Fill(ds, "Lekarz");

                    foreach (DataRow row in ds.Tables["Lekarz"].Rows)
                    {
                        textBox1.Text = (string)row["Imię"] + " " + (string)row["Nazwisko"];
                    }

                    SqlDataAdapter da2 = new SqlDataAdapter("SELECT p.Imię, p.Nazwisko FROM dbo.Pielęgniarka AS p " +
                        "INNER JOIN dbo.Raport AS r ON p.Id = r.Id_Pielęgniarki WHERE r.Id_Pacjenta = '" + pacjentID.Id + "';", con);

                    //Using DataSet
                    DataSet ds2 = new DataSet();

                    da2.Fill(ds2, "Pielęgniarka");

                    foreach (DataRow row in ds2.Tables["Pielęgniarka"].Rows)
                    {
                        textBox2.Text = (string)row["Imię"] + " " + (string)row["Nazwisko"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //WYŚWIETLANIE DANYCH W DATAGRIDVIEW
        private void showDataInDataGridView(Klasy.Pacjent pacjentID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(stringConnection))
                {
                    // ZNALEZIENIE ID_RAPORTU DLA SZUKANEGO PACJENTA
                    SqlDataAdapter da = new SqlDataAdapter("SELECT r.Id FROM dbo.Raport AS r WHERE r.Id_Pacjenta = '" + pacjentID.Id + "';", con);

                    DataSet ds = new DataSet();

                    da.Fill(ds, "Raport");

                    foreach (DataRow row in ds.Tables["Raport"].Rows)
                    {
                        int IdRaportu = (int)row["Id"];

                        //MessageBox.Show(IdRaportu.ToString());
                        dataGridView1.Rows.Clear();

                        foreach (Pozycja_Raportu pz in Pozycja_Raportu.lista_Pozycji)
                        {
                            if (pz.Id_raportu == IdRaportu)
                            {
                                int index = dataGridView1.Rows.Add();
                                dataGridView1.Rows[index].Cells["Column1"].Value = pz.Id;
                                dataGridView1.Rows[index].Cells["Column2"].Value = pz.Nazwa;
                                dataGridView1.Rows[index].Cells["Column3"].Value = pz.Postać;
                                dataGridView1.Rows[index].Cells["Column4"].Value = pz.Jednostka_miary;
                                dataGridView1.Rows[index].Cells["Column5"].Value = pz.Jednostka;
                                dataGridView1.Rows[index].Cells["Column6"].Value = pz.Dawka;
                                dataGridView1.Rows[index].Cells["Column7"].Value = pz.Ilość_pobrana;
                                dataGridView1.Rows[index].Cells["Column8"].Value = pz.Ilość_podana;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
          

        //PRZYCISK USUŃ
        private void UsuńŚrodekButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        //ID z data gridview
                        int id = (int)dataGridView1.Rows[selectedIndex].Cells[0].Value;

                        //MessageBox.Show(id.ToString());
                        if (id != 0)
                        {
                            try
                            {
                                using (SqlConnection con = new SqlConnection(stringConnection))
                                {
                                    //PROCES USUWANIA
                                    con.Open();
                                    SqlDataAdapter da = new SqlDataAdapter();
                                    da.DeleteCommand = con.CreateCommand();
                                    da.DeleteCommand.CommandText = "DELETE FROM dbo.Pozycja_raportu WHERE Id = " + id + ";";
                                    //"DBCC CHECKIDENT ('dbo.Pozycja_raportu', RESEED, "+ id +");"; RESET INCREMENT ID
                                    da.DeleteCommand.ExecuteNonQuery();
                                }

                                f_Start.DaneListyPozycjiWRaporcieWSystemie();

                                dataGridView1.Rows.RemoveAt(selectedIndex);
                                dataGridView1.Refresh();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nie można usunąć pusty formularz");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDataGridView()
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //ID z data gridview
                    int id = (int)dataGridView1.Rows[i].Cells[0].Value;

                    using (SqlConnection con = new SqlConnection(stringConnection))
                    {
                        con.Open();

                        string Dawka = dataGridView1.Rows[i].Cells["Column6"].Value.ToString();
                        string Ilość_pobrana = dataGridView1.Rows[i].Cells["Column7"].Value.ToString();
                        string Ilość_podana = dataGridView1.Rows[i].Cells["Column8"].Value.ToString();

                        string queryUpdate = "UPDATE [dbo].[Pozycja_raportu] SET " +
                            "[Ilość_podana] = " + Ilość_podana.ToString().Replace(",", ".") + " ," +
                            "[Ilość_pobrana] = " + Ilość_pobrana.ToString().Replace(",", ".") + " ," +
                            "[Dawka] = '" + Dawka + "'" +
                            "WHERE Id = " + id + ";";

                        SqlCommand cmd = new SqlCommand(queryUpdate, con);

                        cmd.ExecuteNonQuery();
                    }
                }

                f_Start.DaneListyPozycjiWRaporcieWSystemie();

                Klasy.Pacjent pacjentID = (Klasy.Pacjent)Pacjent_comboBox.SelectedItem;
                showDataInDataGridView(pacjentID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //PDF
        private void PdfGeneratorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "Raport.pdf";
                    bool fileError = false;

                    //OTWARCIE KARTY ZAPISU
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (!fileError)
                        {
                            try
                            {
                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    //Tworzenie dokumentu
                                    var pdfDoc = new Document(PageSize.LETTER, 20f, 20f, 30f, 30f);
                                    PdfWriter.GetInstance(pdfDoc, stream);

                                    //Otwarcie pliku
                                    pdfDoc.Open();

                                    //////////////DEKLARACJA//////////////

                                    //PUSTA PRZESTRZEŃ
                                    var spacer = new Paragraph("")
                                    {
                                        SpacingBefore = 25f,
                                        SpacingAfter = 25f,
                                    };
                                    //TABELA NAGŁÓWKOWA
                                    var headerTable = new PdfPTable(new[] { 2f, 2f })
                                    {
                                        HorizontalAlignment = Element.ALIGN_CENTER,
                                        WidthPercentage = 75,
                                        DefaultCell = { MinimumHeight = 22f },
                                    };

                                    var HeaderFORNT = FontFactory.GetFont(BaseFont.COURIER, BaseFont.CP1257, 18);

                                    var headerTableFont = FontFactory.GetFont(BaseFont.COURIER, BaseFont.CP1257, 12);

                                    var DataGridViewFont = FontFactory.GetFont(BaseFont.COURIER, BaseFont.CP1257, 8);

                                    var PodpisFont = FontFactory.GetFont(BaseFont.COURIER, BaseFont.CP1257, 14);

                                    ///////////////////////////////////////

                                    //LOGO
                                    var imagepath = @"..\Szpital_logo.png";
                                    using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                                    {
                                        var png = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                        png.ScalePercent(5f);
                                        pdfDoc.Add(png);
                                    }

                                    //TYTUŁ RAPORTU

                                    Paragraph p = new Paragraph("RAPORT ZUŻYCIA MATERIAŁÓW POZABIEGOWYCH", HeaderFORNT);
                                    p.Alignment = Element.ALIGN_CENTER;

                                    pdfDoc.Add(p);

                                    pdfDoc.Add(spacer);

                                    //TABELA INFROMACJI PACJENT-PIELĘGNIARKA-LEKARZ-DATA_WYKONANIA_RAPORTU

                                    headerTable.AddCell(new Phrase("Data Wygenerowania Raportu", headerTableFont));
                                    headerTable.AddCell(new Phrase(DateTime.Now.ToString(), headerTableFont));
                                    headerTable.AddCell(new Phrase("Lekarz", headerTableFont));
                                    headerTable.AddCell(new Phrase(textBox1.Text, headerTableFont));
                                    headerTable.AddCell(new Phrase("Pielęgniarka", headerTableFont));
                                    headerTable.AddCell(new Phrase(textBox2.Text, headerTableFont));
                                    headerTable.AddCell(new Phrase("Pacjent", headerTableFont));
                                    headerTable.AddCell(new Phrase(Pacjent_comboBox.Text, headerTableFont));

                                    pdfDoc.Add(headerTable);

                                    pdfDoc.Add(spacer);

                                    //DANE Z DATAGRIDVIEW

                                    //KOLUMNA Z DATAGRIDVIEW
                                    var columnCount = dataGridView1.ColumnCount;
                                    var columnWidths = new[] { 0.5f, 2.5f, 1.5f, 1.7f, 1.5f, 1.5f, 1.5f, 1.5f };

                                    var table = new PdfPTable(columnWidths)
                                    {
                                        HorizontalAlignment = Left,
                                        WidthPercentage = 100,
                                        DefaultCell = { MinimumHeight = 22f }
                                    };
                                    // PIERWSZY ROW
                                    var cell = new PdfPCell(new Phrase("Zużyte Środki", headerTableFont))
                                    {
                                        Colspan = columnCount,
                                        HorizontalAlignment = 1,  //0=Left, 1=Centre, 2=Right
                                        MinimumHeight = 30f
                                    };

                                    table.AddCell(cell);

                                    //Nagłówek kolumn
                                    dataGridView1.Columns
                                        .OfType<DataGridViewColumn>()
                                        .ToList()
                                        .ForEach(c => table.AddCell(new Phrase(c.HeaderText, DataGridViewFont)));

                                    //Wiersze

                                    dataGridView1.Rows
                                        .OfType<DataGridViewRow>()
                                        .ToList()
                                        .ForEach(r =>
                                        {
                                            var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                                            cells.ForEach(c => table.AddCell(new Phrase(c.Value?.ToString(), DataGridViewFont)));
                                        });
                                    //

                                    pdfDoc.Add(table);

                                    pdfDoc.Add(spacer);
                                    pdfDoc.Add(spacer);

                                    Paragraph podpis = new Paragraph("Podpis: ..................... ", PodpisFont);
                                    podpis.Alignment = Element.ALIGN_RIGHT;
                                    pdfDoc.Add(podpis);

                                    pdfDoc.Add(spacer);

                                    Paragraph pieczątka = new Paragraph("Pieczątka: ", PodpisFont);
                                    pieczątka.Alignment = Element.ALIGN_LEFT;
                                    pdfDoc.Add(pieczątka);

                                    //ZAMKNIĘCIE PLIKU
                                    pdfDoc.Close();

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Rapot jest pusty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
