using Gen3_3Capas.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gen3_3Capas.Catalogos.Camiones
{
    public partial class EdicionCamion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("ListadoCamiones.aspx");
                }

                int IdCamion = int.Parse(Request.QueryString["Id"]);
                idCamion.Text = IdCamion.ToString();

                CamionesVO camion = BLL.BLLCamiones.GetById(IdCamion);

                if (camion.Id == 0)
                {
                    Utils.UtilControls.SweetBoxConfirm("Error", "El camión no se encuentra en la base de datos", "warning", "ListadoCamiones.aspx", this.Page, this.GetType());
                }
                txtMatricula.Text = camion.Matricula;
                imgFotoCamion.ImageUrl = camion.UrlFoto;
                urlFoto.InnerText = camion.UrlFoto;
                chkDisponibilidad.Checked = camion.Disponibilidad;
            }
        }

        protected void btnSubeImagen_Click(object sender, EventArgs e)
        {
            //validar que el usraio haya seleccionadop una imaden
            if (subeImagen.Value != "")
            {
                //asignar a una variable el nombre del aqrchofvo seleciconado
                string FileName = Path.GetFileName(subeImagen.PostedFile.FileName);
                //validar que el archivo sea .jpg o .png
                string FileExt = Path.GetExtension(FileName).ToLower();
                if ((FileExt != ".jpg") && (FileExt != ".png"))
                {
                    Utils.UtilControls.SweetBox("Error!", "Seleccione un archivo válido de imágen", "error", this.Page, this.GetType());
                }
                else
                {
                    //Verificar que le directorio donde va,os a guarddar exista
                    string pathDir = Server.MapPath("~/Imagenes/Camiones/");
                    if (!Directory.Exists(pathDir))
                    {
                        //crea el arbol completo
                        Directory.CreateDirectory(pathDir);
                    }
                    //guardamos la imagen en el directiorio correspondienre 
                    subeImagen.PostedFile.SaveAs(pathDir + FileName);
                    string urlfoto = "/Imagenes/Camiones/" + FileName;
                    urlFoto.InnerText = urlfoto;
                    imgFotoCamion.ImageUrl = urlfoto;
                    btnGuardar.Visible = true;
                }
            }
            else
            {
                Utils.UtilControls.SweetBox("Error!", "Debes subir un archivo", "error", this.Page, this.GetType());
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdCamion = int.Parse(Request.QueryString["Id"]);
                string matricula = txtMatricula.Text;
                string urlfoto = urlFoto.InnerText;
                bool disponible = chkDisponibilidad.Checked;

                //Mandar llamar la funcion con los argmentos de arriba para guardar el registro
                BLL.BLLCamiones.UpdCamion(IdCamion,matricula,null,null,null,null,null,disponible,urlfoto);

                Utils.UtilControls.SweetBoxConfirm("Exito!", "Camión actualizado exitosamente", "success", "ListadoCamiones.aspx", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                Utils.UtilControls.SweetBox("Error!", ex.ToString(), "error", this.Page, this.GetType());
                throw;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoCamiones.aspx");
        }
    }
}