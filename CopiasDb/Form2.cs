using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CopiasDb
{
    public partial class Form2 : Form
    {

        SqlConnection connection;
        string connectionString;

        public Form2()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Documents\\CopiasDb.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void btnSelectCopiaAlumno_Click(object sender, EventArgs e)
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CopiaAlumno", connection))
            {
                DataTable tbCopiaAlumno = new DataTable();
                adapter.Fill(tbCopiaAlumno);

                lstCopiaAlumno.DisplayMember = "IdCopiaAlumno";
                lstCopiaAlumno.DisplayMember = "IdCarrera";
                lstCopiaAlumno.DisplayMember = "FechaHora";
                lstCopiaAlumno.DisplayMember = "NumeroCopias";
                lstCopiaAlumno.DisplayMember = "Precio";
                lstCopiaAlumno.DataSource = tbCopiaAlumno;
            }
        }
    }
}
