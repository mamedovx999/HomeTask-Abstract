namespace HomeTask_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account();
            //Console.WriteLine("Username daxil edin");
            //account.Username = Console.ReadLine();
            //Console.WriteLine("Sifre Daxil eidn");
            //account.Password = Console.ReadLine();
            //account.CheckLogin(account.Username,account.Password);

            Product product = new Product();
            Console.WriteLine("ad daxil edin");
            string name = Console.ReadLine();
            product.Name = name;
            Console.WriteLine("qiymet daxil ele");
            int price = int.Parse(Console.ReadLine());
            product.Price = price;
            Console.WriteLine("Say daxil ele");
            int count = int.Parse(Console.ReadLine());
            product.Count = count;

            Console.WriteLine("Discount rate daxil et:");
            int discount= int.Parse(Console.ReadLine());

            product.Discount(discount);



        }
    }

}
