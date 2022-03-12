using Gen3_3Capas.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gen3_3Capas.DAL
{
    public class DALRutas
    {
        //Insertar ruta

        public static long InsRuta(int IdCamion, int IdChofer, int IdOrigen, int IdDestino, double Distancia, DateTime FSalida, DateTime FLlegadaE)
        {
            try
            {
                return DBConnection.ExecuteNonQueryGetIdentity("Rutas_Insertar", "@Camion_id", IdCamion, "@Chofer_id", IdChofer, "@DireccionOrigen_id", IdOrigen, "@DireccionDestino_id", IdDestino, "@Distancia", Distancia, "@FHSalida", FSalida, "@FHLlegadaEstimada", FLlegadaE);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}