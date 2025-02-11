﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Entities
{
    public class WorkingExperience
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User {  get; set; }    

        [MaxLength(50)]

        public string Name { get; set; }

        [MaxLength(50)]
        public string Details { get; set; }

        public string Environment { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
