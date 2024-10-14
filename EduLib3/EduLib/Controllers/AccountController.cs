using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EduLib.Models;

namespace EduLib.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
