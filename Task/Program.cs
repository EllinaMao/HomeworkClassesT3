namespace Task
{
    /*
Задание 1
Напишите метод, который отображает квадрат из
некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            char simb = '*';
            int side = 10;
            
            Square.PrintSquare(simb, side);
        }
    }
}
