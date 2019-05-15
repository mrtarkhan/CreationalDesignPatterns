
namespace dependencyInjection {
    public class UserService : IUserService 
    {

        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public void Handle() 
        {
            _userRepository.Handle();
        }

    }
}