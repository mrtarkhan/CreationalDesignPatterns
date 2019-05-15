using System;

namespace simpleFactory
{
    public class UserService : IService {

        public void Handle() {
            Console.WriteLine("this is from UserService");
        }

    }


}