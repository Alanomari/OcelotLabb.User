using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;


namespace OcelotLabb.User
{
    public class UserRepository : IUserRepository
    {

        private readonly List<User> _users;
        public static UserRepository Instance;


        public UserRepository()
        {
            if (Instance == null)
            {
                Instance = this;
                _users = new List<User>();

                _users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Karlsson",
                    LastName = "På taket",
                    Adress = "Vulcanusgatan 12"

                });

                _users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Emil",
                    LastName = "I Lönneberga",
                    Adress = "Katthult"

                });
            }
        }

        public Task<User> AddUser(User user)
        {
            Instance._users.Add(new User
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.FirstName,
                Adress = user.Adress
                
            });
            return Task.FromResult(user);
        }

        public Task<List<User>> GetAllUsers()
        {
            return Task.FromResult(Instance._users);
        }
    }
}
