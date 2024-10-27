using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.Application.Models;

namespace EfficientInventory.Application.Controllers;

public class IconsController : Controller
{
  public IActionResult Boxicons() => View();
}
