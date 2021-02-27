using System;
using batchmailr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace batchmailr.Controllers
{
    public class TextTemplatesController : Controller
    {
        private ITextTemplatesService _textTemplatesService;

        public TextTemplatesController(ITextTemplatesService textTemplatesService)
        {
            _textTemplatesService = textTemplatesService;
        }

        [Authorize]
        public IActionResult Index()
        {
            var model = _textTemplatesService.GetAllTextTemplateItems();
            return View(model);
        }
    }
}