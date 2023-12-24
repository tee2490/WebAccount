using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAccount.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MyUser> userManager;

        public AccountController(UserManager<MyUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var result = await userManager.Users.ToListAsync();

            return View(result);
        }
    }
}
