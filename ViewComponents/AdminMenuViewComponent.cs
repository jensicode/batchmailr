using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace batchmailr.ViewComponents
{
    public class AdminMenuViewComponent : ViewComponent
    {
        private SignInManager<IdentityUser> _signInManager;

        public AdminMenuViewComponent(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IViewComponentResult Invoke()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                return View();
            }
            return Content("");
        }
    }
}
