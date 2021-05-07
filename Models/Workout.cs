using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_BodyBuds.Models
{
    public class Workout
    {
        public int WorkoutId {get; set;}
        
        [Required]        
        public string WorkoutName {get; set;}
        public int Sets {get; set;}
        public int Reps {get; set;}
    }
}