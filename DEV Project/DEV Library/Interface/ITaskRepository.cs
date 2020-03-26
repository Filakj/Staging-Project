using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_Library.Interface
{
    public interface ITaskRepository
    {
        IEnumerable<DEV_Library.Models.Task> GetTasks();

        DEV_Library.Models.Task GetTaskById(Guid id);

        void UpdateTask(DEV_Library.Models.Task task);

        void DeleteTask(Guid Id);


        IEnumerable<DEV_Library.Models.Task> GetTasksByCourseId(Guid courseId);
        
    }
}
