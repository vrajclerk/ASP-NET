using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _8
{
    public partial class timeBased : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = GetTimeDependentCache();
        }
        public string GetTimeDependentCache()
        {
            string cacheKey = "TimeDependentData";
            string cachedData = HttpContext.Current.Cache[cacheKey] as string;

            if (cachedData == null)
            {
                cachedData = "Time-dependent cache created at: " + DateTime.Now.ToString();
                HttpContext.Current.Cache.Insert(
                    cacheKey,
                    cachedData,
                    null,
                    DateTime.Now.AddSeconds(30), // Expires in 30 seconds
                     System.Web.Caching.Cache.NoSlidingExpiration
                );

                return cachedData + " (Data was cached just now)";
            }
            return cachedData + " (Retrieved from cache)";
        }
    }
}