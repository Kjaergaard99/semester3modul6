using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace semester3modul6.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Todo> Tasks { get; set; }
        public string DbPath { get; }

        public TaskContext()
        {
            DbPath = "bin/TodoTask.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Board>().ToTable("Boards");
        }
    }
}