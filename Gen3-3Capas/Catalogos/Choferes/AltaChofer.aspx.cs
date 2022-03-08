using System;
using System.IO;


namespace Gen3_3Capas.Catalogos.Choferes
{
    public partial class AltaChofer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                    Utils.UtilControls.SweetBox("Error!", "Seleccione un archivo válido de imágen","error", this.Page, this.GetType());
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
                string nombre =  txtNombre.Text.Trim();
                string apPaterno = txtApPaterno.Text.Trim();
                string apMaterno = txtApPaterno.Text.Trim();
                string telefono = txtTelefono.Text;
                DateTime fNacimiento = DateTime.Parse(fechaNacimiento.Value);
                string licencia = txtLicencia.Text.Trim();
                string urlfoto = urlFoto.InnerText;

                //Mandar llamar la funcion con los argmentos de arriba para guardar el registro
                BLL.BLLChoferes.InsChofer(licencia, telefono, fNacimiento, nombre, apPaterno, apMaterno, urlfoto);

                Utils.UtilControls.SweetBoxConfirm("Exito!", "Chofer agregado exitosamente","success","ListadoChoferes.aspx", this.Page,this.GetType());
            }
            catch (Exception ex)
            {
                Utils.UtilControls.SweetBox("Error!", ex.ToString(), "error", this.Page, this.GetType());
                throw;
            }
        }
    }
}