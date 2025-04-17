using AspNetCoreEFCoreApp.Models;
using AspNetCoreEFCoreApp.Repositories;
using System.Collections.Generic;

namespace AspNetCoreEFCoreApp.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository _repository;

        public FeedbackService(IFeedbackRepository repository)
        {
            _repository = repository;
        }

        public void AddFeedback(Feedback feedback)
        {
            _repository.AddFeedback(feedback);
        }

        public IEnumerable<Feedback> GetAllFeedback()
        {
            return _repository.GetAllFormulare();
        }
    }
}
