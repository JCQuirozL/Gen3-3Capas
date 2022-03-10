using Gen3_3Capas.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gen3_3Capas.Catalogos.Choferes
{
    public partial class EdicionChofer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("ListadoChoferes.aspx");
                }

                int Idchofer = int.Parse(Request.QueryString["Id"]);
                idChofer.Text = Idchofer.ToString();

                ChoferesVO chofer = BLL.BLLChoferes.GetChoferById(Idchofer);
                
                if(chofer.IdChofer == 0)
                {
                    Utils.UtilControls.SweetBoxConfirm("Error", "El chofer no se encuentra en la base de datos", "warning", "ListadoChoferes.aspx", this.Page, this.GetType());
                }
                txtLicencia.Text = chofer.Licencia;
                txtTelefono.Text = chofer.Telefono;
                fechaNacimiento.Value = chofer.FechaNacimiento.ToString("dd/MM/yyyy");
                imgFotoChofer.ImageUrl = chofer.UrlFoto;
                urlFoto.InnerText = chofer.UrlFoto;
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
                    string pathDir = Server.MapPath("~/Imagenes/Choferes/");
                    if (!Directory.Exists(pathDir))
                    {
                        //crea el arbol completo
                        Directory.CreateDirectory(pathDir);
                    }
                    //guardamos la imagen en el directiorio correspondienre 
                    subeImagen.PostedFile.SaveAs(pathDir + FileName);
                    string urlfoto = "/Imagenes/Choferes/" + FileName;
                    urlFoto.InnerText = urlfoto;
                    imgFotoChofer.ImageUrl = urlfoto;
                    btnGurdar.Visible = true;
                }
            }
            else
            {
                Utils.UtilControls.SweetBox("Error!", "Debes subir un archivo", "error", this.Page, this.GetType());
            }
        }

        protected void btnGurdar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdChofer = int.Parse(Request.QueryString["Id"]);
                string telefono = txtTelefono.Text;
                DateTime fNacimiento = DateTime.Parse(fechaNacimiento.Value);
                string licencia = txtLicencia.Text.Trim();
                string urlfoto = urlFoto.InnerText;

                //Mandar llamar la funcion con los argmentos de arriba para guardar el registro
                BLL.BLLChoferes.UpdChofer(IdChofer, licencia, telefono, fNacimiento, null, null, null, urlfoto, null);

                Utils.UtilControls.SweetBoxConfirm("Exito!", "Chofer actualizado exitosamente", "success", "ListadoChoferes.aspx", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                Utils.UtilControls.SweetBox("Error!", ex.ToString(), "error", this.Page, this.GetType());
                throw;
            }
        }
    }
}