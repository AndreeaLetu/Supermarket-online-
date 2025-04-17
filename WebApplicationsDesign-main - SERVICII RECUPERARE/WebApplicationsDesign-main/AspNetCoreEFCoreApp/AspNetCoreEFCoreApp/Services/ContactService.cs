using AspNetCoreEFCoreApp.Models;
using AspNetCoreEFCoreApp.Repositories;
using System.Collections.Generic;

namespace AspNetCoreEFCoreApp.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IEnumerable<Contact> GetAll()
        {
            return _contactRepository.GetAll();
        }

        public Contact GetById(int id)
        {
            return _contactRepository.GetById(id);
        }

        public void Add(Contact contact)
        {
            _contactRepository.Add(contact);
        }

        public void Update(Contact contact)
        {
            _contactRepository.Update(contact);
        }

        public void Delete(int id)
        {
            var contact = _contactRepository.GetById(id);
            if (contact != null)
            {
                _contactRepository.Delete(contact);
            }
        }
    }
}
