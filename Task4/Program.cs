namespace Task4
{
    internal class Program
    {    /*
Задание 4
Создайте класс «Веб-сайт». Необходимо хранить в
полях класса: название сайта, путь к сайту, описание
сайта, ip адрес сайта. Реализуйте методы класса для ввода
данных, вывода данных, реализуйте доступ к отдельным
полям через методы класса.
*/
        static void Main(string[] args)
        {
            WebSite webSite = new WebSite("name", "path", "description", "ipAdress");
            webSite.DisplayInfo();

        }
    }
}
