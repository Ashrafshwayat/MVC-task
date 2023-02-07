using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace taskMvc_2_1_2023.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string Faclity { get; set; }

        

    }
}