
using System;

namespace dependencyInjection {
    public class UserRepository : IUserRepository 
    {
        
        public void Handle() {
            Console.WriteLine("this is from UserRepository");
        }

    }
}