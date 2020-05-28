using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["video"] = BaseHelper.ejecutarConsulta("Select * from video", CommandType.Text);
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("INSERT INTO video VALUES (@idVideo,@titulo,@repro,@url)",
                                        CommandType.Text,
                                         parametros);

            return RedirectToAction("Index", "Video");
        }
        //Editar video
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(string titulo, int repro, string url, int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.ejecutarSentencia("UPDATE video SET titulo = @titulo, repro = @repro, url = @url WHERE idVideo = @idVideo", CommandType.Text, parametros);
            return RedirectToAction("Index", "Video");
        }
        //Eliminar video
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.ejecutarSentencia("Delete from Video WHERE idVideo = @idVideo", CommandType.Text, parametros);
            return RedirectToAction("Index", "Video");
        }
    }
}
