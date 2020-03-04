using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutWebApp.Models
{
    public class User
    {
        public User()
        {
            Workouts = new List<Workout>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual List<Workout> Workouts { get; set; }
        public virtual List<TrainingHistory> trainingHistories { get; set; }
    }
}