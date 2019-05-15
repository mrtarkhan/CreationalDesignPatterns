using System;

namespace simpleFactory
{
    public enum ServiceType : byte {

        UserService,
        OrderService = 10,
        ProductService = 20

    }

}