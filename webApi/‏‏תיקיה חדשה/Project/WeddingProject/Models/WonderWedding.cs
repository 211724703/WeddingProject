using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WeddingProject.Models
{
    public partial class WonderWedding : DbContext
    {
        public WonderWedding()
        {
        }

        public WonderWedding(DbContextOptions<WonderWedding> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Sadottype> Sadottype { get; set; }
        public virtual DbSet<Sadottypeofworker> Sadottypeofworker { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Tasksbyrating> Tasksbyrating { get; set; }
        public virtual DbSet<Typeofworker> Typeofworker { get; set; }
        public virtual DbSet<Typetouser> Typetouser { get; set; }
        public virtual DbSet<Valuestosadeofworker> Valuestosadeofworker { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
        public virtual DbSet<Workersregistration> Workersregistration { get; set; }
        public virtual DbSet<Workertowedding> Workertowedding { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DB\\אילה\\Databaseee.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateWedding).HasColumnType("date");

                entity.Property(e => e.MailCala)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailChatan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Namchatan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameCala)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.FeedbackId).ValueGeneratedNever();

                entity.Property(e => e.Discreptionfeedback)
                    .IsRequired()
                    .HasColumnName("discreptionfeedback")
                    .HasMaxLength(50);

                entity.Property(e => e.MailChatan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Workerid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_ToTable_1");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.Workerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_ToTable");
            });

            modelBuilder.Entity<Sadottype>(entity =>
            {
                entity.HasKey(e => e.Sadetypeid);

                entity.Property(e => e.Sadetypeid).ValueGeneratedNever();

                entity.Property(e => e.Sadetypeteur)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Sadottypeofworker>(entity =>
            {
                entity.HasKey(e => e.Sadeid);

                entity.Property(e => e.Sadeid).ValueGeneratedNever();

                entity.Property(e => e.Sadename)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Sadetype)
                    .WithMany(p => p.Sadottypeofworker)
                    .HasForeignKey(d => d.Sadetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sadot type of worker_ToTable");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Sadottypeofworker)
                    .HasForeignKey(d => d.Typeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sadottypeofworker_ToTable");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Statusid).ValueGeneratedNever();

                entity.Property(e => e.Statusname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tasksbyrating>(entity =>
            {
                entity.Property(e => e.TasksbyratingId).ValueGeneratedNever();

                entity.Property(e => e.Nametasksbyrating)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Typeofworker>(entity =>
            {
                entity.HasKey(e => e.Typeid);

                entity.Property(e => e.Misusetotipe)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nametype)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Typetouser>(entity =>
            {
                entity.Property(e => e.Typetouserid).ValueGeneratedNever();

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Typetouser)
                    .HasForeignKey(d => d.Typeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Typetouser_ToTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Typetouser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Typetouser_ToTable_1");
            });

            modelBuilder.Entity<Valuestosadeofworker>(entity =>
            {
                entity.Property(e => e.Valuestosadeofworkerid).ValueGeneratedNever();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(50);

                entity.Property(e => e.Workerid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Sade)
                    .WithMany(p => p.Valuestosadeofworker)
                    .HasForeignKey(d => d.Sadeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Valuestosadeofworker_ToTable_1");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Valuestosadeofworker)
                    .HasForeignKey(d => d.Workerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Valuestosadeofworker_ToTable");
            });

            modelBuilder.Entity<Workers>(entity =>
            {
                entity.HasKey(e => e.Workerid)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.Workerid)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Mailworker)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nameworker)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.Typeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workers_ToTable");
            });

            modelBuilder.Entity<Workersregistration>(entity =>
            {
                entity.Property(e => e.WorkersregistrationId).ValueGeneratedNever();

                entity.Property(e => e.Dateworkersregistration).HasColumnType("date");

                entity.Property(e => e.Discreptionworkersregistration)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mailworker)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Workersregistration)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_avaliableofworker_ToTable");
            });

            modelBuilder.Entity<Workertowedding>(entity =>
            {
                entity.Property(e => e.Workertoweddingid).ValueGeneratedNever();

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Workerid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Workertowedding)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workertowedding_ToTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Workertowedding)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workertowedding_ToTable_1");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Workertowedding)
                    .HasForeignKey(d => d.Workerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workertowedding_ToTable_2");
            });
        }
    }
}
