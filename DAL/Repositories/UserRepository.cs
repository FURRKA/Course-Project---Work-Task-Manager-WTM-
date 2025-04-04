﻿using DAL.DBContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal class UserRepository : Repository<User>
    {
        public UserRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
