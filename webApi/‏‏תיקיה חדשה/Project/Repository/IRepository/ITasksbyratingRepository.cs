using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ITasksbyratingRepository
    {
        void AddTasksbyrating(Tasksbyrating tasksbyrating);
        void DeleteTasksbyrating(Tasksbyrating tasksbyrating);
        void UpdateTasksbyrating(Tasksbyrating tasksbyrating);
        List<Tasksbyrating> GetAllTasksbyrating();


    }
}
