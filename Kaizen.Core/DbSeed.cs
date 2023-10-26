using Kaizen.Core.Models;
using Kaizen.Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.Core;

public static class DbSeed
{
    private static List<WeekDay> Days = new List<WeekDay>() { WeekDay.Monday, WeekDay.Tuesday, WeekDay.Wednesday, WeekDay.Thursday, WeekDay.Friday };

    public static List<TimeOnly> Times = new List<TimeOnly>() { TimeOnly.Parse("9:00"), TimeOnly.Parse("9:55"), TimeOnly.Parse("10:50"), TimeOnly.Parse("11:45"),
            TimeOnly.Parse("13:00"), TimeOnly.Parse("13:50"),  TimeOnly.Parse("14:35") };

    public static void Run(ModelBuilder modelBuilder)
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


        var i = 1;
        foreach (var day in Days)
        {
            foreach (var time in Times)
            {
                modelBuilder.Entity<TimeSlot>()
                   .HasData(new TimeSlot()
                   {
                       Id = i,
                       BeginTime = time,
                       EndTime = time.AddMinutes(45),
                       DayOfWeek = day
                   });
                i++;
            }
        }
    }
}
