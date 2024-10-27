using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.UI.Models;

namespace EfficientInventory.UI.Controllers;

public class FormLayoutsController : Controller
{
  public IActionResult Horizontal() => View();
  public IActionResult Vertical() => View();
}
