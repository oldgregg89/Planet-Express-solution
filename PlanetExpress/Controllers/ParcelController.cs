using Microsoft.AspNetCore.Mvc;
using PlanetExpress.Models;
using System.Collections.Generic;

namespace PlanetExpress.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/Parcel")]
    public ActionResult Index()
    {
      List<Parcel> AllParcel = Parcel.GetAll();
      return View(AllParcel);
    }
    [HttpGet("/Parcel/new")]
    public ActionResult CreateForms()
    {
      return View();
    }
    [HttpPost("/Parcel")]
    public ActionResult Create(string description, int height, int length, int width, int weight)
    {
      Parcel myParcels = new Parcel(description, weight, height, length, width);
      return RedirectToAction("Index");
    }
  }
}