using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityMvcDemoApp.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            return View("Profile", email);
        }

    }
}
