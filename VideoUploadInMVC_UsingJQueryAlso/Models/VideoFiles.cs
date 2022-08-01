using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VideoUploadInMVC_UsingJQueryAlso.Models
{
    public class VideoFiles
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public byte[] FileSize { get; set; }
        public string FilePath { get; set; }
        [NotMapped]
        public HttpPostedFileBase file { get; set; }
    }
}