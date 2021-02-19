using System;
using batchmailr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace batchmailr.Controllers
{
    public class EmailsController : Controller
    {
        private IEmailsService _emailsService;

        public EmailsController(IEmailsService emailsService)
        {
            _emailsService = emailsService;
        }

        [Authorize]
        public IActionResult Index()
        {
            var model = _emailsService.GetAllEmailItems();
            return View(model);
        }
    }
}