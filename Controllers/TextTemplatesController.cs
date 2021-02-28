using System;
using batchmailr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
    }
}