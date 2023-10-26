using Kaizen.Core.Converters;
using Kaizen.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Kaizen.Core;

public class KaizenDbContext : DbContext
{
    public DbSet<ClassRoom> ClassRooms { get; set; }

    public DbSet<Grade> Grades { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Schedule> Schedules { get; set; }

    public DbSet<Subject> Subjects { get; set; }

    public DbSet<TeacherOfSubject> TeacherOfSubjects { get; set; }

    public DbSet<TimeSlot> TimeSlots { get; set; }


    public DbSet<User> Users { get; set; }

    public DbSet<UserRole> UserRoles { get; set; }

    public KaizenDbContext(DbContextOptions<KaizenDbContext> options) : base(options)
    {

    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        configurationBuilder.Properties<DateOnly>()
              .HaveConversion<DateOnlyConverter>();
        configurationBuilder.Properties<TimeOnly>()
                      .HaveConversion<TimeOnlyConverter>();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        DbSeed.Run(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}
