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
    public class Task
    {
        /// <summary>
        /// Личный ID задачи 
        /// </summary>
        public Guid ID { get; set; }

        [Key]
        // Дата 
        public DateTime Date { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public String Description { get; set; }


        /// <summary>
        /// статус задачи , где 1 - выполненная, 0 - удаленная , 2 - ежедневная задача, которая еще не выполнена
        /// </summary>
        public enum _Status
        {   
            Deleted = 0,
            Completed = 1,
            Daily  = 2
        }

        public _Status Status { get; set; }

        public int UserTasksId { get; set; }

        public UserTasks UserTasks { get; set; }


    }
}
