using AspNetCoreEFCoreApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreEFCoreApp.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly SupermarketContext _context;

        public FeedbackRepository(SupermarketContext context)
        {
            _context = context;
        }

        // Dacă nu ai nevoie de citire, poți comenta sau elimina GetAllFormulare
        public IEnumerable<Feedback> GetAllFormulare()
        {
            return _context.Feedback.ToList();
        }

        public void AddFeedback(Feedback feedback)
        {
            _context.Feedback.Add(feedback);
            _context.SaveChanges();
        }

     
    }
}