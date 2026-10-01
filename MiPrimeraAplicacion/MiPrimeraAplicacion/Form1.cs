using System;
using System.Data;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        Conexion cn = new Conexion();
        DataSet ds = new DataSet();
        int pos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void Mostrar(int i)
        {
            txtCodigoAlumno.Text = ds.Tables["alumnos"].Rows[i]["codigo"].ToString();
            txtNombreAlumno.Text = ds.Tables["alumnos"].Rows[i]["nombre"].ToString();
            txtDireccionAlumno.Text = ds.Tables["alumnos"].Rows[i]["direccion"].ToString();
            txtTelefonoAlumno.Text = ds.Tables["alumnos"].Rows[i]["telefono"].ToString();
            txtEmailAlumno.Text = ds.Tables["alumnos"].Rows[i]["email"].ToString();
            lblRegistrosAlumnos.Text = (i + 1) + " de " + ds.Tables["alumnos"].Rows.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = cn.obtenerDatos();
            if (ds.Tables["alumnos"].Rows.Count > 0) Mostrar(0);
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e) { pos = 0; Mostrar(pos); }
        private void btnAnteriorAlumno_Click(object sender, EventArgs e) { if (pos > 0) { pos--; Mostrar(pos); } }
        private void btnSiguienteAlumno_Click(object sender, EventArgs e) { if (pos < ds.Tables["alumnos"].Rows.Count - 1) { pos++; Mostrar(pos); } }
        private void btnUltimoAlumno_Click(object sender, EventArgs e) { pos = ds.Tables["alumnos"].Rows.Count - 1; Mostrar(pos); }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}