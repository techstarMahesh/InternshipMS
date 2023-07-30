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

        public virtual DbSet<intern> interns { get; set; }
        public virtual DbSet<query> queries { get; set; }
        public virtual DbSet<remark> remarks { get; set; }
        public virtual DbSet<reply> replies { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<submission> submissions { get; set; }
        public virtual DbSet<task> tasks { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<intern>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<intern>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<intern>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<intern>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<intern>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<intern>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<intern>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<intern>()
                .Property(e => e.pincode)
                .IsUnicode(false);

            modelBuilder.Entity<intern>()
                .HasMany(e => e.queries)
                .WithRequired(e => e.intern)
                .HasForeignKey(e => e.intern_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<intern>()
                .HasMany(e => e.submissions)
                .WithRequired(e => e.intern)
                .HasForeignKey(e => e.intern_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<query>()
                .Property(e => e.question)
                .IsUnicode(false);

            modelBuilder.Entity<query>()
                .HasMany(e => e.replies)
                .WithRequired(e => e.query)
                .HasForeignKey(e => e.query_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<remark>()
                .Property(e => e.remark1)
                .IsUnicode(false);

            modelBuilder.Entity<reply>()
                .Property(e => e.answer)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.users)
                .WithRequired(e => e.role)
                .HasForeignKey(e => e.role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<submission>()
                .Property(e => e.file_name)
                .IsUnicode(false);

            modelBuilder.Entity<submission>()
                .HasMany(e => e.remarks)
                .WithRequired(e => e.submission)
                .HasForeignKey(e => e.submission_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<task>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<task>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<task>()
                .HasMany(e => e.queries)
                .WithRequired(e => e.task)
                .HasForeignKey(e => e.task_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<task>()
                .HasMany(e => e.submissions)
                .WithRequired(e => e.task)
                .HasForeignKey(e => e.task_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.interns)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.guide_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.interns1)
                .WithRequired(e => e.user1)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.queries)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.guide_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.remarks)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.guide_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.replies)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.guide_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.tasks)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.guide_id)
                .WillCascadeOnDelete(false);
        }
    }
}
