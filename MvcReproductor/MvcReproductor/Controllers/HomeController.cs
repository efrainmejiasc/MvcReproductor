using MvcReproductor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcReproductor.Controllers
{
    public class HomeController : Controller
    {
        [DllImport("Winmm.dll")]
        private static extern long mciSedString(string command, StringBuilder retStrig, int returnPath, IntPtr callBack);

        public ActionResult Index()
        {
            List<Models.Antiextorsion> ListAntiextorsion = new List<Models.Antiextorsion>();
            Engine.Catalogo Metodo = new Engine.Catalogo();
            ListAntiextorsion = Metodo.SetAntiextorsion();
            return View(ListAntiextorsion);
        }

        public ActionResult MediaPlayerVideo()
        {
            string Ruta = Request["Ruta"];
            Antiextorsion antiextorsion = new Antiextorsion();
            antiextorsion.Ruta = Ruta;
            return View(antiextorsion);
        }

        public ActionResult RecordAudio()
        {
            string data = Request.Form.ToString();
            if (data == "Record=")
            {
                mciSedString("Grabando Audio", null, 0, IntPtr.Zero);
            }
            else if (data == "StopRecord=")
            {
                mciSedString("~/Content/Farru.wav", null, 0, IntPtr.Zero);
                mciSedString("Cerrando", null, 0, IntPtr.Zero);
            }
            return View();
        }
    }
}