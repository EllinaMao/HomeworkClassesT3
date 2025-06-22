using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{   
/*
Задание 4
Создайте класс «Веб-сайт». Необходимо хранить в
полях класса: название сайта, путь к сайту, описание
сайта, ip адрес сайта. Реализуйте методы класса для ввода
данных, вывода данных, реализуйте доступ к отдельным
полям через методы класса.
Задание 5
Создайте класс «Журнал». Необходимо хранить в
полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через
методы класса.
Задание 6
Создайте класс «Магазин». Необходимо хранить в
полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через
методы класса*/
    public interface INameIO
    {
        string Name { get; set; }
        void InputName();
    }
    public interface IDescriptionIO
    {
        string Description { get; set; }
        void InputDescription();
    }
    public interface IIPAddressIO
    {
        string IPAddress { get; set; }
        void InputIPAddress();
    }

    public interface IPhoneIO
    {
        long Phone { get; set; }
        void InputPhone();
    }
    public interface IEmailIO
    {
        MailAddress Email { get; set; }
        void InputEmail();
    }

    public interface IDisplayInfo
    {
        void DisplayInfo();
    }
}
