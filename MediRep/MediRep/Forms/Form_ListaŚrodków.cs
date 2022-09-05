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
    public partial class Form_ListaŚrodków : Form
    {
        public Form_ListaŚrodków()
        {
            InitializeComponent();
        }

        private void Form_ListaŚrodków_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=1Q;Initial Catalog=Cwiczenia;Persist Security Info=True;User ID=sa;Password=Macko2000";
                SqlConnection con = new SqlConnection(connectionString);

                string query = "select * from Środki";

                SqlDataAdapter adp = new SqlDataAdapter(query, con);


                using (adp)
                {
                    DataTable table = new DataTable();

                    adp.Fill(table);

                    //listBox1.Items.Add()

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
