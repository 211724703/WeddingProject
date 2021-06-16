using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public interface ITasksbyratingService
    {
        void AddTasksbyrating(CTasksbyrating Tasksb);
        void DeleteTasksbyrating(CTasksbyrating Tasksb);
        void UpdateTasksbyrating(CTasksbyrating Tasksb);
        List<CTasksbyrating> GetAllTasksbyrating();

    }
}
