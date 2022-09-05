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

namespace MediRep
{
    public partial class MediRep : Form
    {
        static string stringConnection = "Data Source=1Q;Initial Catalog=ZasobySzpitalneDB2;Persist Security Info=True;User ID=sa;Password=Macko2000";
        public MediRep()
        {
            InitializeComponent();
        }

        private void ListaŚrodkówButton_Click(object sender, EventArgs e)
        {
            Forms.Form_ListaŚrodków f = new Forms.Form_ListaŚrodków();

            if (f.ShowDialog() != DialogResult.OK)
                return;
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.ToString());
            }
        }

     
        private void MediRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zasobySzpitalneDB2DataSet.Pozycja_raportu' table. You can move, or remove it, as needed.
            this.pozycja_raportuTableAdapter.Fill(this.zasobySzpitalneDB2DataSet.Pozycja_raportu);



            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Pielęgniarka", con);

                //Using DataSet
                ZasobySzpitalneDB2DataSet ds = new ZasobySzpitalneDB2DataSet();

                da.Fill(ds, "Pielęgniarka");
                label4.Text += "Data Set\n";
                foreach (DataRow row in ds.Tables["Pielęgniarka"].Rows)
                {
                    label1.Text += row["Imię"] + ",  " + row["Nazwisko"] + ",  " + "\n";
                }
            }

        }

        private void pozycja_raportuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pozycja_raportuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zasobySzpitalneDB2DataSet);

        }
    }
}