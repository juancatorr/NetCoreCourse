using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoSeller
    {
        public Guid Id { get; set; }

        public string name { get; set; }

        [Required]
        public string lastName { get; set; }

        public Int16 age { get; set; }

    }
}

