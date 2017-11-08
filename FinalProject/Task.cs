using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Task
    {
        public int taskId;
        public string taskName;
        public string taskCategory;

        public Task()
        {
            
        }

        public Task(int taskId, string taskName, string taskCategory)
        {
            this.TaskId = taskId;
            this.TaskName = taskName;
            this.TaskCategory = taskCategory;
        }

        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskCategory { get; set; }
    }
}
