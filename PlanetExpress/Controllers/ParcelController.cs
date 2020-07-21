using Microsoft.AspNetCore.Mvc;
using PlanetExpress.Models;
using System.Collections.Generic;

namespace PlanetExpress.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/Parcels")]
    public ActionResult Index()
    {
      List<Parcel> AllParcel = Parcel.GetAll();
      return View(AllParcel);
    }
    [HttpGet("/Parcels/new")]
    public ActionResult CreateForms()
    {
      return View();
    }
    [HttpPost("/Parcels")]
    public ActionResult Create(string description, int height, int length, int width, int weight)
    {
      Parcel myParcels = new Parcel(description, weight, height, length, width);
      return RedirectToAction("Index");
    }
  }
}