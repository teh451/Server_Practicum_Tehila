﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Tz { get; set; }
        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        public Person Parent { get; set; }
    }
}
