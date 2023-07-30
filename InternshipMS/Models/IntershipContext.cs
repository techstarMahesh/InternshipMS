using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace InternshipMS.Models
{
    public partial class IntershipContext : DbContext
    {
        public IntershipContext()
            : base("name=IntershipContext")
        {
        }

        public virtual DbSet<Intern> Interns { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        public virtual DbSet<Remark> Remarks { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Intern>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Intern>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Intern>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Intern>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Intern>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Intern>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Intern>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Intern>()
                .Property(e => e.Pincode)
                .IsUnicode(false);

            modelBuilder.Entity<Intern>()
                .HasMany(e => e.Queries)
                .WithRequired(e => e.Intern)
                .HasForeignKey(e => e.Intern_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Intern>()
                .HasMany(e => e.Submissions)
                .WithRequired(e => e.Intern)
                .HasForeignKey(e => e.Intern_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Query>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<Query>()
                .HasMany(e => e.Replies)
                .WithRequired(e => e.Query)
                .HasForeignKey(e => e.Query_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Remark>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Reply>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.Role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Submission>()
                .Property(e => e.File_name)
                .IsUnicode(false);

            modelBuilder.Entity<Submission>()
                .HasMany(e => e.Remarks)
                .WithRequired(e => e.Submission)
                .HasForeignKey(e => e.Submission_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Queries)
                .WithRequired(e => e.Task)
                .HasForeignKey(e => e.Task_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Submissions)
                .WithRequired(e => e.Task)
                .HasForeignKey(e => e.Task_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Interns)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Guide_id)
                .WillCascadeOnDelete(false);
                
            modelBuilder.Entity<User>()
                .HasMany(e => e.Interns1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.User_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Queries)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Guide_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Remarks)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Guide_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Replies)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Guide_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Guide_id)
                .WillCascadeOnDelete(false);
        }
    }
}
