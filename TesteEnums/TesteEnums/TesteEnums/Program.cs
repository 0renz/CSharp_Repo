using TesteEnums.Entities;
using TesteEnums.Entities.Enums;

namespace TesteEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            OrderStatus order2 = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(order2);
        }
    }
}

