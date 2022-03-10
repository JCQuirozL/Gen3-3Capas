using Gen3_3Capas.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gen3_3Capas.Catalogos.Choferes
{
    public partial class ListadoChoferes : System.Web.UI.Page
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

        private void RefrescaGrid()
        {
            //Llenar el grid con la lista de ChoferesVO
            GVChoferes.DataSource = BLL.BLLChoferes.GetLstChoferes(null);

            //actualiza el contenido del grid
            GVChoferes.DataBind();
        }

        protected void GVChoferes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Eliminar el chofer

            string idchofer = GVChoferes.DataKeys[e.RowIndex].Values["IdChofer"].ToString();

            string Resultado = BLL.BLLChoferes.DelChofer(int.Parse(idchofer));

            if (Resultado == "1")
            {
                Utils.UtilControls.SweetBox("Chofer eliminado con éxito", "", "success", this.Page, this.GetType());

                RefrescaGrid();
            }
            else if (Resultado == "0")
            {
                Utils.UtilControls.SweetBox("Chofer no pudo ser eliminado", "Los choferes NO disponibles no pueden ser eliminados", "error", this.Page, this.GetType());
            }
            else if (Resultado == "2")
            {
                Utils.UtilControls.SweetBox("Chofer no pudo ser eliminado", "Los choferes con ruta asignada NO pueden ser eliminados", "error", this.Page, this.GetType());
            }
        }

        protected void GVChoferes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Entrar en modo edición
            GVChoferes.EditIndex = e.NewEditIndex;
            RefrescaGrid();
        }

        protected void GVChoferes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string idchofer = GVChoferes.DataKeys[e.RowIndex].Values["IdChofer"].ToString();
                string nombre = e.NewValues["Nombre"].ToString();
                string apPaterno = e.NewValues["ApPaterno"].ToString();
                string apMaterno = e.NewValues["ApMaterno"].ToString();
                CheckBox chkAux = (CheckBox)GVChoferes.Rows[e.RowIndex].FindControl("ChkEditDisponible");
                bool disponibilidad = chkAux.Checked;

                BLL.BLLChoferes.UpdChofer(int.Parse(idchofer), null, null, null, nombre, apPaterno, apMaterno, null, disponibilidad);

                //Salir del modo edición
                GVChoferes.EditIndex = -1;
                RefrescaGrid();
                Utils.UtilControls.SweetBox("Registro actualizado", "", "success", this.Page, this.GetType());
                
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        protected void GVChoferes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Salir del modo edición
            GVChoferes.EditIndex = -1;
            RefrescaGrid();
        }

        protected void GVChoferes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = int.Parse(e.CommandArgument.ToString());//referencia al renglon selccionado
                string idchofer = GVChoferes.DataKeys[index].Values["IdChofer"].ToString();//recuperar el valor de la columna Id del renglón seleccionado
                Response.Redirect("EdicionChofer.aspx?id=" + idchofer);
            }
        }
    }
}