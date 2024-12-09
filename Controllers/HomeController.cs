using Microsoft.AspNetCore.Mvc;

namespace ViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            //return View();//if we don't specify name then it considers view name as Index.cshtml    //views/home/index.cshtml
            return View("Index");//here it will consider view name as abc.cshtml
            //return new ViewResult();
        }
    }
}
