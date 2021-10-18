using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApi1.KaniniModel
{
    public partial class stationaryContext : DbContext
    {
        public stationaryContext()
        {
        }

        public stationaryContext(DbContextOptions<stationaryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookingT> BookingTs { get; set; }
        public virtual DbSet<Bookingtbl> Bookingtbls { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Logintabl> Logintabls { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TicketBooking> TicketBookings { get; set; }
        public virtual DbSet<TicketBooking1> TicketBookings1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:bookingt.database.windows.net,1433;Initial Catalog=stationary;Persist Security Info=False;User ID=team8;Password=Teammovie@8;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BookingT>(entity =>
            {
                entity.ToTable("bookingT");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.MovieDescription)
                    .HasMaxLength(500)
                    .IsFixedLength(true);

                entity.Property(e => e.MovieName)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Bookingtbl>(entity =>
            {
                entity.ToTable("Bookingtbl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MovieDescription)
                    .HasMaxLength(500)
                    .IsFixedLength(true);

                entity.Property(e => e.MovieName)
                    .HasMaxLength(70)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Empid);

                entity.ToTable("Employee");

                entity.Property(e => e.Empid)
                    .ValueGeneratedNever()
                    .HasColumnName("empid");

                entity.Property(e => e.DataofJioin).HasColumnType("datetime");

                entity.Property(e => e.Empname)
                    .HasMaxLength(10)
                    .HasColumnName("empname")
                    .IsFixedLength(true);

                entity.Property(e => e.Empsalary)
                    .HasMaxLength(10)
                    .HasColumnName("empsalary")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Logintabl>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("Logintabl");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(10)
                    .HasColumnName("Login id")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PaymentDetail>(entity =>
            {
                entity.HasKey(e => e.CvvPin);

                entity.Property(e => e.CvvPin)
                    .ValueGeneratedNever()
                    .HasColumnName("Cvv_Pin");

                entity.Property(e => e.CardHolderName).HasColumnName("Card_Holder_Name");

                entity.Property(e => e.DebitCardNumber).HasColumnName("Debit_Card_Number");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("Expiry_Date");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("students");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TicketBooking>(entity =>
            {
                entity.HasKey(e => e.PhoneNumber);

                entity.ToTable("TicketBooking");

                entity.Property(e => e.PhoneNumber).ValueGeneratedNever();

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Time");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TicketBooking1>(entity =>
            {
                entity.HasKey(e => e.PhoneNumber);

                entity.ToTable("TicketBookings");

                entity.Property(e => e.PhoneNumber).ValueGeneratedNever();

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Time");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
