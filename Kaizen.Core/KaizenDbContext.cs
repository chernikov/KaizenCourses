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

        base.OnModelCreating(modelBuilder);
    }
}
