namespace Assignment3
{
    internal class Program
    {
        class Order
        {
            public int OrderId { get; set; }
            public int OrderAmount { get; set; }

            public virtual double CalculateShippingCost()
            {
                return 50;
            }
        }
        class StandardOrder : Order
        { 

            public override double CalculateShippingCost()
            {
                return 50;
            }
        }

        class ExpressOrder : Order
        {

            public override double CalculateShippingCost()
            {
                return 100;
            }
        }
        class InternationalOrder : Order
        {

            public override double CalculateShippingCost()
            {
                return 500;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            List<Order> orders = new List<Order>();

            orders.Add(new StandardOrder { OrderId = 1, OrderAmount = 1000 });
            orders.Add(new ExpressOrder { OrderId = 2, OrderAmount = 2000 });
            orders.Add(new InternationalOrder { OrderId = 3, OrderAmount = 3000 });

            foreach (Order order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}");
                Console.WriteLine($"Order Amount: {order.OrderAmount}");
                Console.WriteLine($"Shipping Cost: {order.CalculateShippingCost()}");
                Console.WriteLine($"Total Amount: {order.OrderAmount + order.CalculateShippingCost()}");
                Console.WriteLine("---------------------------");
            }
        }
    }
}
