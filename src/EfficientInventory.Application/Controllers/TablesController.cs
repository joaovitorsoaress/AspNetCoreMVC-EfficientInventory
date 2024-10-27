using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.Application.Models;

namespace EfficientInventory.Application.Controllers;

public class TablesController : Controller
{
  public IActionResult Basic() => View();
}
