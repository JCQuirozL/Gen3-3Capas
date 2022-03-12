using Gen3_3Capas.BLL;
using Gen3_3Capas.DAL;
using Gen3_3Capas.VO;
using System;
using System.Collections.Generic;

namespace Gen3_3Capas.Catalogos.Rutas
{
    public partial class AltaRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarChofer(true);
                LlenarCamion(true);
                CargaCapacidad();
            }
            
        }

        private void LlenarChofer(bool disp)
        {
            List<ChoferesVO> ListaChoferes = BLL.BLLChoferes.GetLstChoferes(disp);
            Utils.UtilControls.FillDropDownList(DDLChofer, DDLChofer.DataValueField, DDLChofer.DataTextField, ListaChoferes);
        }

        private void LlenarCamion(bool disp)
        {
            List<CamionesVO> ListaCamiones = BLL.BLLCamiones.GetLstCamiones(disp);
            Utils.UtilControls.FillDropDownList(DDLCamion, DDLCamion.DataValueField, DDLCamion.DataTextField, ListaCamiones);
        }

        protected void btnGuardarDir_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardar datos 

                string calle = txtCalle.Text;
                string numero = txtNumero.Text;
                string colonia = txtColonia.Text;
                string ciudad = txtCiudad.Text;
                string estado = txtEstado.Text;
                string cp = txtCP.Text;

                //consumir el WS
                WSReference.WSRutasSoapClient webService = new WSReference.WSRutasSoapClient();
                int idDireccion = webService.insDireccion(calle, numero, colonia, ciudad, estado, cp);
                if (txtEsOD.Text == "1")
                {//Es Origen
                    Session["IdOrigen"] = idDireccion.ToString();
                    MPOrigen.Hide();

                }
                else
                {
                    //Es Destino
                    Session["IdDestino"] = idDireccion.ToString();
                    MPDestino.Hide();
                }

                LimpiarDireccion();


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void LimpiarDireccion()
        {
            txtEsOD.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtColonia.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCP.Text = string.Empty;
        }

        protected void btnAddCarga_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void DDLCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaCapacidad();
        }

        private void CargaCapacidad()
        {
            int idCamion = int.Parse(DDLCamion.SelectedValue);
            CamionesVO camion = BLLCamiones.GetById(idCamion);
            txtCapCamion.Text = camion.Capacidad.ToString();
        }
    }
}