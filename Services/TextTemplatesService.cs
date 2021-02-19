using System;
using System.Collections.Generic;
using batchmailr.Models;

namespace batchmailr.Services
{
    public interface ITextTemplatesService
    {
        public IEnumerable<TextTemplate> GetAllTextTemplateItems();
    }

    public class TextTemplatesService : ITextTemplatesService
    {
        private IRepository<TextTemplate> _repository;

        public TextTemplatesService(IRepository<TextTemplate> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TextTemplate> GetAllTextTemplateItems()
        {
            return _repository.GetAllItems();
        }
    }
}