using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoginPanelConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Добро пожаловать.\nДля начала работы нужно зарегистрироваться." +
                " " + "Сначала введите имя пользователя, затем пароль.");

            Console.Write("\nИмя пользователя: ");
            string username_reg = Console.ReadLine();

            Console.Write("Пароль: ");
            string password_reg = Console.ReadLine();

            Console.WriteLine("\nВы прошли регистрацию. Теперь можете войти в систему.");
            Thread.Sleep(4000);
            Console.Clear();

            int trying = 3;

            while(trying >= 0)
            {
                Console.Write("Имя пользователя: ");
                string username = Console.ReadLine();

                Console.Write("Пароль: ");
                string password = Console.ReadLine();


                if (username != username_reg || password != password_reg)
                {
                    if (trying == 0) 
                    {
                        Console.WriteLine("\nИсчерпано количество попыток. Попробуйте через 24 часа.");
                        break; 
                    }
                    Console.WriteLine("\nПроверьте правильность имя пользователя или пароля. Осталось " + trying + " попытки.");
                    trying--;
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.Write("\nВы успешно вошли в учетную запись.");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
