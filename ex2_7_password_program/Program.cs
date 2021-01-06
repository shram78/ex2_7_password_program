using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению. Пользователь вводит пароль,
далее происходит проверка пароля на правильность, и если пароль неверный, то попросите его ввести пароль ещё раз.
Если пароль подошёл, выведите секретное сообщение.
Если пользователь неверно ввел пароль 3 раза, программа завершается.*/

namespace ex2_7_password_program
{
    class Program
    {
        static void Main(string[] args)
        {
            string topSecretMessage = "I will be a game developer soon";
            string passwordForAccseMessage = "fallout";
            string userInputPassword;
            int tryCountPassword = 3;

            for (int i = 0; i < tryCountPassword; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Введите пароль для прочтения тайного сообщения:");
                userInputPassword = Console.ReadLine();
                if (userInputPassword == passwordForAccseMessage)
                {

                    Console.WriteLine("\nsecret message access allowed: \n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(topSecretMessage);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if ((tryCountPassword - i - 1)==0)
                    {
                        Console.WriteLine("access denied");
                        break;
                    }
                    Console.WriteLine($"access denied. you have {tryCountPassword - i - 1} attempts left");
                }
            }
            Console.ReadKey();
        }
    }
}
