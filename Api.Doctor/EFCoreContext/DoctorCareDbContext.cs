
using Api.Doctor.Models;
using Microsoft.EntityFrameworkCore;


namespace Api.Doctor.EFCoreContext
{
    public class DoctorCareDbContext : DbContext
    {
        public DoctorCareDbContext(DbContextOptions<DoctorCareDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);database=DoctorCare;uid=sa;pwd=sa;Encrypt=false;");
            //optionsBuilder.UseSqlServer("server=LPP00107461A;database=SchoolDb03;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Clinic> Clinics { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<DoctorUser> DoctorUsers { get; set; } = null!;
        public DbSet<ExtraInfo> ExtraInfos { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Place> Places { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Schedule> Schedules { get; set; } = null!;
        public DbSet<SequelizeMeta> SequelizeMeta { get; set; } = null!;
        public DbSet<Session> Sessions { get; set; } = null!;
        public DbSet<Specialization> Specializations { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;
        public DbSet<SupporterLog> SupporterLogs { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình mặc định cho Gender và IsActive nếu cần
            modelBuilder.Entity<User>()
                .Property(u => u.Gender)
                .HasDefaultValue("male");

            modelBuilder.Entity<User>()
                .Property(u => u.IsActive)
                .HasDefaultValue(true);

            // Cấu hình quan hệ cho DoctorUser
            modelBuilder.Entity<DoctorUser>()
                .HasOne(du => du.Clinic)
                .WithMany(c => c.DoctorUsers)
                .HasForeignKey(du => du.ClinicId);

            modelBuilder.Entity<DoctorUser>()
                .HasOne(du => du.Specialization)
                .WithMany(s => s.DoctorUsers)
                .HasForeignKey(du => du.SpecializationId);

            modelBuilder.Entity<DoctorUser>()
                .HasOne(du => du.Doctor)
                .WithMany(u => u.DoctorUsers)
                .HasForeignKey(du => du.DoctorId);

            // Cấu hình cho Patient
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Doctor)
                .WithMany(u => u.Patients)
                .HasForeignKey(p => p.DoctorId);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Status)
                .WithMany(s => s.Patients)
                .HasForeignKey(p => p.StatusId);

            // Cấu hình cho Post
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Clinic)
                .WithMany(c => c.Posts)
                .HasForeignKey(p => p.ForClinicId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Specialization)
                .WithMany(s => s.Posts)
                .HasForeignKey(p => p.ForSpecializationId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.ForDoctor)
                .WithMany(u => u.PostsForDoctor)
                .HasForeignKey(p => p.ForDoctorId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Writer)
                .WithMany(u => u.WrittenPosts)
                .HasForeignKey(p => p.WriterId);

            // Cấu hình cho Schedule
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Doctor)
                .WithMany(u => u.Schedules)
                .HasForeignKey(s => s.DoctorId);

            // Cấu hình cho Comment
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Doctor)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.DoctorId);

            // Cấu hình cho ExtraInfo
            modelBuilder.Entity<ExtraInfo>()
                .HasOne(e => e.Patient)
                .WithOne(p => p.ExtraInfo)
                .HasForeignKey<ExtraInfo>(e => e.PatientId);

            // Cấu hình cho SupporterLog
            modelBuilder.Entity<SupporterLog>()
                .HasOne(sl => sl.Patient)
                .WithMany(p => p.SupporterLogs)
                .HasForeignKey(sl => sl.PatientId);

            modelBuilder.Entity<SupporterLog>()
                .HasOne(sl => sl.Supporter)
                .WithMany(u => u.SupporterLogs)
                .HasForeignKey(sl => sl.SupporterId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

