using System;

namespace factoryMethod
{
    public class UserService : IService {

        public void Handle() {
            Console.WriteLine("this is from UserService");
        }

    }


}