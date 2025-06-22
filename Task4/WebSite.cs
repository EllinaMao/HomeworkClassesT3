using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
Задание 4
Создайте класс «Веб-сайт». Необходимо хранить в
полях класса: 1название сайта,2 путь к сайту, 3 описание
сайта, 4 ip адрес сайта. Реализуйте методы класса для ввода
данных, вывода данных, реализуйте доступ к отдельным
полям через методы класса.
     */
    public class WebSite : INameIO,  IDescriptionIO, IIPAddressIO, IDisplayInfo { 
    
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string IPAddress { get; set; }

        public WebSite()
        {
            Name = string.Empty;
            Path = string.Empty;
            Description = string.Empty;
            IPAddress = string.Empty;
        }
        public WebSite(string name, string path, string description, string ipAdress)
        {
            Name = name;
            Path = path;
            Description = description;
            IPAddress = ipAdress;
        }
        public void InputName()
        {
            Console.Write("Введите название сайта: ");
            Name = Input.UserInput.GetStringFromUser();
        }
        public void InputPath()
        {
            Console.Write("Введите путь к сайту: ");
            Path = Input.UserInput.GetStringFromUser();
        }
        public void InputDescription()
        {
            Console.Write("Введите описание сайта: ");
            Description = Input.UserInput.GetStringFromUser();
        }
        public void InputIPAddress()
        {
            Console.Write("Введите IP адрес сайта: ");
            IPAddress = Input.UserInput.GetStringFromUser();
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Название сайта: {Name}");
            Console.WriteLine($"Путь к сайту: {Path}");
            Console.WriteLine($"Описание сайта: {Description}");
            Console.WriteLine($"IP адрес сайта: {IPAddress}");
        }

    }

}
