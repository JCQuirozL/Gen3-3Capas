using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Gen3_3Capas
{
    public enum Marca
    {
        Volvo,
        Alliance,
        Ford,
        [Description("Mercedes Benz")]
        Mercedes,
        Dina,
        Freightliner,
        International,
        Kenworth
    }

    public enum Tipo
    {
        Trailer,
        Torton,
        [Description("Full")]
        Doble_Remolque,
        Volteo,
        [Description("Semi remolque")]
        Semi_Remolque
    }

    public enum EstatusC
    {
        [Description("Mercancía OK")]
        Ok=1,
        [Description("Mercancía Dañada")]
        Danado=2,
        [Description("Mercancía Estraviada")]
        Extraviado=3
    }
}