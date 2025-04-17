using AspNetCoreEFCoreApp.Models;
using AspNetCoreEFCoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public interface IContactService
{
    IEnumerable<Contact> GetAll();
    Contact GetById(int id);
    void Add(Contact contact);
    void Update(Contact contact);
    void Delete(int id);
}
