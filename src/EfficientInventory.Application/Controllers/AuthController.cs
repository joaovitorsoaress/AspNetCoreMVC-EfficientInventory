using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.Application.Models;

namespace EfficientInventory.Application.Controllers;

public class AuthController : Controller
{
  public IActionResult ForgotPasswordBasic() => View();
  public IActionResult LoginBasic() => View();
  public IActionResult RegisterBasic() => View();
}
