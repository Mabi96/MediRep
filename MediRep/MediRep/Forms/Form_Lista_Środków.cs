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
    public partial class Form_Lista_Środków : Form
    {
        Środki Środek;
        List<string> listcollection = new List<string>();
        public Form_Lista_Środków(Środki środek)
        {
            InitializeComponent();

            fillTextBox();

            listcollection.Clear();

            foreach (string str in listBox1.Items)
            {
                listcollection.Add(str);
            }

            Środek = środek;
        }


        void fillTextBox() 
        {
            try
            {

                listBox1.Items.Clear();

                foreach (Środki środki in Środki.lista_środków_w_systemie)
                {
                    //POKAŻ TYLKO ŚRODKI KTÓRE MAJA 0 PAKKETÓW
                    if (środki.Id_Pakietu == 0)
                    {
                        listBox1.Items.Add(środki.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SearchBar.Text) == false)
                {
                    listBox1.Items.Clear();
                    foreach (string str in listcollection)
                    {
                        if (str.StartsWith(SearchBar.Text))
                        {
                            listBox1.Items.Add(str);
                        }
                    }
                }
                else if (SearchBar.Text == "")
                {
                    listBox1.Items.Clear();
                    foreach (string str in listcollection)
                    {
                        listBox1.Items.Add(str);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Środki środki in Środki.lista_środków_w_systemie)
                {
                    if (listBox1.SelectedItem != null)
                    {
                        if (listBox1.SelectedItem.ToString() == środki.ToString())
                        {
                            Środek.Id = środki.Id;
                            Środek.Nazwa = środki.Nazwa;
                            Środek.Postać = środki.Postać;
                            Środek.Jednostka_miary = środki.Jednostka_miary;
                            Środek.Jednostka = środki.Jednostka;
                        }
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Lista_Środków_Load(object sender, EventArgs e)
        {

        }
    }
}
