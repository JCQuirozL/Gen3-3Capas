using Gen3_3Capas.DAL;
using Gen3_3Capas.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gen3_3Capas.BLL
{
    public class BLLCamiones
    {
        //Listar
        public static List<CamionesVO> GetLstCamiones(bool? Disponibilidad)
        {
            return DALCamiones.GetLstCamiones(Disponibilidad);
        }

        //Insertar
        public static string InsCamion(string Matricula, string TipoCamion, int Modelo, string Marca, int Capacidad, double Kilometraje, string UrlFoto)
        {
            //No se puede repetir la matrícula
            try
            {
                List<CamionesVO> LstCamiones = DALCamiones.GetLstCamiones(null);

                bool existe = false;

                foreach (CamionesVO item in LstCamiones)
                {
                    if (item.Matricula == Matricula)
                    {
                        existe = true;
                    }
                }
                if (existe)
                {
                    return "La matrícula del camion ya fue utilizada con anterioridad";
                }
                else
                {
                    DALCamiones.InsCamion(Matricula, TipoCamion, Modelo, Marca, Capacidad, Kilometraje, UrlFoto);

                    return "Camión ingresado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string UpdCamion(int id, string Matricula, string TipoCamion, int? Modelo, string Marca, int? Capacidad, double? Kilometraje, bool? Disponibilidad, string UrlFoto)
        {
            //No se puede repetir la matrícula
            try
            {
                List<CamionesVO> LstCamiones = DALCamiones.GetLstCamiones(null);

                bool existe = false;

                foreach (CamionesVO item in LstCamiones)
                {
                    if (item.Matricula == Matricula && item.Id != id)
                    {
                        existe = true;
                    }
                }
                if (existe)
                {
                    return "La matrícula del camion ya fue utilizada con anterioridad";
                }
                else
                {
                    DALCamiones.UpdCamion(id, Matricula, TipoCamion, Modelo, Marca, Capacidad, Kilometraje, Disponibilidad, UrlFoto);

                    return "Camión actualizado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string DelCamion(int id)
        {
            //Borrar solo si el camión está disponible

            try
            {
               

                bool enRuta = DAL.DALCamiones.CamionEnRuta(id);
                if (!enRuta)
                {
                    CamionesVO camiones = DALCamiones.GetCamionById(id);
                    if (camiones.Disponibilidad)
                    {
                        DALCamiones.DelCamion(id);
                        return "Camión eliminado";
                    }
                    else
                    {
                        return "El camión no está disponible";
                    }
                }
                else
                {
                    return "El camión se encuentra en una ruta";
                }

               
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static CamionesVO GetById(int id)
        {
            return DAL.DALCamiones.GetCamionById(id);
        }
    }
}