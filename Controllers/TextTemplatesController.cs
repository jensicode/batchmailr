using System;
using batchmailr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using batchmailr.ViewModels;

namespace batchmailr.Controllers
{
    [Authorize]
    public class TextTemplatesController : Controller
    {
        private ITextTemplatesService _textTemplatesService;

        public TextTemplatesController(ITextTemplatesService textTemplatesService)
        {
            _textTemplatesService = textTemplatesService;
        }

        public IActionResult Index()
        {
            var model = _textTemplatesService.GetAllTextTemplateItems();
            return View(model);
        }

        public IActionResult Create()
        {
            ViewData["pageTitle"] = "Create text template";
            var model = new TextTemplateViewModel();
            return View("CreateAndEdit", model);
        }

        [HttpPost]
        public IActionResult Create(TextTemplateViewModel model)
        {
            ViewData["pageTitle"] = "Create text template";
            return View("CreateAndEdit", model);
        }
    }
}