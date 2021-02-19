using System;
using System.Collections.Generic;
using batchmailr.Models;

namespace batchmailr.Services
{
    public interface ILayoutTemplatesService
    {
        public IEnumerable<LayoutTemplate> GetAllLayoutTemplateItems();
    }

    public class LayoutTemplatesService : ILayoutTemplatesService
    {
        private IRepository<LayoutTemplate> _repository;

        public LayoutTemplatesService(IRepository<LayoutTemplate> repository)
        {
            _repository = repository;
        }

        public IEnumerable<LayoutTemplate> GetAllLayoutTemplateItems()
        {
            return _repository.GetAllItems();
        }
    }
}