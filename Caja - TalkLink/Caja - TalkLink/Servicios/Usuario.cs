using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalkLinkWebApp.Models
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Correo { get; set; }
        public string UsuarioString { get; set; }
        public int ID_Dir { get; set; }
        public int ID_Estado { get; set; }


    }
}