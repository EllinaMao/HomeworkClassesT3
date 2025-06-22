namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.InputName();
            shop.InputDescription();
            shop.InputEmail();
            shop.InputPhone();
            shop.InputAdress();
            Console.WriteLine("Информация о магазине:");
            shop.DisplayInfo();
        }
    }
}
