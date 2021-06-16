using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Repository.Models;

namespace Repository
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
        void DeleteFeedback(Feedback feedback);
        void UpdateFeedback(Feedback feedback);
        List<Feedback> GetAllFeedback();

    }
}
