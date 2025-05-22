using AspNetCoreEFCoreApp.Models;
using AspNetCoreEFCoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreEFCoreApp.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackService _feedbackService;
        private readonly SupermarketContext _context;

        public FeedbackController(IFeedbackService feedbackService, SupermarketContext context)
        {
            _feedbackService = feedbackService;
            
        }

        // GET: Feedback
        public IActionResult Index()
        {
            var feedbackList = _feedbackService.GetAllFeedback();
            return View(feedbackList);
        }

        // GET: Feedback/Create
        public IActionResult Create()
        {
            var feedback = new Feedback
            {
                CNP = _context.Users.Select(u => u.CNP).FirstOrDefault()
            };

            ViewBag.CNP = new SelectList(_context.Users, "CNP", "CNP", feedback.CNP);
            ViewBag.FeedbackList = _feedbackService.GetAllFeedback();

            return View(feedback);
        }

        // POST: Feedback/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id_Feedback,Name_Full,Photo,Message,CNP")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackService.AddFeedback(feedback);
                return RedirectToAction(nameof(Create));
            }

            ViewBag.CNP = new SelectList(_context.Users, "CNP", "CNP", feedback.CNP);
            return View(feedback);
        }
    }
}
