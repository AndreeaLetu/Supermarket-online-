using Microsoft.AspNetCore.Mvc;
using AspNetCoreEFCoreApp.Models;
using AspNetCoreEFCoreApp.Services;


namespace AspNetCoreEFCoreApp.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: Contacts
        public IActionResult Index()
        {
            var contacts = _contactService.GetAll();
            return View(contacts);
        }

        // GET: Contacts/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var contact = _contactService.GetById(id.Value);
            if (contact == null)
                return NotFound();

            return View(contact);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Email,Subject,Message")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(contact);
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contacts/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var contact = _contactService.GetById(id.Value);
            if (contact == null)
                return NotFound();

            return View(contact);
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Email,Subject,Message")] Contact contact)
        {
            if (id != contact.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _contactService.Update(contact);
                }
                catch
                {
                    if (_contactService.GetById(contact.Id) == null)
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var contact = _contactService.GetById(id.Value);
            if (contact == null)
                return NotFound();

            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _contactService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
