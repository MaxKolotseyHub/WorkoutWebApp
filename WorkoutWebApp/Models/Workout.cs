using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutWebApp.Models
{
    public class Workout
    {
        public Workout()
        {
            Excercises = new List<Excercise>();
        }
        public long Id { get; set; }
        public string Title { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IList<Excercise> Excercises { get; set; }
    }
}