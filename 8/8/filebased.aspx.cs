using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _8
{
    public partial class filebased : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = GetFileDependentCache();
        }
        public string GetFileDependentCache()
        {
            string cacheKey = "FileDependentData";
            string cachedData = HttpContext.Current.Cache[cacheKey] as string;

            if (cachedData == null)
            {
                string filePath = HttpContext.Current.Server.MapPath("~/TextFile1.txt");
                CacheDependency dependency = new CacheDependency(filePath);

                string fileData = System.IO.File.ReadAllText(filePath);
                HttpContext.Current.Cache.Insert(cacheKey, fileData, dependency);

                return fileData + " (Data was cached just now)";
            }
            return cachedData + " (Retrieved from cache)";
        }
    }
}