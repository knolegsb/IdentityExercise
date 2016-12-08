using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdnetityExercise.Models
{
    public class TestViewModel
    {
        public Title? Title { get; set; }
    }

    public enum Title
    {
        Mr,
        Mrs,
        Miss,
        Dr
    }
}