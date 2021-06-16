using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Repository.Models;

namespace Service
{
   public interface  IFeedbackServise
    {
        void AddFeedback(CFeedback feed);
        void DeleteFeedback(CFeedback feed);
        void UpdateFeedback(CFeedback feed);
        List<CFeedback> GetAllFeedback();
    }
}
