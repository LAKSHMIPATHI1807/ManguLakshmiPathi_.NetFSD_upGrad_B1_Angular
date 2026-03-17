namespace Assignment6
{
    internal class Program
    {
        class Furniture
        {
            public int OrderId;
            public string OrderDate;
            public string FurnitureType;
            public int Qty;
            public double TotalAmt;
            public string PaymentMode;

            public virtual void GetData()
            {
                Console.WriteLine("Enter OrderId: ");
                OrderId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter OrderDate: ");
                OrderDate = Console.ReadLine();

            }
        }
        class Chair : Furniture
        {
            public string ChairType;
            public string Purpose;
            public double Rate;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
