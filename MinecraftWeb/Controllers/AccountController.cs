using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Minecraft.Web.Controllers
{
    public class AccountController : Controller
    {
        [Authorize]
        public IActionResult Donate()
        {
            return View();
        }

        [Authorize]
        public IActionResult Login()
        {
            return RedirectToAction("Index", "Home");
        }

        
        public IActionResult Logout()
        {
            if (!User.Identity.IsAuthenticated)
                RedirectToAction("Index", "Home");

            var parameters = new AuthenticationProperties()
            {
                RedirectUri = "/Home/Index"
            };

            return SignOut(
                parameters,
                CookieAuthenticationDefaults.AuthenticationScheme,
                OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}
