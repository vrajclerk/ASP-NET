using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace WebApplication3.Controllers
{
    public class MusicStoreController : Controller
    {
       
       // [HttpGet]
      //  [OutputCache(Duration = 10)]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "Hello, this is welcome action message";
        }
        public string ShowMusic(string MusicTitle)
        {
            return "You selected " + MusicTitle + " Music";
        }
    }
}
