using Gen3_3Capas.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Gen3_3Capas.DAL
{
    public class DALCamiones
    {
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        //Listar
        public static List<CamionesVO> GetLstCamiones(bool? paramDisponibilidad)
        {
            try
            {
                //command
                SqlCommand cmd = new SqlCommand("Camiones_Listar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dsCamiones = new DataSet();

                //parámetros

                if (paramDisponibilidad == null)
                {
                    adapter.Fill(dsCamiones);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Disponibilidad", paramDisponibilidad);
                    adapter.Fill(dsCamiones);
                }

                List<CamionesVO> LstCamiones = new List<CamionesVO>();

                foreach (DataRow dr in dsCamiones.Tables[0].Rows)
                {
                    LstCamiones.Add(new CamionesVO(dr));
                }

                return LstCamiones;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Insertar
        public static void InsCamion(string Matricula, string TipoCamion, int Modelo, string Marca, int Capacidad, double Kilometraje, string UrlFoto)
        {
            try
            {
                string Query = "Camiones_Insertar";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Matricula", Matricula);
                cmd.Parameters.AddWithValue("@TipoCamion", TipoCamion);
                cmd.Parameters.AddWithValue("@Modelo", Modelo);
                cmd.Parameters.AddWithValue("@Marca", Marca);
                cmd.Parameters.AddWithValue("@Capacidad", Capacidad);
                cmd.Parameters.AddWithValue("@Kilometraje", Kilometraje);
                cmd.Parameters.AddWithValue("@UrlFoto", UrlFoto);

                conn.Open();
                cmd.ExecuteNonQuery(); //Ejecuta sin requerir valor de retorno
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        //Actualizar
        public static void UpdCamion(int Id, string Matricula, string TipoCamion, int? Modelo, string Marca, int? Capacidad, double? Kilometraje, bool? Disponibilidad, string UrlFoto)
        {
            try
            {
                string Query = "Camiones_Actualizar";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@Matricula", Matricula);
                cmd.Parameters.AddWithValue("@TipoCamion", TipoCamion);
                cmd.Parameters.AddWithValue("@Modelo", Modelo);
                cmd.Parameters.AddWithValue("@Marca", Marca);
                cmd.Parameters.AddWithValue("@Capacidad", Capacidad);
                cmd.Parameters.AddWithValue("@Kilometraje", Kilometraje);
                cmd.Parameters.AddWithValue("@Disponibilidad", Disponibilidad);
                cmd.Parameters.AddWithValue("@UrlFoto", UrlFoto);

                conn.Open();
                cmd.ExecuteNonQuery(); //Ejecuta sin requerir valor de retorno
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        //Borrar

        public static void DelCamion(int id)
        {
            try
            {
                string Query = "Camiones_Eliminar";

                SqlCommand cmd = new SqlCommand(Query, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        //GetById
        public static CamionesVO GetCamionById(int id)
        {
            try
            {
                string Query = "Camiones_GetByID";

                SqlCommand cmd = new SqlCommand(Query, conn);

                cmd.Connection = conn;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                DataSet dsCamion = new DataSet();
                adapter.Fill(dsCamion); //Llenar con la consulta

                if (dsCamion.Tables[0].Rows.Count > 0)
                {
                    //Se encontró el registro
                    DataRow dr = dsCamion.Tables[0].Rows[0];
                    CamionesVO Camion = new CamionesVO(dr);

                    return Camion;
                }
                else
                {
                    //La tabla está vacía
                    CamionesVO Camion = new CamionesVO();
                    return Camion;
                }
                
            }
            catch (Exception Ex)
            {

                throw;
            }
        }

      
    }
}