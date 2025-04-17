using AspNetCoreEFCoreApp.Models;
using System.Collections.Generic;

namespace AspNetCoreEFCoreApp.Repositories
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAllFormulare();
        void AddFeedback(Feedback feedback);
    }
}
