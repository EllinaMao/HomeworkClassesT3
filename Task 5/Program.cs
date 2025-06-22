namespace Task_5
{
    /*
     Задание 5
Создайте класс «Журнал». Необходимо хранить в
полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через
методы класса.

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Magasine magasine = new Magasine();
            magasine.InputName();
            magasine.InputDescription();
            magasine.InputEmail();
            magasine.InputPhone();
            magasine.YearOfCreation = Input.UserInput.GetDateTimeFromUser("dd.MM.yyyy");
            Console.WriteLine("Информация о журнале:");
            magasine.DisplayInfo();

        }
    }
}
