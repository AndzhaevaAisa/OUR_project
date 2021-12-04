using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project_new.ViewModels
{
    public class TaskViewModel
    {
        [Required]
        [Display(Name = "Select Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Enter Task")]
        public string Description { get; set; }

        public IEnumerable<Models.Task> Model1 { get; set; }

    }
}
