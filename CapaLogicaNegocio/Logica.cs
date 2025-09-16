using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class Logica
    {
        private ConexionSQLServer accesoDatos = new ConexionSQLServer();

        public bool verificarMeses(int meses)
        {
            if(meses < 1 ||  meses > 72)
            {
                 return false;
            }
            else
            {
                return true;
            }
        }
        public int calculoBalanza(int ingresosTotales, int egresosTotales)
        {
            int balanza = (ingresosTotales - egresosTotales);

            if(balanza <= 0)
            {
                return 0;
            }
            else
            {
                return balanza;
            }
        }
        public double calculoRelacionCreditoBalanza(int montoSolicitado, int meses, int balanza)
        {
            double relacionCreditoBalanza = (montoSolicitado/meses)/balanza;

            return relacionCreditoBalanza;
        }

        public int consultarPuntaje(ProcesoAprobacion puntaje)
        {
            return accesoDatos.consultarPuntaje(puntaje).Puntaje;
        }
    }
}
