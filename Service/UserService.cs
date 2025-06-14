using BE_PhysGen.Repositories;

namespace BE_PhysGen.Service
{
    public class UserService : IUsersService
    {
        private readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

    }
}
