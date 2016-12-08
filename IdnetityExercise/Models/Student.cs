using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IdnetityExercise.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name="Gender")]
        public Gender StudentGender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}