using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gen3_3Capas.Catalogos.Camiones
{
    public partial class ListadoCamiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    RefrescaGrid();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        protected void GVCamiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Eliminar el camión
            string id = GVCamiones.DataKeys[e.RowIndex].Values["Id"].ToString();
            string resultado = BLL.BLLCamiones.DelCamion(int.Parse(id));

            if (resultado.Equals("Camión eliminado"))
            {
                Utils.UtilControls.SweetBox("Camión eliminado con éxito", "", "success", this.Page, this.GetType());

                RefrescaGrid();
            }
            else if (resultado.Equals("El camión no está disponible"))
            {
                Utils.UtilControls.SweetBox("Camión no pudo ser eliminado", "El camión no está disponible", "error", this.Page, this.GetType());

                RefrescaGrid();
            }
            else if (resultado.Equals("El camión se encuentra en una ruta"))
            {
                Utils.UtilControls.SweetBox("Camión no pudo ser eliminado", "El camión historicamente está asignado en una ruta", "error", this.Page, this.GetType());

                RefrescaGrid();
            }
        }

        protected void GVCamiones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Salir del modo edición
            GVCamiones.EditIndex = -1;
            RefrescaGrid();
        }

        protected void GVCamiones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //antes del modo edición
            Label lblTipoCamion = (Label)GVCamiones.Rows[e.NewEditIndex].FindControl("lblTipoCamion");

            string tipoCamion = lblTipoCamion.Text;

            Label lblMarcaCamion = (Label)GVCamiones.Rows[e.NewEditIndex].FindControl("lblMarca");
            string marcaCamion = lblMarcaCamion.Text;

            Label lblModeloCamion = (Label)GVCamiones.Rows[e.NewEditIndex].FindControl("lblModelo");
            string modeloCamion = lblModeloCamion.Text;

            //Entrar en modo edición del renglón sleccionado
            GVCamiones.EditIndex = e.NewEditIndex;
            RefrescaGrid();

            //después del modo edición
            DropDownList DDLTipoCamionAux = (DropDownList)GVCamiones.Rows[e.NewEditIndex].FindControl("DDLTipoCamion");
            Utils.UtilControls.EnumToListBox(typeof(Tipo), DDLTipoCamionAux, false);

            DropDownList DDLMarcaCamionAux = (DropDownList)GVCamiones.Rows[e.NewEditIndex].FindControl("DDLMarca");
            Utils.UtilControls.EnumToListBox(typeof(Marca), DDLMarcaCamionAux, false);

            DropDownList DDLModeloCamionAux = (DropDownList)GVCamiones.Rows[e.NewEditIndex].FindControl("DDLModelo");

            int minimo = DateTime.Now.Year - 20;
            int maximo = DateTime.Now.Year + 2;
            var rango = Enumerable.Range(minimo, maximo - minimo);

            DDLModeloCamionAux.DataSource = rango;
            DDLModeloCamionAux.DataBind();
            DDLTipoCamionAux.SelectedValue = tipoCamion;
            DDLMarcaCamionAux.SelectedValue = marcaCamion;
            DDLModeloCamionAux.SelectedValue = modeloCamion;


        }

        protected void GVCamiones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = int.Parse(e.CommandArgument.ToString());//referencia al renglon selccionado
                string idchofer = GVCamiones.DataKeys[index].Values["Id"].ToString();//recuperar el valor de la columna Id del renglón seleccionado
                Response.Redirect("EdicionCamion.aspx?id=" + idchofer);
            }
        }

        protected void GVCamiones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string idcamion = GVCamiones.DataKeys[e.RowIndex].Values["Id"].ToString();
                DropDownList ddlTipo = (DropDownList)GVCamiones.Rows[e.RowIndex].FindControl("DDLTipoCamion");
                DropDownList ddlModelo = (DropDownList)GVCamiones.Rows[e.RowIndex].FindControl("DDLModelo");
                DropDownList ddlMarca = (DropDownList)GVCamiones.Rows[e.RowIndex].FindControl("DDLMarca");
                int capacidad = int.Parse(e.NewValues["Capacidad"].ToString());
                string kilometraje = e.NewValues["Kilometraje"].ToString();
                bool disp = bool.Parse(e.NewValues["Disponibilidad"].ToString());


                BLL.BLLCamiones.UpdCamion(int.Parse(idcamion), null, ddlTipo.SelectedValue.ToString(), int.Parse(ddlModelo.SelectedValue), ddlMarca.SelectedValue.ToString(), capacidad, double.Parse(kilometraje), disp, null);

                GVCamiones.EditIndex = -1;

                RefrescaGrid();

                Utils.UtilControls.SweetBox("Registro actualizado", "", "success", this.Page, this.GetType());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void RefrescaGrid()
        {
            //Llenar el grid con la lista de ChoferesVO
            GVCamiones.DataSource = BLL.BLLCamiones.GetLstCamiones(null);

            //actualiza el contenido del grid
            GVCamiones.DataBind();
        }


    }
}