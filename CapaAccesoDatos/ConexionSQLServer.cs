using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ConexionSQLServer
    {
        public SqlConnection conexion;
        public ConexionSQLServer()
        {
            this.conexion = new SqlConnection(@"TrustServerCertificate=True;Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=CreditoPreaprobadoCapas;Data Source=PC\SQLEXPRESS");
        }
        public ProcesoAprobacion consultarPuntaje(ProcesoAprobacion proceso)
        {
            conexion.Open();

            string select = "SELECT * FROM creditos_solicitados WHERE numDoc =" + proceso.NroDoc;

            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader reader = comando.ExecuteReader();

            ProcesoAprobacion procesoAprobacion = null;

            while (reader.Read())
            {
                procesoAprobacion = new ProcesoAprobacion();
                procesoAprobacion.Puntaje = int.Parse(reader.GetValue(2).ToString());
            }
            conexion.Close();
            return procesoAprobacion;
        }
    }
}
