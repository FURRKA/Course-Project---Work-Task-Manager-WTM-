﻿using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Comment> Comments { get; }
        IRepository<Tag> Tags { get; }
        IRepository<Entities.Task> Tasks { get; }
        IRepository<Project> Projects { get; }

        public void Save();
    }
}
