using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.UI.Models;

namespace EfficientInventory.UI.Controllers;

public class LayoutExamplesController : Controller
{
  public IActionResult Blank() => View();
  public IActionResult Container() => View();
  public IActionResult Fluid() => View();
  public IActionResult HorizontalMenu() => View();
  public IActionResult WithoutMenu() => View();
  public IActionResult WithoutNavbar() => View();
}
