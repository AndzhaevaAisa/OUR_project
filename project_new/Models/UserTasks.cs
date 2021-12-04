using project_new.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_new.Models
{
    /// <summary>
    /// Завершенные задачи
    /// </summary>
    public class UserTasks
    {
        // ID пользователя
        public Guid ID { get; set; }

        // для получения данных от пользователя
        public User User { get; set; }

        // Задачи пользователя
        public List<Task> Tasks { get; set; }

        public UserTasks() 
        { 
            Tasks = new List<Task>();
        }

    }
}
