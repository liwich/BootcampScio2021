﻿using BootcampPractice.ApplicationCore.DomainModels;
using BootcampPractice.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampPractice.Infrastructure.Data
{
    public class IMUsersRepository : IUsersRepository
    {
        List<User> Users = new List<User>();

        public Task<User> Create(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            Users.Add(user);

            return Task.FromResult(user);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            return Task.FromResult((IEnumerable<User>)Users);
        }

        public Task<User> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
