using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkLinkWebApp.Models
{
    public class Cotizaciones
    {
        public int ID_Coti { get; set; }
        public int Servicios_solicitados { get; set; }
        public string Duracion_del_contrato { get; set; }
        public decimal Precio_total_estimado { get; set; }
        public int ID_Cliente { get; set; }
    }
}