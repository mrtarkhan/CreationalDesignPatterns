using System;

namespace simpleFactory
{
    public class SimpleFactory {
        public IService CreateInstance(ServiceType type) {
            switch (type) {
                case ServiceType.UserService:
                {
                    return new UserService();
                }
                case ServiceType.OrderService:
                {
                    return new OrderService();
                }
                case ServiceType.ProductService:
                {
                    return new ProductService();
                }
                default: {
                    throw new NotImplementedException();
                }

            }
        }

    }


}