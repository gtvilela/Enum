using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }

    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }

    class Order
    {
       public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
