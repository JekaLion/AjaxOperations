﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxOperations.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}