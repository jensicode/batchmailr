﻿using System;
using batchmailr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace batchmailr.Controllers
{
    [Authorize]
    public class LayoutTemplatesController : Controller
    {
        private ILayoutTemplatesService _layoutTemplatesService;

        public LayoutTemplatesController(ILayoutTemplatesService layoutTemplatesService)
        {
            _layoutTemplatesService = layoutTemplatesService;
        }

        public IActionResult Index()
        {
            var model = _layoutTemplatesService.GetAllLayoutTemplateItems();
            return View(model);
        }
    }
}