using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkLinkWebApp.Models
{
    public class Factura
    {
        public int ID_Factura { get; set; }
        public string Fecha_de_emision { get; set; }
        public string Fecha_de_vencimiento { get; set; }
        public decimal Monto_total { get; set; }
        public string Detalle { get; set; }
        public int ID_Cliente { get; set; }

        public int ID_Servicio { get; set; }

    }
}