using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEV_Library.Interface;
using DEV_Library.Models;

namespace DEV_DataAccess.Repository
{
    public class TaskRepository : DEV_Library.Interface.ITaskRepository
    {
        private Entities.DEVContext _context;

        public TaskRepository(Entities.DEVContext context)
        {
            _context = context;
        }

        public void AddTask(DEV_Library.Models.Task task)
        {
            Entities.Task newTask = Mapper.MapTask(task);
            _context.Add(newTask);

        }

        public void DeleteTask(Guid Id)
        {
            Entities.Task task = _context.Task.Find(Id);
            _context.Remove(task); 
        }

        public DEV_Library.Models.Task GetTaskById(Guid id)
        {
            Entities.Task task = _context.Task.Find(id);
            return Mapper.MapTask(task);
        }

        public IEnumerable<DEV_Library.Models.Task> GetTasks()
        {
            IEnumerable<Entities.Task> tasks = _context.Task;
            return tasks.Select(Mapper.MapTask); 
        }

        public IEnumerable<DEV_Library.Models.Task> GetTasksByCourseId(Guid courseId)
        {
            IEnumerable<Entities.Task> tasks = from t in _context.Task
                                               where t.CourseId == courseId
                                               select t;
            return tasks.Select(Mapper.MapTask);                            
        }

        public void UpdateTask(DEV_Library.Models.Task task)
        {
            Entities.Task currentTask = _context.Task.Find(task.Id);
            Entities.Task updatedTask = Mapper.MapTask(task);

            _context.Entry(currentTask).CurrentValues.SetValues(updatedTask);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
