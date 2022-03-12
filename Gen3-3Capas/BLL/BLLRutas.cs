using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gen3_3Capas.BLL
{
    public class BLLRutas
    {
        //Insertar
        public static long InsRuta(int IdCamion, int IdChofer, int IdOrigen, int IdDestino, double Distancia, DateTime FSalida, DateTime FLlegadaE)
        {
            //Primero actualizar el camión para poner su disponibilidad en FALSE, ya que se le va a aasignar una ruta
            DAL.DALCamiones.UpdCamion(IdCamion, null, null, null, null, null, null, false, null);

            //Despues, el chofer tambien se le mdifica la disponibilidad por la misma razón
            DAL.DALChoferes.UpdChofer(IdChofer, null, null, null, null, null, null, null, false);

            return DAL.DALRutas.InsRuta(IdCamion, IdChofer, IdOrigen, IdDestino, Distancia, FSalida, FLlegadaE);
        }
    }
}