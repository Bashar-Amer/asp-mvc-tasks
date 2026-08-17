
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models.Storage
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Task>()
            .HasKey(t => new { t.ManagerId, t.EmployeeId });

            builder.Entity<Task>()
            .HasOne(t => t.Manager)
            .WithMany(m=>m.Tasks)
            .HasForeignKey(t => t.ManagerId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Task>()
            .HasOne(t => t.Employee)
            .WithMany(e => e.Tasks)
            .HasForeignKey(t => t.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Department>().HasData(
                new Department { Id=1,Name="IT"},
                new Department { Id=2,Name="HR"}
            );
            builder.Entity<MaritalStatus>().HasData(
                new MaritalStatus { Id = 1, Name = "Married" },
                new MaritalStatus { Id = 2, Name = "Single" }
            );

            builder.Entity<Feedback>().HasData(
                new Feedback { Id = 1, Title = "That's good", Content = "I like it very much" },
                new Feedback { Id = 2, Title = "I don't like it", Content="Worse thing ever"}
            );

            builder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Ahmed Saleh", NationalId="9911", BirthDate=new (1990,5,1), Nationality="Jordanian",MaritalStatusId=1,Password="2hdf32e",DepartmentId=1},
                new Employee { Id = 2, Name = "Khaled Rami", NationalId="1199", BirthDate=new (1930,5,1), Nationality="Jordanian",MaritalStatusId=1,Password="zzz", DepartmentId = 2}
            );

            builder.Entity<Manager>().HasData(
                new Manager { Id = 1, Name = "Sami Khan", DepartmentId = 1 },
                new Manager { Id = 2, Name = "Zaid Kareem", DepartmentId = 2 }
            );


            builder.Entity<Task>().HasData(
                new Task { ManagerId = 1, EmployeeId=1, Title = "Check github", DueDate= new (2030, 5, 1) },
                new Task { ManagerId = 2, EmployeeId=1, Title = "Check client's needs", DueDate= new (2040, 5, 1) }
            );
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
