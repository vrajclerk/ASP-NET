using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorTutorial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //model property
        public string Message{get; set;}
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //handles http get request (Controller Action
        public void OnGet()
        {
            Message = "Hello Vraj! The Time is: "+ DateTime.Now.ToLongTimeString();
        }
    }
}
