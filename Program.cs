using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    internal class Program
    {
        public static UserService userService = new UserService();
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в социальную сеть!");

            while (true)
            {
                Console.WriteLine("Для регистрации введите имя пользователя");

                string firstName = Console.ReadLine();

                Console.Write("Фамилия: ");
                string lastName = Console.ReadLine();

                Console.Write("Пароль: ");
                string password = Console.ReadLine();

                Console.Write("Почтовый адрес: ");
                string eMail = Console.ReadLine();

                UserRegistrationData userRegistrationData = new UserRegistrationData()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    Email = eMail
                };

                try
                {
                    userService.Register(userRegistrationData);
                    Console.WriteLine("Регистрация успешная");
                }
                catch (ArgumentNullException) { Console.WriteLine("Введите корректные данные"); }
                catch (Exception ex)
                {
                    //Console.WriteLine("Произошла ошибка при регистрации"); 
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }
}
