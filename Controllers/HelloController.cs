using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]                                       //myc
        [Route("/helloworld/")]                         //myc
        public IActionResult Index()
        {
            string html = "<h1>Hello World!</h1>";      //myc
            return Content(html, "text/html");          //myc
        }
    }
}

