using System;
using System.Collections.Generic;
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

        public DEV_Library.Models.Task GetTaskById(Guid id)
        {
            Entities.Task task = _context.Task.Find(id);
            return Mapper.MapTask(task);
        }       

    }
}
