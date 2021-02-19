using System;
using System.Collections.Generic;
using batchmailr.Models;

namespace batchmailr.Services
{
    public interface IEmailsService
    {
        public IEnumerable<Email> GetAllEmailItems();
    }

    public class EmailsService : IEmailsService
    {
        private IRepository<Email> _repository;

        public EmailsService(IRepository<Email> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Email> GetAllEmailItems()
        {
            return _repository.GetAllItems();
        }
    }
}