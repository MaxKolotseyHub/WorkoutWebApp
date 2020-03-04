using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutWebApp.Models
{
    public class Excercise
    {
        public Excercise()
        {
            Workouts = new List<Workout>();
        }
        public long Id { get; set; }
        public string Title { get; set; }
        public virtual List<Workout> Workouts { get; set; }
    }
}