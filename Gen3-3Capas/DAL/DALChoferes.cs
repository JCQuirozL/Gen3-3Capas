using Gen3_3Capas.Utils;
using Gen3_3Capas.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Gen3_3Capas.DAL
{
    public class DALChoferes
    {
        //Listar
        public static List<ChoferesVO> GetLstChoferes(bool? paramDisponibilidad)
        {
            try
            {
                //Obtener  la lista de choferes
                //Declaramos un DataSet
                DataSet dsChoferes;
                //VErificar la disponibilidad 
                if (paramDisponibilidad == null)
                {
                    //Obtenemos todos las choferes de la BD
                    dsChoferes = DBConnection.ExecuteDataSet("Choferes_Listar");
                }
                else
                {
                    //Obtenemos choferes segun disponibilidad (paramDisponibilidad)
                    dsChoferes = DBConnection.ExecuteDataSet("Choferes_Listar", "@Disponibilidad", paramDisponibilidad);
                }

                //Declaramos la lista a retornar
                List<ChoferesVO> ListaChoferes = new List<ChoferesVO>();

                //Recorremos el dataset para llenar la lista
                foreach(DataRow dr in dsChoferes.Tables[0].Rows)
                {
                    ListaChoferes.Add(new ChoferesVO(dr));
                }

                return ListaChoferes;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //Insertar
        public static void InsChofer(string paramLicencia, string paramTelefono, DateTime paramFechaNacimiento, string paramNombre, string ApPaterno, string ApMaterno, string paramUrlFoto)
        {
            try
            {
                DBConnection.ExecuteNonQuery("Choferes_Insertar","@Nombre", paramNombre, "@ApPaterno", ApPaterno, "@Apmaterno", ApMaterno, "@Telefono", paramTelefono, "@FechaNac", paramFechaNacimiento, "@Licencia", paramLicencia, "@UrlFoto", paramUrlFoto);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Actualizar 
        public static void UpdChofer(int paramIdChofer, string paramLicencia, string paramTelefono, DateTime? paramFechaNacimiento, string paramNombre, string ApPaterno, string ApMaterno, string paramUrlFoto, bool? paramDisponibilidad)
        {
            try
            {
                DBConnection.ExecuteNonQuery("Choferes_Actualizar","@id",paramIdChofer,"@Nombre", paramNombre, "@ApPaterno", ApPaterno, "@Apmaterno", ApMaterno, "@Telefono", paramTelefono, "@FechaNac", paramFechaNacimiento, "@Licencia", paramLicencia, "@UrlFoto", paramUrlFoto, "@Disponibilidad", paramDisponibilidad);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //Eliminar
        public static void DelChofer(int paramIdChofer)
        {
            try
            {
                DBConnection.ExecuteNonQuery("Choferes_Eliminar", "@id", paramIdChofer);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //GetById
        public static ChoferesVO GetChoferById(int paramIdChofer)
        {
            try
            {
                DataSet dsChofer = DBConnection.ExecuteDataSet("Choferes_GetById", "@id", paramIdChofer);

                if(dsChofer.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsChofer.Tables[0].Rows[0];
                    ChoferesVO Chofer = new ChoferesVO(dr);
                    return Chofer;
                }
                else
                {
                    ChoferesVO Chofer = new ChoferesVO();
                    return Chofer;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool ChoferEnRuta(int id)
        {
            try
            {
                //LLamar al Store Procedure "Chofer_EnRuta de la BDD"
                DataSet dsChofer = DBConnection.ExecuteDataSet("Chofer_EnRuta", "@id", id);

                //Si encontró registros entonces quiere decir que encontró choferes asignados a alguna ruta
                if(dsChofer.Tables[0].Rows.Count > 0)
                {
                    //Por lógica de negocio no puedes eliminar un chofer que históricamente está en la tabla rutas
                    return true;
                }
                else
                {
                    //Devolvemos false para posteriormente eliminar
                    return false;
                }
            }
            catch (Exception ex)
            {
               
                throw;
            }

           
        }
    }
}