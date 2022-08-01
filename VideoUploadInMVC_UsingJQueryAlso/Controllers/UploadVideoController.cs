using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoUploadInMVC_UsingJQueryAlso.Models;


namespace VideoUploadInMVC_UsingJQueryAlso.Controllers
{
    public class UploadVideoController : Controller
    {
        AppContext _context = new AppContext();
        // GET: UploadVideo
        public ActionResult Index()
        {
            var video = _context.VideoFiles.ToList();
            return View(video);
        }


        public ActionResult AddVideo()
        {
            return View();
        }    

        [HttpPost]
        public ActionResult AddVideo(VideoFiles model)
        {
            if (model != null)
            {
                var file = Request.Files[0];                               
                string fileName = Path.GetFileName(model.file.FileName);
                string path = Server.MapPath("~/UploadedVideos");
                string fullPath = Path.Combine(path, fileName);
                model.file.SaveAs(fullPath);

                string contentype = file.ContentType;
                byte[] data = new byte[file.ContentLength];
                file.InputStream.Read(data, 0, file.ContentLength);

                model.FilePath = fullPath;
                model.FileSize = data;
                model.FileName = fileName;
                _context.VideoFiles.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
