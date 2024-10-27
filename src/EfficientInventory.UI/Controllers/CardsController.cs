using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.UI.Models;

namespace EfficientInventory.UI.Controllers;

public class CardsController : Controller
{
  public IActionResult Basic() => View();
}
