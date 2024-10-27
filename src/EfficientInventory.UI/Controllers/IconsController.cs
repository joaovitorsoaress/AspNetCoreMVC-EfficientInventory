using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.UI.Models;

namespace EfficientInventory.UI.Controllers;

public class IconsController : Controller
{
  public IActionResult Boxicons() => View();
}
