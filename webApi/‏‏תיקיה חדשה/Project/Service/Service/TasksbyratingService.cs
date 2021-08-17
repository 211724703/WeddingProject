using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class TasksbyratingService : ITasksbyratingService
    {
        ITasksbyratingRepository iTasksbyR;

        public TasksbyratingService(ITasksbyratingRepository iTasksbyR)
        {
            this.iTasksbyR = iTasksbyR;
        }
        public void AddTasksbyrating(CTasksbyrating Tasksb)
        {
            
            Tasksbyrating tasksbyrating = new Tasksbyrating()
            {

                TasksbyratingId = Tasksb.TasksbyratingId,
                Nametasksbyrating = Tasksb.Nametasksbyrating,
                Ratingfeedback = Tasksb.Ratingfeedback,
            };

            iTasksbyR.AddTasksbyrating(tasksbyrating);
        }                            

        public void DeleteTasksbyrating(CTasksbyrating Tasksb)
        {
            CTasksbyrating ctasksbyrating = new CTasksbyrating()
            {

                TasksbyratingId = Tasksb.TasksbyratingId,
                Nametasksbyrating = Tasksb.Nametasksbyrating,
                Ratingfeedback = Tasksb.Ratingfeedback,
            };
            Tasksbyrating tasksbyrating = new Tasksbyrating()
            {

                TasksbyratingId = Tasksb.TasksbyratingId,
                Nametasksbyrating = Tasksb.Nametasksbyrating,
                Ratingfeedback = Tasksb.Ratingfeedback,
            };
            iTasksbyR.DeleteTasksbyrating(tasksbyrating);
        }

        public void UpdateTasksbyrating(CTasksbyrating Tasksb)
        {
            CTasksbyrating ctasksbyrating = new CTasksbyrating()
            {

                TasksbyratingId = Tasksb.TasksbyratingId,
                Nametasksbyrating = Tasksb.Nametasksbyrating,
                Ratingfeedback = Tasksb.Ratingfeedback,
            };
            Tasksbyrating tasksbyrating = new Tasksbyrating()
            {

                TasksbyratingId = Tasksb.TasksbyratingId,
                Nametasksbyrating = Tasksb.Nametasksbyrating,
                Ratingfeedback = Tasksb.Ratingfeedback,
            };
            iTasksbyR.UpdateTasksbyrating(tasksbyrating);

        }



        public List<CTasksbyrating> GetAllTasksbyrating()
        {

            List<CTasksbyrating> tasksbyrating = (from tmp in iTasksbyR.GetAllTasksbyrating()
                                                  select new CTasksbyrating
                                                  {
                                                      TasksbyratingId = tmp.TasksbyratingId,
                                                      Nametasksbyrating = tmp.Nametasksbyrating,
                                                      Ratingfeedback = tmp.Ratingfeedback,

                                                  }).ToList();

            return tasksbyrating;
        }

    }
}
