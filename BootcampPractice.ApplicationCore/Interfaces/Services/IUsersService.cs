using BootcampPractice.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampPractice.ApplicationCore.Interfaces.Services
{
    public interface IUsersService
    {
        Task<User> CreateUser(User user);
        Task<IEnumerable<User>> GetAll();
    }
}
