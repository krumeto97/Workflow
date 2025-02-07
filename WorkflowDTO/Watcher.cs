﻿namespace WorkflowDTO
{
    using System.ComponentModel.DataAnnotations;
    public class Watcher
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public virtual string FirstName { get; set; }

        [Required]
        [StringLength(200)]
        public virtual string LastName { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(256)]
        public string EmailAddress { get; set; }
    }
}
