using System;
using batchmailr.Services;
using batchmailr.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace batchmailr.Controllers
{
    [Authorize]
    public class EmailsController : Controller
    {
        private IEmailsService _emailsService;

        public EmailsController(IEmailsService emailsService)
        {
            _emailsService = emailsService;
        }

        public IActionResult Index()
        {
            var model = _emailsService.GetAllEmailItems();
            return View(model);
        }

        public IActionResult Create()
        {
            ViewData["pageTitle"] = "Create e-mail";
            var model = new EmailsViewModel();
            return View("CreateAndEdit", model);
        }

        [HttpPost]
        public IActionResult Create(EmailsViewModel model)
        {
            ViewData["pageTitle"] = "Create e-mail";
            return View("CreateAndEdit", model);
        }
    }
}