using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfficientInventory.UI.Models;

namespace EfficientInventory.UI.Controllers;

public class AuthController : Controller
{
  public IActionResult ForgotPasswordBasic() => View();
  public IActionResult LoginBasic() => View();
  public IActionResult RegisterBasic() => View();
}
