using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VideoUploadInMVC_UsingJQueryAlso.Models
{
    public class AppContext:DbContext
    {
        public AppContext():base("DefaultConnection")
        {

        }
        public DbSet<VideoFiles> VideoFiles { get; set;}
    }
}