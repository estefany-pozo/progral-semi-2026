using System;
using System.Data;
using System.Windows.Forms;
namespace MiPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        Conexion con = new Conexion(); DataSet ds; int pos = 0;
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { Cargar(); }
        void Cargar() { ds = con.obtenerDatos(); dgvAlumnos.DataSource = ds.Tables["alumnos"]; if (ds.Tables["alumnos"].Rows.Count > 0) Mostrar(0); }
        void Mostrar(int i)
        {
            if (i < 0 || i >= ds.Tables["alumnos"].Rows.Count) return;
            pos = i;
            txtId.Text = ds.Tables["alumnos"].Rows[i]["id"].ToString();
            txtCodigoAlumno.Text = ds.Tables["alumnos"].Rows[i]["codigo"].ToString();
            txtNombreAlumno.Text = ds.Tables["alumnos"].Rows[i]["nombre"].ToString();
            txtDireccionAlumno.Text = ds.Tables["alumnos"].Rows[i]["direccion"].ToString();
            txtTelefonoAlumno.Text = ds.Tables["alumnos"].Rows[i]["telefono"].ToString();
            lblRegistrosAlumnos.Text = (i + 1) + " de " + ds.Tables["alumnos"].Rows.Count;
        }
        private void btnPrimeroAlumno_Click(object sender, EventArgs e) { Mostrar(0); }
        private void btnAnteriorAlumno_Click(object sender, EventArgs e) { if (pos > 0) Mostrar(pos - 1); }
        private void btnSiguienteAlumno_Click(object sender, EventArgs e) { if (pos < ds.Tables["alumnos"].Rows.Count - 1) Mostrar(pos + 1); }
        private void btnUltimoAlumno_Click(object sender, EventArgs e) { Mostrar(ds.Tables["alumnos"].Rows.Count - 1); }
        private void dgvAlumnos_Click(object sender, EventArgs e) { if (dgvAlumnos.CurrentRow != null) Mostrar(dgvAlumnos.CurrentRow.Index); }
        private void btnNuevo_Click(object sender, EventArgs e) { con.insertar(txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text, txtTelefonoAlumno.Text); Cargar(); }
        private void btnModificar_Click(object sender, EventArgs e) { con.actualizar(int.Parse(txtId.Text), txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text, txtTelefonoAlumno.Text); Cargar(); }
        private void btnEliminar_Click(object sender, EventArgs e) { con.eliminar(int.Parse(txtId.Text)); Cargar(); }
    }
}