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
    }
}