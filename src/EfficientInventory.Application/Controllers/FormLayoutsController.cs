using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.Application.Models;

namespace EfficientInventory.Application.Controllers;

public class FormLayoutsController : Controller
{
  public IActionResult Horizontal() => View();
  public IActionResult Vertical() => View();
}
