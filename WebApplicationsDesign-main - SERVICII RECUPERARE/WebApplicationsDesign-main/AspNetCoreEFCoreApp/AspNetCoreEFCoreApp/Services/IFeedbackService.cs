using AspNetCoreEFCoreApp.Models;

namespace AspNetCoreEFCoreApp.Services
{
    public interface IFeedbackService
    {
        void AddFeedback(Feedback feedback);
        IEnumerable<Feedback> GetAllFeedback();
    }
}
