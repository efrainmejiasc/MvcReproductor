using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcReproductor.Models
{
    public class Antiextorsion
    {
        public int? Usuario { get; set; }
        public string UsuarioNombre { get; set; }
        public int? Audio { get; set; }
        public HttpPostedFileBase AudioFile { set; get; }
        public string Archivo { set; get; }
        public string Ruta { set; get; }
        public string Type { set; get; }
    }
}