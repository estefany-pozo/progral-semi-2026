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
        private void InitializeComponent()
        {
            this.grbAlumnos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailAlumno = new System.Windows.Forms.TextBox();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.lblRegistrosAlumnos = new System.Windows.Forms.Label();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grbAlumnos.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAlumnos
            // 
            this.grbAlumnos.Controls.Add(this.lblCodigo);
            this.grbAlumnos.Controls.Add(this.txtCodigoAlumno);
            this.grbAlumnos.Controls.Add(this.lblNombre);
            this.grbAlumnos.Controls.Add(this.txtNombreAlumno);
            this.grbAlumnos.Controls.Add(this.lblDireccion);
            this.grbAlumnos.Controls.Add(this.txtDireccionAlumno);
            this.grbAlumnos.Controls.Add(this.lblTelefono);
            this.grbAlumnos.Controls.Add(this.txtTelefonoAlumno);
            this.grbAlumnos.Controls.Add(this.lblEmail);
            this.grbAlumnos.Controls.Add(this.txtEmailAlumno);
            this.grbAlumnos.Location = new System.Drawing.Point(20, 20);
            this.grbAlumnos.Name = "grbAlumnos";
            this.grbAlumnos.Size = new System.Drawing.Size(460, 280);
            this.grbAlumnos.TabIndex = 0;
            this.grbAlumnos.TabStop = false;
            this.grbAlumnos.Text = "DATOS";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(20, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(110, 32);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(150, 20);
            this.txtCodigoAlumno.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(20, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(110, 67);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(320, 20);
            this.txtNombreAlumno.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(20, 110);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "DIRECCION:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(110, 105);
            this.txtDireccionAlumno.Multiline = true;
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(320, 60);
            this.txtDireccionAlumno.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(20, 185);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(80, 15);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "TELEFONO:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(110, 182);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(150, 20);
            this.txtTelefonoAlumno.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 15);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "EMAIL:";
            // 
            // txtEmailAlumno
            // 
            this.txtEmailAlumno.Location = new System.Drawing.Point(110, 217);
            this.txtEmailAlumno.Name = "txtEmailAlumno";
            this.txtEmailAlumno.Size = new System.Drawing.Size(150, 20);
            this.txtEmailAlumno.TabIndex = 9;
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacion.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacion.Controls.Add(this.lblRegistrosAlumnos);
            this.grbNavegacion.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacion.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacion.Location = new System.Drawing.Point(20, 310);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(220, 75);
            this.grbNavegacion.TabIndex = 1;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(10, 25);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(35, 30);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(45, 25);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(35, 30);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // lblRegistrosAlumnos
            // 
            this.lblRegistrosAlumnos.Location = new System.Drawing.Point(88, 32);
            this.lblRegistrosAlumnos.Name = "lblRegistrosAlumnos";
            this.lblRegistrosAlumnos.Size = new System.Drawing.Size(45, 15);
            this.lblRegistrosAlumnos.TabIndex = 2;
            this.lblRegistrosAlumnos.Text = "x de n";
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(135, 25);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(35, 30);
            this.btnSiguienteAlumno.TabIndex = 3;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Location = new System.Drawing.Point(170, 25);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(35, 30);
            this.btnUltimoAlumno.TabIndex = 4;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnAgregar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Location = new System.Drawing.Point(260, 310);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(220, 75);
            this.grbEdicion.TabIndex = 2;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(110, 25);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(504, 411);
            this.Controls.Add(this.grbAlumnos);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbEdicion);
            this.Name = "Form1";
            this.Text = "Administracion de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbAlumnos.ResumeLayout(false);
            this.grbAlumnos.PerformLayout();
            this.grbNavegacion.ResumeLayout(false);
            this.grbEdicion.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox grbAlumnos;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.TextBox txtEmailAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Label lblRegistrosAlumnos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
    }
}