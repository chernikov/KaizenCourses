using Kaizen.Core.Enums;
using Kaizen.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Kaizen.Core;

internal class PopulateDb
{

    private static List<WeekDay> weekDays = new List<WeekDay>() { WeekDay.Monday, WeekDay.Tuesday, WeekDay.Wednesday, WeekDay.Thursday, WeekDay.Friday };

    private static List<TimeOnly> timesOfStart = new List<TimeOnly>() {  TimeOnly.Parse("9:00"), TimeOnly.Parse("9:55"), TimeOnly.Parse("10:50"), TimeOnly.Parse("11:45"),
            TimeOnly.Parse("13:00"), TimeOnly.Parse("13:50"),  TimeOnly.Parse("14:35") };

    public static void PopulateRoles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>()
           .HasData(new Role()
           {
               Id = 1,
               Name = "Admin"
           });

        modelBuilder.Entity<Role>()
            .HasData(new Role()
            {
                Id = 2,
                Name = "Teacher"
            });

        modelBuilder.Entity<Role>()
            .HasData(new Role()
            {
                Id = 3,
                Name = "Schooler"
            });

        modelBuilder.Entity<Role>()
            .HasData(new Role()
            {
                Id = 4,
                Name = "Parent"
            });


    }

    public static void PopulateAdmin(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasData(new User()
            {
                Id = 1,
                Email = "admin",
                Password = "admin",
                FirstName = "admin",
                LastName = "admin"
            });

        modelBuilder.Entity<UserRole>()
            .HasData(new UserRole()
            {
                Id = 1,
                UserId = 1,
                RoleId = 1,
            });

    }
    public static void PopulateTimeSlots(ModelBuilder modelBuilder)
    {
        var id = 1;
        foreach (var day in weekDays)
        {
            foreach (var time in timesOfStart)
            {
                modelBuilder.Entity<TimeSlot>()
                  .HasData(new TimeSlot()
                  {
                      Id = id,
                      BeginTime = time,
                      EndTime = time.AddMinutes(45),
                      DayOfWeek = day
                  });
                id++;
            }
        }

    }
}
