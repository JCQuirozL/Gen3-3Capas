using Gen3_3Capas.DAL;
using Gen3_3Capas.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gen3_3Capas.BLL
{
    public class BLLChoferes
    {
        //Listar
        public static List<ChoferesVO> GetLstChoferes(bool? paramDisponibilidad)
        {
            return DALChoferes.GetLstChoferes(paramDisponibilidad);
        }
        //Insertar

        public static void InsChofer(string paramLicencia, string paramTelefono, DateTime paramFechaNacimiento, string paramNombre, string ApPaterno, string ApMaterno, string paramUrlFoto)
        {
            try
            {
                DALChoferes.InsChofer(paramLicencia, paramTelefono, paramFechaNacimiento, paramNombre, ApPaterno, ApMaterno, paramUrlFoto);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Actualizar
        public static void UpdChofer(int id, string paramLicencia, string paramTelefono, DateTime? paramFechaNacimiento, string paramNombre, string ApPaterno, string ApMaterno, string paramUrlFoto, bool? paramDisponibilidad)
        {
            try
            {
                DALChoferes.UpdChofer(id,paramLicencia, paramTelefono, paramFechaNacimiento, paramNombre, ApPaterno, ApMaterno, paramUrlFoto,paramDisponibilidad);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //Eliminar

        public static string DelChofer(int id)
        {
            try
            {
                //verificar la disponibilidad del chofeer
                ChoferesVO chofer = DALChoferes.GetChoferById(id);
                if (chofer.Disponibilidad)
                {
                    DALChoferes.DelChofer(id);
                    return "1";
                }
                else
                {
                    return "0";
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        //GetById
        public static ChoferesVO GetChoferById(int id)
        {
            return DALChoferes.GetChoferById(id);
        }
    }
}