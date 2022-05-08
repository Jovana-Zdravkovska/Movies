﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Person
    {
        [Key]
        public int PeopleID { get; set; }
        public String Name { get; set; }
        public String Roles { get; set; }
    }
}