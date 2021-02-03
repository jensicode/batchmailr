using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace batchmailr.Controllers
{
    public class EmailsController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}