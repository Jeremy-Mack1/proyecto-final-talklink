using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkLinkWebApp.Models
{
    public class Servicio
    {
        public int ID_Servicio { get; set; }
        public string Nombre_del_servicio { get; set; }
        public string Descripcion_del_servicio { get; set; }
        public decimal Tarifas { get; set; }
    }
}