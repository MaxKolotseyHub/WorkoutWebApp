using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutWebApp.Models
{
    public class TrainingHistory
    {
        public long Id { get; set; }
        public long WorkoutId { get; set; }
        public long ExcerciseId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int Lap { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}