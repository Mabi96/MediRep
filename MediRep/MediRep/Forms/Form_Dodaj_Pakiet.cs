using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediRep.Forms
{
    public partial class Form_Dodaj_Pakiet : Form
    {
        string stringConnection = Klasy.SQL.stringConnection;
        Pakiet Pakiet;
        public Form_Dodaj_Pakiet(Pakiet nowy_pakiet)
        {
            InitializeComponent();
            Pakiet = nowy_pakiet;
        }
        private void Form_Dodaj_Pakiet_Load(object sender, EventArgs e)
        {
            try
            {
                if (Pakiet.Nazwa != null)
                {
                    PakietName.Text = Pakiet.Nazwa;

                    foreach (Środki środki in Środki.lista_środków_w_systemie)
                    {
                        int i = 0;

                        if (środki.Id_Pakietu == Pakiet.Id)
                        {
                            int index = dataGridView1.Rows.Add();
                            dataGridView1.Rows[index].Cells[0].Value = środki.Id;
                            dataGridView1.Rows[index].Cells[1].Value = środki.Nazwa;
                            dataGridView1.Rows[index].Cells[2].Value = środki.Postać;
                            dataGridView1.Rows[index].Cells[3].Value = środki.Jednostka_miary;
                            dataGridView1.Rows[index].Cells[4].Value = środki.Jednostka;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //DODANIE PAKIETU WRAZ Z ŚRODKAMI
        private void OK_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pakiet.Nazwa == null)
                {
                    Pakiet pakiet = new Pakiet();
                    string NazwaPakietu = PakietName.Text;

                    //WPISANIE DO DB I POBRANIE WPISANEGO ID
                    string query = "INSERT INTO [dbo].[Pakiet] ([Nazwa]) OUTPUT INSERTED.ID VALUES('" + NazwaPakietu + "');";


                    using (SqlConnection con = new SqlConnection(stringConnection))
                    {
                        //DODANIE PAKIETU

                        con.Open();

                        SqlCommand myCommand = new SqlCommand(query, con);

                        //POBRANIE ID
                        Int32 newId = (Int32)myCommand.ExecuteScalar();

                        //MessageBox.Show(newId.ToString());

                        //////////////////////////////////////////////////

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {

                            string Nazwa = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            string Postać = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            string Jednostka_miary = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            string Jednostka = dataGridView1.Rows[i].Cells[4].Value.ToString();


                            //DODANIE ŚRODKÓW
                            SqlDataAdapter daŚrodek = new SqlDataAdapter("INSERT INTO [dbo].[Środki]" +
                            "([Id_Pakietu],[Nazwa],[Postać],[Jednostka_miary],[Jednostka])" +
                            "VALUES(" + newId + ", '" + Nazwa + "','" + Postać + "','" + Jednostka_miary + "', '" + Jednostka + "')", con);

                            DataSet dsŚrodek = new DataSet();
                            daŚrodek.Fill(dsŚrodek, "[dbo].[Środki]");
                        }
                    }
                }
                //UPDATE
                else
                {
                    //DODANIE ŚRODKÓW
                    using (SqlConnection con = new SqlConnection(stringConnection))
                    {
                        con.Open();

                        string Pakiet_Nazwa = PakietName.Text;
                        string queryUpdateName = "UPDATE [dbo].[Pakiet] SET [Nazwa] = '" + Pakiet_Nazwa + "' WHERE Id = " + Pakiet.Id + "; ";
                        SqlCommand cmd = new SqlCommand(queryUpdateName, con);
                        cmd.ExecuteNonQuery();

                        for (int i = 0; i < dataGridView1.Rows.Count - 500 ; i++)
                        {
                            string Nazwa = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            string Postać = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            string Jednostka_miary = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            string Jednostka = dataGridView1.Rows[i].Cells[4].Value.ToString();

                            string queryUpdateData = "INSERT INTO [dbo].[Środki]" +
                            "([Id_Pakietu],[Nazwa],[Postać],[Jednostka_miary],[Jednostka])" +
                            "VALUES(" + Pakiet.Id + ", '" + Nazwa + "','" + Postać + "','" + Jednostka_miary + "', '" + Jednostka + "');";

                            SqlCommand cmd2 = new SqlCommand(queryUpdateData, con);

                            cmd2.ExecuteNonQuery();
                        }

                    }
                }

                if (PakietName.Text != null)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Proszę wprowadzić Nazwę Pakietu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd");
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaŚrodkówButton_Click(object sender, EventArgs e)
        {
            try
            {
                Środki środek = new Środki();

                Form_Lista_Środków f = new Form_Lista_Środków(środek);

                if (f.ShowDialog() != DialogResult.OK)
                    return;

                //INSERT NEW
                if (Pakiet.Nazwa == null)
                {
                    try
                    {
                        int index = dataGridView1.Rows.Add();

                        dataGridView1.Rows[index].Cells["Column1"].Value = środek.Nazwa;
                        dataGridView1.Rows[index].Cells["Column2"].Value = środek.Postać;
                        dataGridView1.Rows[index].Cells["Column3"].Value = środek.Jednostka_miary;
                        dataGridView1.Rows[index].Cells["Column4"].Value = środek.Jednostka;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd: " + ex.ToString());
                    }
                }

                //UPDATE
                else
                {
                    try
                    {
                        int index = dataGridView1.Rows.Add();

                        dataGridView1.Rows[index].Cells["Column1"].Value = środek.Nazwa;
                        dataGridView1.Rows[index].Cells["Column2"].Value = środek.Postać;
                        dataGridView1.Rows[index].Cells["Column3"].Value = środek.Jednostka_miary;
                        dataGridView1.Rows[index].Cells["Column4"].Value = środek.Jednostka;

                        //DODANIE ŚRODKA DO PAKIETU O ODPOWIEDNIM ID
                        using (SqlConnection con = new SqlConnection(stringConnection))
                        {
                            string queryINSERT = "INSERT INTO dbo.Środki (Id_Pakietu , Nazwa, Postać, Jednostka_miary, Jednostka)" +
                                " VALUES(" + Pakiet.Id + ", '" + środek.Nazwa + "', '" + środek.Postać + "'," +
                                " '" + środek.Jednostka_miary + "', '" + środek.Jednostka + "');";

                            con.Open();
                            SqlCommand myCommand = new SqlCommand(queryINSERT, con);
                            myCommand.ExecuteNonQuery();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UsuńŚrodekButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;

                    if (selectedIndex > -1)
                    {
                        //INSERT NEW
                        if (Pakiet.Nazwa == null)
                        {
                            //MessageBox.Show(id.ToString());
                            try
                            {
                                dataGridView1.Rows.RemoveAt(selectedIndex);
                                dataGridView1.Refresh();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        //UPDATE
                        else
                        {
                            int id = (int)dataGridView1.Rows[selectedIndex].Cells[0].Value;

                            dataGridView1.Rows.RemoveAt(selectedIndex);
                            dataGridView1.Refresh();

                            foreach (Środki ś in Środki.lista_środków_w_systemie)
                            {
                                if (ś.Id_Pakietu == Pakiet.Id && ś.Id == id)
                                {
                                    //MessageBox.Show(id.ToString());
                                    //MessageBox.Show(Pakiet.Id.ToString());

                                    using (SqlConnection con = new SqlConnection(stringConnection))
                                    {
                                        //PROCES USUWANIA
                                        con.Open();
                                        SqlDataAdapter da = new SqlDataAdapter();
                                        da.DeleteCommand = con.CreateCommand();

                                        da.DeleteCommand.CommandText = "DELETE FROM dbo.Środki WHERE Id = " + id + " AND  Id_Pakietu = " + Pakiet.Id + "; ";
                                        //"DBCC CHECKIDENT ('dbo.Środki', RESEED, "+ id +");"; // RESET INCREMENT ID

                                        da.DeleteCommand.ExecuteNonQuery();
                                    }
                                }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}