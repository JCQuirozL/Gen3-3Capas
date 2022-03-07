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
            List<ChoferesVO> Listado = BLL.BLLChoferes.GetLstChoferes(null);
            GridView1.DataSource = Listado;
            GridView1.DataBind();
            int x = 0;
        }
    }
}