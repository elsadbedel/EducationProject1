﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduProject.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EducationProjectEntities2 : DbContext
    {
        public EducationProjectEntities2()
            : base("name=EducationProjectEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AssignTask> AssignTasks { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupCategory> GroupCategories { get; set; }
        public virtual DbSet<GroupCategoryType> GroupCategoryTypes { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskCategory> TaskCategories { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Transcript> Transcripts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
    }
}
