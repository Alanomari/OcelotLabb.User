using System.Collections.Generic;
using System.Threading.Tasks;

namespace OcelotLabb.User
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsers();
        public Task<User> AddUser(User user);
    }
}
