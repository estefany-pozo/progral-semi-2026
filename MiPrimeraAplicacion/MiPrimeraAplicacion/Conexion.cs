using System.Data;
using System.Data.SqlClient;
namespace MiPrimeraAplicacion
{
    class Conexion
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_base de datos.mdf;Integrated Security=True");
        public DataSet obtenerDatos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM alumnos", cn);
            DataSet ds = new DataSet(); da.Fill(ds, "alumnos"); return ds;
        }
        public void insertar(string codigo, string nombre, string dir, string tel)
        {
            cn.Open(); new SqlCommand($"INSERT INTO alumnos(codigo,nombre,direccion,telefono) VALUES('{codigo}','{nombre}','{dir}','{tel}')", cn).ExecuteNonQuery(); cn.Close();
        }
        public void actualizar(int id, string codigo, string nombre, string dir, string tel)
        {
            cn.Open(); new SqlCommand($"UPDATE alumnos SET codigo='{codigo}', nombre='{nombre}', direccion='{dir}', telefono='{tel}' WHERE id={id}", cn).ExecuteNonQuery(); cn.Close();
        }
        public void eliminar(int id)
        {
            cn.Open(); new SqlCommand($"DELETE FROM alumnos WHERE id={id}", cn).ExecuteNonQuery(); cn.Close();
        }
    }
}