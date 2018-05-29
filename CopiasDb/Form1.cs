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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Documents\\CopiasDb.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            //Visibles campos de alumno
            lblIdCarrera.Visible = true;
            lblNumeroCopiasAlumno.Visible = true;
            lblPrecio.Visible = true;

            txtIdCarrera.Visible = true;
            txtNumeroCopiasAlumno.Visible = true;
            txtPrecio.Visible = true;

            btnAceptarAlumno.Visible = true;
            btnCancelarAlumno.Visible = true;

            //Ocultos campos de docente
            lblAreaAcademica.Visible = false;
            lblIdDocente.Visible = false;
            lblNumeroCopiasDocente.Visible = false;

            txtIdAreaAcademica.Visible = false;
            txtIdDocente.Visible = false;
            txtNumeroCopiasDocente.Visible = false;

            btnAceptarDocente.Visible = false;
            btnCancelarDocente.Visible = false;

            //Ocultos campos de administrativo
            lblIdAdministrativo.Visible = false;
            lblIdAreaAdministrativo.Visible = false;
            lblNumeroCopiasAdministrativo.Visible = false;

            txtIdAdministrativo.Visible = false;
            txtIdAreaAdministrativo.Visible = false;
            txtNumeroCopiasAdministrativo.Visible = false;

            btnAceptarAdministrativo.Visible = false;
            btnCancelarAdministrativo.Visible = false;
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            //Visibles campos de docente
            lblAreaAcademica.Visible = true;
            lblIdDocente.Visible = true;
            lblNumeroCopiasDocente.Visible = true;

            txtIdAreaAcademica.Visible = true;
            txtIdDocente.Visible = true;
            txtNumeroCopiasDocente.Visible = true;

            btnAceptarDocente.Visible = true;
            btnCancelarDocente.Visible = true;

            //Ocultos campos de alumno
            lblIdCarrera.Visible = false;
            lblNumeroCopiasAlumno.Visible = false;
            lblPrecio.Visible = false;

            txtIdCarrera.Visible = false;
            txtNumeroCopiasAlumno.Visible = false;
            txtPrecio.Visible = false;

            btnAceptarAlumno.Visible = false;
            btnCancelarAlumno.Visible = false;

            //Ocultos campos de administrativo
            lblIdAdministrativo.Visible = false;
            lblIdAreaAdministrativo.Visible = false;
            lblNumeroCopiasAdministrativo.Visible = false;

            txtIdAdministrativo.Visible = false;
            txtIdAreaAdministrativo.Visible = false;
            txtNumeroCopiasAdministrativo.Visible = false;

            btnAceptarAdministrativo.Visible = false;
            btnCancelarAdministrativo.Visible = false;
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            //Visibles campos de administrativo
            lblIdAdministrativo.Visible = true;
            lblIdAreaAdministrativo.Visible = true;
            lblNumeroCopiasAdministrativo.Visible = true;

            txtIdAdministrativo.Visible = true;
            txtIdAreaAdministrativo.Visible = true;
            txtNumeroCopiasAdministrativo.Visible = true;

            btnAceptarAdministrativo.Visible = true;
            btnCancelarAdministrativo.Visible = true;

            //Ocultos campos de alumno
            lblIdCarrera.Visible = false;
            lblNumeroCopiasAlumno.Visible = false;
            lblPrecio.Visible = false;

            txtIdCarrera.Visible = false;
            txtNumeroCopiasAlumno.Visible = false;
            txtPrecio.Visible = false;

            btnAceptarAlumno.Visible = false;
            btnCancelarAlumno.Visible = false;

            //Ocultos campos de docente
            lblAreaAcademica.Visible = false;
            lblIdDocente.Visible = false;
            lblNumeroCopiasDocente.Visible = false;

            txtIdAreaAcademica.Visible = false;
            txtIdDocente.Visible = false;
            txtNumeroCopiasDocente.Visible = false;

            btnAceptarDocente.Visible = false;
            btnCancelarDocente.Visible = false;
        }

        private void btnAceptarAlumno_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CopiaAlumno VALUES (@IdCarrera, @FechaHoraAlumno, @NumeroCopiasAlumno, @Precio)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@IdCarrera", txtIdCarrera.Text);
                command.Parameters.AddWithValue("@FechaHoraAlumno", DateTime.Now);
                command.Parameters.AddWithValue("@NumeroCopiasAlumno", txtNumeroCopiasAlumno.Text);
                command.Parameters.AddWithValue("@Precio", txtPrecio.Text);

                command.ExecuteNonQuery();
            }
        }

        private void btnAceptarDocente_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CopiaDocente VALUES (@IdDocente, @IdAreaAcademica, @FechaHoraDocente, @NumeroCopiasDocente)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@IdDocente", txtIdDocente.Text);
                command.Parameters.AddWithValue("@IdAreaAcademica", txtIdAreaAcademica.Text);
                command.Parameters.AddWithValue("@FechaHoraDocente", DateTime.Now);
                command.Parameters.AddWithValue("@NumeroCopiasDocente", txtNumeroCopiasDocente.Text);

                command.ExecuteNonQuery();
            }
        }

        private void btnAceptarAdministrativo_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CopiaAdministrativo VALUES (@IdAreaAdministrativo, @IdAdministrativo, @FechaHoraAdministrativo, @NumeroCopiasAdministrativo)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@IdAreaAdministrativo", txtIdAreaAdministrativo.Text);
                command.Parameters.AddWithValue("@IdAdministrativo", txtIdAdministrativo.Text);
                command.Parameters.AddWithValue("@FechaHoraAdministrativo", DateTime.Now);
                command.Parameters.AddWithValue("@NumeroCopiasAdministrativo", txtNumeroCopiasAdministrativo.Text);

                command.ExecuteNonQuery();
            }
        }

        private void btnCancelarAlumno_Click(object sender, EventArgs e)
        {
            txtIdCarrera.Text = "";
            txtNumeroCopiasAlumno.Text = "";
            txtPrecio.Text = "";
        }

        private void btnCancelarDocente_Click(object sender, EventArgs e)
        {
            txtIdDocente.Text = "";
            txtIdAreaAcademica.Text = "";
            txtNumeroCopiasDocente.Text = "";
        }

        private void btnCancelarAdministrativo_Click(object sender, EventArgs e)
        {
            txtIdAreaAdministrativo.Text = "";
            txtIdAdministrativo.Text = "";
            txtNumeroCopiasAdministrativo.Text = "";
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            //Visibles campos de carrera
            lblIdAgregarCarrera.Visible = true;
            lblNombreCarrera.Visible = true;

            txtIdAgregarCarrera.Visible = true;
            txtNombreCarrera.Visible = true;

            btnAceptarCarrera.Visible = true;
            btnCancelarCarrera.Visible = true;

            //Ocultos campos de area academica
            lblIdAgregarAreaAcademica.Visible = false;
            lblIdAreaDocente.Visible = false;
            lblNombreAreaAcademica.Visible = false;

            txtIdAgregarAreaAcademica.Visible = false;
            txtIdAreaDocente.Visible = false;
            txtNombreAreaAcademica.Visible = false;

            btnAceptarAreaAcademica.Visible = false;
            btnCancelarAreaAcademica.Visible = false;

            //Ocultos campos de area administrativa
            lblIdAgregarAreaAdministrativa.Visible = false;
            lblNombreAreaAdministrativa.Visible = false;

            txtIdAgregarAreaAdministrativa.Visible = false;
            txtNombreAreaAdministrativa.Visible = false;

            btnAceptarAreaAdministrativa.Visible = false;
            btnCancelarAreaAdministrativa.Visible = false;
        }

        private void btnAreaAcademica_Click(object sender, EventArgs e)
        {
            //Visibles campos de area academica
            lblIdAgregarAreaAcademica.Visible = true;
            lblIdAreaDocente.Visible = true;
            lblNombreAreaAcademica.Visible = true;

            txtIdAgregarAreaAcademica.Visible = true;
            txtIdAreaDocente.Visible = true;
            txtNombreAreaAcademica.Visible = true;

            btnAceptarAreaAcademica.Visible = true;
            btnCancelarAreaAcademica.Visible = true;

            //Ocultos campos de carrera
            lblIdAgregarCarrera.Visible = false;
            lblNombreCarrera.Visible = false;

            txtIdAgregarCarrera.Visible = false;
            txtNombreCarrera.Visible = false;

            btnAceptarCarrera.Visible = false;
            btnCancelarCarrera.Visible = false;

            //Ocultos campos de area administrativa
            lblIdAgregarAreaAdministrativa.Visible = false;
            lblNombreAreaAdministrativa.Visible = false;

            txtIdAgregarAreaAdministrativa.Visible = false;
            txtNombreAreaAdministrativa.Visible = false;

            btnAceptarAreaAdministrativa.Visible = false;
            btnCancelarAreaAdministrativa.Visible = false;
        }

        private void btnAreaAdministrativa_Click(object sender, EventArgs e)
        {
            //Visibles campos de area administrativa
            lblIdAgregarAreaAdministrativa.Visible = true;
            lblNombreAreaAdministrativa.Visible = true;

            txtIdAgregarAreaAdministrativa.Visible = true;
            txtNombreAreaAdministrativa.Visible = true;

            btnAceptarAreaAdministrativa.Visible = true;
            btnCancelarAreaAdministrativa.Visible = true;

            //Ocultos campos de carrera
            lblIdAgregarCarrera.Visible = false;
            lblNombreCarrera.Visible = false;

            txtIdAgregarCarrera.Visible = false;
            txtNombreCarrera.Visible = false;

            btnAceptarCarrera.Visible = false;
            btnCancelarCarrera.Visible = false;

            //Ocultos campos de area academica
            lblIdAgregarAreaAcademica.Visible = false;
            lblIdAreaDocente.Visible = false;
            lblNombreAreaAcademica.Visible = false;

            txtIdAgregarAreaAcademica.Visible = false;
            txtIdAreaDocente.Visible = false;
            txtNombreAreaAcademica.Visible = false;

            btnAceptarAreaAcademica.Visible = false;
            btnCancelarAreaAcademica.Visible = false;
        }

        private void btnAceptarCarrera_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Carrera VALUES (@IdAgregarCarrera, @NombreCarrera)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@IdAgregarCarrera", txtIdAgregarCarrera.Text);
                command.Parameters.AddWithValue("@NombreCarrera", txtNombreCarrera.Text);

                command.ExecuteNonQuery();
            }
        }

        private void btnAceptarAreaAcademica_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO AreaAcademica VALUES (@IdAgregarAreaAcademica, @IdAreaDocente, @NombreAreaAcademica)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@IdAgregarAreaAcademica", txtIdAgregarAreaAcademica.Text);
                command.Parameters.AddWithValue("@IdAreaDocente", txtIdAreaDocente.Text);
                command.Parameters.AddWithValue("@NombreAreaAcademica", txtNombreAreaAcademica.Text);

                command.ExecuteNonQuery();
            }
        }

        private void btnAceptarAreaAdministrativa_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO AreaAdministrativa VALUES (@IdAgregarAreaAdministrativa, @NombreAreaAdministrativa)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@IdAgregarAreaAdministrativa", txtIdAgregarAreaAdministrativa.Text);
                command.Parameters.AddWithValue("@NombreAreaAdministrativa", txtNombreAreaAdministrativa.Text);

                command.ExecuteNonQuery();
            }
        }

        private void btnCancelarCarrera_Click(object sender, EventArgs e)
        {
            txtIdAgregarCarrera.Text = "";
            txtNombreCarrera.Text = "";
        }

        private void btnCancelarAreaAcademica_Click(object sender, EventArgs e)
        {
            txtIdAgregarAreaAcademica.Text = "";
            txtIdAreaDocente.Text = "";
            txtNombreAreaAcademica.Text = "";
        }

        private void btnCancelarAreaAdministrativa_Click(object sender, EventArgs e)
        {
            txtIdAgregarAreaAdministrativa.Text = "";
            txtNombreAreaAdministrativa.Text = "";
        }

        private void btnAgregarAdministrativo_Click(object sender, EventArgs e)
        {
            //Visibles campos de agregar administrativo
            lblIdAgregarAdministrativo.Visible = true;
            lblIdAreaAdministrativa.Visible = true;
            lblNombreAdministrativo.Visible = true;

            txtIdAgregarAdministrativo.Visible = true;
            txtIdAreaAdministrativa.Visible = true;
            txtNombreAdministrativo.Visible = true;

            btnAceptarAgregarAdministrativo.Visible = true;
            btnCancelarAgregarAdministrativo.Visible = true;

            //Ocultos campos de agregar docente
            lblIdAgregarDocente.Visible = false;
            lblNombreDocente.Visible = false;

            txtIdAgregarDocente.Visible = false;
            txtNombreDocente.Visible = false;

            btnAceptarAgregarDocente.Visible = false;
            btnCancelarAgregarDocente.Visible = false;
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            //Visibles campos de agregar docente
            lblIdAgregarDocente.Visible = true;
            lblNombreDocente.Visible = true;

            txtIdAgregarDocente.Visible = true;
            txtNombreDocente.Visible = true;

            btnAceptarAgregarDocente.Visible = true;
            btnCancelarAgregarDocente.Visible = true;

            //Ocultos campos de agregar administrativo
            lblIdAgregarAdministrativo.Visible = false;
            lblIdAreaAdministrativa.Visible = false;
            lblNombreAdministrativo.Visible = false;

            txtIdAgregarAdministrativo.Visible = false;
            txtIdAreaAdministrativa.Visible = false;
            txtNombreAdministrativo.Visible = false;

            btnAceptarAgregarAdministrativo.Visible = false;
            btnCancelarAgregarAdministrativo.Visible = false;
        }

        private void btnAceptarAgregarAdministrativo_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Administrativo VALUES (@IdAgregarAdministrativo, @IdAreaAdministrativa, @NombreAdministrativo)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@IdAgregarAdministrativo", txtIdAgregarAdministrativo.Text);
                command.Parameters.AddWithValue("@IdAreaAdministrativa", txtIdAreaAdministrativa.Text);
                command.Parameters.AddWithValue("@NombreAdministrativo", txtNombreAdministrativo.Text);

                command.ExecuteNonQuery();
            }
        }

        private void btnAceptarAgregarDocente_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Docente VALUES (@IdAgregarDocente, @NombreDocente)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@IdAgregarDocente", txtIdAgregarDocente.Text);
                command.Parameters.AddWithValue("@NombreDocente", txtNombreDocente.Text);

                command.ExecuteNonQuery();
            }
        }

        private void btnCancelarAgregarAdministrativo_Click(object sender, EventArgs e)
        {
            txtIdAgregarAdministrativo.Text = "";
            txtIdAreaAdministrativa.Text = "";
            txtNombreAdministrativo.Text = "";
        }

        private void btnCancelarAgregarDocente_Click(object sender, EventArgs e)
        {
            txtIdAgregarDocente.Text = "";
            txtNombreDocente.Text = "";
        }

        private void btnFormularioDos_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
