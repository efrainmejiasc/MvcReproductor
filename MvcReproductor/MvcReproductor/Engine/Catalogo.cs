using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcReproductor.Engine
{
    public class Catalogo
    {
        private Models.Antiextorsion Antiextorsion = new Models.Antiextorsion();
        public List<Models.Antiextorsion> SetAntiextorsion()
        {
            List<Models.Antiextorsion> ListAntiextorsion = new List<Models.Antiextorsion>();
            Antiextorsion = new Models.Antiextorsion
            {
                Usuario = 1,
                UsuarioNombre = "Jose Cartujo",
                Audio = 1,
                Archivo = "/Home/MediaPlayerVideo",
                Ruta = "/Audio/Prueba1.mp4",
                Type = "video/mp4"
            };
            ListAntiextorsion.Insert(0, Antiextorsion);

            Antiextorsion = new Models.Antiextorsion
            {
                Usuario = 2,
                UsuarioNombre = "Maria Hernandez",
                Audio = 2,
                Archivo = "/Home/MediaPlayerVideo",
                Ruta = "/Audio/Prueba2.mp4",
                Type = "video/ogg"
            };
            ListAntiextorsion.Insert(1, Antiextorsion);

            Antiextorsion = new Models.Antiextorsion
            {
                Usuario = 3,
                UsuarioNombre = "Carlos Garcia",
                Audio = 3,
                Archivo = "/Home/MediaPlayerVideo",
                Ruta = "/Audio/Prueba2.mp4",
                Type = "video/webm"
            };
            ListAntiextorsion.Insert(1, Antiextorsion);

            return ListAntiextorsion;
        }
    }
}