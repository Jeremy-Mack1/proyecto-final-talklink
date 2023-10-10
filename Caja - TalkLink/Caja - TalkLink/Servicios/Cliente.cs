using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkLinkWebApp.Models
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }
        public string Nombre_del_cliente { get; set; }
        public string Numero_de_telefono_principal { get; set; }
        public string Informacion_de_contacto_alternativo { get; set; }
        public string Fecha_de_registro_como_cliente { get; set; }
        public int ID_Dir { get; set; }
        public int ID_Estado { get; set; }

        public int ID_Usuario { get; set; }
    }
}