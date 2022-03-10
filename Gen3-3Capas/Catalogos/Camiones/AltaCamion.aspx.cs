using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gen3_3Capas.Catalogos.Camiones
{
    public partial class AltaCamion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //llenar DDLTipoCamion
                Utils.UtilControls.EnumToListBox(typeof(Tipo), DDLTipoCamion, false);

                //llenar DDLMarca
                Utils.UtilControls.EnumToListBox(typeof(Marca), DDLMarca, false);

                LlenaModelo();
            }
        }

        private void LlenaModelo()
        {
            //Llenado del DDLModelo
            int Minimo = DateTime.Now.Year - 20;
            int Maximo = DateTime.Now.Year + 2;
            var Rango = Enumerable.Range(Minimo, Maximo - Minimo);
            DDLModelo.DataSource = Rango;
            DDLModelo.DataBind();
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
                string Matricula = txtMatricula.Text;
                string TipoCamion = DDLTipoCamion.SelectedValue;
                int Modelo = int.Parse(DDLModelo.SelectedValue);
                string Marca = DDLMarca.SelectedValue;
                int Capacidad= int.Parse(txtCapacidad.Text);
                double Km = double.Parse(txtKilometraje.Text);
                string UrlFoto = urlFoto.InnerText;

                string resultado = BLL.BLLCamiones.InsCamion(Matricula, TipoCamion, Modelo, Marca, Capacidad, Km, UrlFoto);

                if(resultado.IndexOf("Camión ingresado") > -1) // es igual a poner resultado.Equals("Camión ingresado")
                {
                    Utils.UtilControls.SweetBoxConfirm("OK!", resultado, "success", "ListadoCamiones.aspx", this.Page, this.GetType());
                }
                else
                {
                    //Msj Error
                    Utils.UtilControls.SweetBox("Atención!", resultado, "warning", this.Page, this.GetType());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}