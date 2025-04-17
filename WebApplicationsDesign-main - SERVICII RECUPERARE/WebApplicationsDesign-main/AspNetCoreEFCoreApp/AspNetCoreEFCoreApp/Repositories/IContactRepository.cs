using AspNetCoreEFCoreApp.Models;
using System.Linq.Expressions;
namespace AspNetCoreEFCoreApp.Repositories
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        Contact GetById(int id);
        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
    }
}
