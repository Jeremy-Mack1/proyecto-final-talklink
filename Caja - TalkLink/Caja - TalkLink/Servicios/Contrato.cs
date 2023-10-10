using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkLinkWebApp.Models
{
    public class Contrato
    {
        public int ID_Contrato { get; set; }
        public string Fecha_de_finalizacion { get; set; }
        public int Plan_de_servicio_contratado { get; set; }
        public decimal Costo_del_contrato { get; set; }
        public int ID_Estado { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Servicio { get; set; }
    }
}