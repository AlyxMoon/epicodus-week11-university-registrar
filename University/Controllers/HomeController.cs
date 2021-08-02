using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
  [Route("/")]
  public class HomeController : Controller
  {
    [HttpGet]
    public ActionResult Index ()
    {
      return View();
    }
  }
}