using Microsoft.AspNetCore.Mvc;

namespace PlanetExpress.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}