using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using TimeSheet.Models;

namespace TimeSheet.Utilities
{
    public class GenericContext : DbContext
    {
        #region Member Variables
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeSheetExportHistory> timeSheetExportHistories { get; set; }
        public DbSet<TimeSheetEntry> timeSheetEntries { get; set; }
        public DbSet<SavedFile> savedFile { get; set; }
        public DbSet<ProjectTimelineHistory> projectTimelineHistories { get; set; }
        #endregion

        #region Relationship Management Area
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User Relations
            modelBuilder.Entity<User>()
                        .HasMany(obj => obj.linkedProjects)
                        .WithOne(obj => obj.user)
                        .HasForeignKey(obj => obj.userId);
            modelBuilder.Entity<User>()
                        .HasMany(obj => obj.linkedProjects)
                        .WithOne(obj => obj.user)
                        .HasForeignKey(obj => obj.userId);
            modelBuilder.Entity<User>()
                        .HasMany(obj => obj.timeSheetEntries)
                        .WithOne(obj => obj.user)
                        .HasForeignKey(obj => obj.userId);
            modelBuilder.Entity<User>()
                        .HasMany(obj => obj.timeSheetExportHistories)
                        .WithOne(obj => obj.user)
                        .HasForeignKey(obj => obj.userId);

            // Project Relations
            modelBuilder.Entity<Project>()
                        .HasMany(obj => obj.projectTimelineHistories)
                        .WithOne(obj => obj.project)
                        .HasForeignKey(obj => obj.projectId);
            modelBuilder.Entity<Project>()
                        .HasMany(obj => obj.timeSheetEntries)
                        .WithOne(obj => obj.project)
                        .HasForeignKey(obj => obj.projectId);

            // TimeSheetExportHistory Relations
            modelBuilder.Entity<TimeSheetExportHistory>()
                        .HasOne(obj => obj.savedFile)
                        .WithOne(obj => obj.timeSheetExportHistory);
            // User Relations
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //warning To protect potentially sensitive information in your connection string, 
            //    you should move it out of source code.See http://go.microsoft.com/fwlink/?LinkId=723263 
            //for guidance on storing connection strings.
            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        }
        #endregion

    }
}
