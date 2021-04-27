using BootcampPractice.ApplicationCore.DomainModels;
using BootcampPractice.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BootcampPractice.Infrastructure.Data
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersContext _context;

        public UsersRepository(UsersContext context)
        {
            _context = context;
        }

        public async Task<User> Create(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            var userData = await _context.Users.AddAsync(new Models.User() { Id = Guid.Parse(user.Id), Email = user.Email, Name = user.Name });
            _context.SaveChanges();
            return user;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            var users = _context.Users.Select(x => new User { Id = x.Id.ToString(), Email = x.Email, Name = x.Name }).ToList();
            return Task.FromResult((IEnumerable<User>)users);
        }

        public Task<User> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
