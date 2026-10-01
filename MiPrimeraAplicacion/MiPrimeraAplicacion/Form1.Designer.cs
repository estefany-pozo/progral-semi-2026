namespace MiPrimeraAplicacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // groupBox1 DATOS
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 250);
            this.groupBox1.Text = "DATOS";
            // labels y txt
            this.label1.Text = "ID"; this.label1.Location = new System.Drawing.Point(15, 30);
            this.txtId.Location = new System.Drawing.Point(100, 27); this.txtId.Name = "txtId"; this.txtId.ReadOnly = true; this.txtId.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "CODIGO"; this.label2.Location = new System.Drawing.Point(15, 60);
            this.txtCodigo.Location = new System.Drawing.Point(100, 57); this.txtCodigo.Name = "txtCodigoAlumno"; this.txtCodigo.Size = new System.Drawing.Size(200, 20);
            this.label3.Text = "NOMBRE"; this.label3.Location = new System.Drawing.Point(15, 90);
            this.txtNombre.Location = new System.Drawing.Point(100, 87); this.txtNombre.Name = "txtNombreAlumno"; this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.label4.Text = "DIRECCION"; this.label4.Location = new System.Drawing.Point(15, 120);
            this.txtDireccion.Location = new System.Drawing.Point(100, 117); this.txtDireccion.Name = "txtDireccionAlumno"; this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.label5.Text = "TEL"; this.label5.Location = new System.Drawing.Point(15, 150);
            this.txtTelefono.Location = new System.Drawing.Point(100, 147); this.txtTelefono.Name = "txtTelefonoAlumno"; this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            // groupBox2 Busqueda
            this.groupBox2.Controls.Add(this.dgvAlumnos);
            this.groupBox2.Location = new System.Drawing.Point(380, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 250);
            this.groupBox2.Text = "Busqueda Alumnos";
            this.dgvAlumnos.Location = new System.Drawing.Point(10, 20); this.dgvAlumnos.Size = new System.Drawing.Size(380, 220); this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true; this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Click += new System.EventHandler(this.dgvAlumnos_Click);
            // groupBox3 Navegacion
            this.groupBox3.Controls.Add(this.lblRegistros); this.groupBox3.Controls.Add(this.btnUltimo); this.groupBox3.Controls.Add(this.btnSiguiente); this.groupBox3.Controls.Add(this.btnAnterior); this.groupBox3.Controls.Add(this.btnPrimero);
            this.groupBox3.Location = new System.Drawing.Point(12, 280); this.groupBox3.Name = "groupBox3"; this.groupBox3.Size = new System.Drawing.Size(250, 70); this.groupBox3.Text = "Navegacion";
            this.btnPrimero.Location = new System.Drawing.Point(10, 30); this.btnPrimero.Name = "btnPrimeroAlumno"; this.btnPrimero.Size = new System.Drawing.Size(35, 23); this.btnPrimero.Text = "|<"; this.btnPrimero.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            this.btnAnterior.Location = new System.Drawing.Point(50, 30); this.btnAnterior.Name = "btnAnteriorAlumno"; this.btnAnterior.Size = new System.Drawing.Size(35, 23); this.btnAnterior.Text = "<"; this.btnAnterior.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            this.lblRegistros.Location = new System.Drawing.Point(90, 35); this.lblRegistros.Name = "lblRegistrosAlumnos"; this.lblRegistros.AutoSize = true; this.lblRegistros.Text = "1 de 2";
            this.btnSiguiente.Location = new System.Drawing.Point(140, 30); this.btnSiguiente.Name = "btnSiguienteAlumno"; this.btnSiguiente.Size = new System.Drawing.Size(35, 23); this.btnSiguiente.Text = ">"; this.btnSiguiente.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            this.btnUltimo.Location = new System.Drawing.Point(180, 30); this.btnUltimo.Name = "btnUltimoAlumno"; this.btnUltimo.Size = new System.Drawing.Size(35, 23); this.btnUltimo.Text = ">|"; this.btnUltimo.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // groupBox4 Edicion
            this.groupBox4.Controls.Add(this.btnEliminar); this.groupBox4.Controls.Add(this.btnModificar); this.groupBox4.Controls.Add(this.btnNuevo);
            this.groupBox4.Location = new System.Drawing.Point(280, 280); this.groupBox4.Name = "groupBox4"; this.groupBox4.Size = new System.Drawing.Size(300, 70); this.groupBox4.Text = "Edicion";
            this.btnNuevo.Location = new System.Drawing.Point(15, 30); this.btnNuevo.Name = "btnNuevo"; this.btnNuevo.Size = new System.Drawing.Size(75, 23); this.btnNuevo.Text = "Nuevo"; this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnModificar.Location = new System.Drawing.Point(105, 30); this.btnModificar.Name = "btnModificar"; this.btnModificar.Size = new System.Drawing.Size(75, 23); this.btnModificar.Text = "Modificar"; this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnEliminar.Location = new System.Drawing.Point(195, 30); this.btnEliminar.Name = "btnEliminar"; this.btnEliminar.Size = new System.Drawing.Size(75, 23); this.btnEliminar.Text = "Eliminar"; this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // Form1
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.groupBox1); this.Controls.Add(this.groupBox2); this.Controls.Add(this.groupBox3); this.Controls.Add(this.groupBox4);
            this.Name = "Form1"; this.Text = "ADMINISTRACION DE ALUMNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false); this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.Label lblRegistrosAlumnos;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
    }
}