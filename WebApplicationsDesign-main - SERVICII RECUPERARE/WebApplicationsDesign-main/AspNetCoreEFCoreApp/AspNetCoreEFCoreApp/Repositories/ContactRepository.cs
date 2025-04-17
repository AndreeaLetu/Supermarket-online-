using AspNetCoreEFCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AspNetCoreEFCoreApp.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly SupermarketContext _context;

        public ContactRepository(SupermarketContext context)
        {
            _context = context;
        }

        public IEnumerable<Contact> GetAll()
        {
            return _context.Set<Contact>().ToList();
        }

        public Contact GetById(int id)
        {
            return _context.Set<Contact>().Find(id);
        }

        public void Add(Contact contact)
        {
            _context.Set<Contact>().Add(contact);
            _context.SaveChanges();
        }

        public void Update(Contact contact)
        {
            _context.Set<Contact>().Update(contact);
            _context.SaveChanges();
        }

        public void Delete(Contact contact)
        {
            _context.Set<Contact>().Remove(contact);
            _context.SaveChanges();
        }
    }
}
