using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedLibrary
{
    public class MyContext
    {
        public static List<Track> Tracks { get; } = new List<Track>
        {
            new Track
            {
                Id = 1,
                Name = "Track 1",
                Description = "Description 1"
            },
            new Track
            {
                Id = 2,
                Name = "Track 2",
                Description = "Description 2"
            }
        };

        public static int Count { get; set; } = 5;



        public static List<Trainee> Trainees { get; } = new List<Trainee>
        {
            new Trainee
            {
                Id = 1,
                Name = "Trainee 1",
                Gender = GenderType.Man,
                Email = "trainee1@example.com",
                MobileNo = "1234567890",
                BirthDate = new DateTime(2000, 1, 1),
                IsGraduated = true,
                TrackId = 1
            },
            new Trainee
            {
                Id = 2,
                Name = "Trainee 2",
                Gender = GenderType.Woman,
                Email = "trainee2@example.com",
                MobileNo = "2345678901",
                BirthDate = new DateTime(2000, 2, 2),
                IsGraduated = false,
                TrackId = 1
            },
            new Trainee
            {
                Id = 3,
                Name = "Trainee 3",
                Gender = GenderType.Man,
                Email = "trainee3@example.com",
                MobileNo = "3456789012",
                BirthDate = new DateTime(2000, 3, 3),
                IsGraduated = true,
                TrackId = 2
            },
            new Trainee
            {
                Id = 4,
                Name = "Trainee 4",
                Gender = GenderType.Woman,
                Email = "trainee4@example.com",
                MobileNo = "4567890123",
                BirthDate = new DateTime(2000, 4, 4),
                IsGraduated = false,
                TrackId = 2
            }
        };
    }
}
