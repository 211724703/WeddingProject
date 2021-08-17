using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class TasksbyratingRepository:ITasksbyratingRepository
    {
        DB context;
        public TasksbyratingRepository(DB context)
        {
            this.context = context;
        }


        public void AddTasksbyrating(Tasksbyrating tasksbyrating)
        {
            context.Tasksbyrating.Add(tasksbyrating);
            context.SaveChanges();
        }

        public void DeleteTasksbyrating(Tasksbyrating tasksbyrating)
        {
            context.Tasksbyrating.Remove(tasksbyrating);
            context.SaveChanges();
        }

        public void UpdateTasksbyrating(Tasksbyrating tasksbyrating)
        {
            context.Tasksbyrating.Update(tasksbyrating);
            context.SaveChanges();
        }


        public List<Tasksbyrating> GetAllTasksbyrating()
        {

            return context.Tasksbyrating.ToList();
        }

    }
}
