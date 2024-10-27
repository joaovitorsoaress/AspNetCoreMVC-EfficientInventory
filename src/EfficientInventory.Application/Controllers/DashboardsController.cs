using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.Application.Models;

namespace EfficientInventory.Application.Controllers;

public class DashboardsController : Controller
{
  public IActionResult Index() => View();
}
