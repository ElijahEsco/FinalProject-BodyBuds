using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace FinalProject_BodyBuds.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BodyTypeDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BodyTypeDbContext>>()))
            {
                // Look for any blogs.
                if (context.BodyTypes.Any())
                {
                    return; // DB has been seeded
                }
                
                context.BodyTypes.AddRange(
                    new BodyType
                    {
                        TypeName = "Warrior: Exceptionally lean/toned (6-8% body fat)"
                    },
                    new BodyType
                    {
                        TypeName = "Greek God: Muscular with great definition/proportion (8-10% body fat)"
                    },
                    new BodyType
                    {
                        TypeName = "Superhero: Incredible muscle development (bodybuilder look)"
                    }
                );
                context.Workouts.AddRange(
                    new Workout
                    {
                        WorkoutName = "Power Clean",
                        Sets = 3,
                        Reps = 6
                    },
                    new Workout
                    {
                        WorkoutName = "Front Squat",
                        Sets = 3,
                        Reps = 6
                    },
                    new Workout
                    {
                        WorkoutName = "BenchPress",
                        Sets = 3,
                        Reps = 6
                    },
                    new Workout
                    {
                        WorkoutName = "Incline BenchPress",
                        Sets = 3,
                        Reps = 6
                    },
                    new Workout
                    {
                        WorkoutName = "Split Jerk",
                        Sets = 3,
                        Reps = 6
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
