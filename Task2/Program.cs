namespace Task2
{
    /*Задание 2
Напишите метод, который проверяет является ли
переданное число «палиндромом». Число передаётся в
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как
справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int pallnum = 1221;
            int notPallnum = 2345;

            Console.WriteLine("Число: {0}", pallnum); 
            bool reult = Pallindrome.IsPallindrome(pallnum);
            Pallindrome.Result(reult);

            Console.WriteLine("Число: {0}", notPallnum); 
            bool result2 = Pallindrome.IsPallindrome(notPallnum);
            Pallindrome.Result(result2);
        }
    }
}
