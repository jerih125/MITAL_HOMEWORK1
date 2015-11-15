using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var color = new CatColor();
            string age;
            
            Console.WriteLine("Вы купили кошку!");

            Console.Write("Введите возраст кошки: ");
            age = Console.ReadLine();

            var cat = new Cat(color, age);

            int i;
            do
            {
                Console.WriteLine("\nТекущая информация о кошке: \nИмя: " + cat.Name + "\nВозраст: " + cat.Age + "\nТекущий цвет: " + cat.CurrentColor);

                Console.Write("\n\nМеню: \n1)Дать кошке имя \n2) Изменить цвет здоровой кошки \n3) Изменить цвет больной кошки \n4) Наказать \n5) Покормить \n6) Выйти \n\nВаше решение: ");

                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.Write("Введите имя кошки: ");
                        cat.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Введите цвет здоровой кошки: ");
                        color.HealthyColor = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Введите цвет больной кошки: ");
                        color.SickColor = Console.ReadLine();
                        break;
                    case 4:
                        cat.Punish();
                        break;
                    case 5:
                        cat.Feed();
                        break;
                    case 6:
                        break;
                }
            } while (i != 6);
        }
    }
}
