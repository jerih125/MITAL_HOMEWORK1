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
            var Cat = new Cat(color);            

            int i;
            do
            {
                Cat.SetCurrentColor();
                Console.WriteLine("Текущая информация о кошке.\nИмя: " + Cat.Name + "\nВозраст: " + Cat.Age + "\nТекущий цвет: " + Cat.CurrentColor);

                Console.Write("\n\nМеню:\n1) Купить кота \n2) Задать цвет \n3) Наказать \n4) Покормить \n5) Выйти \n\nВаше решение: ");

                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.Write("Введите имя кошки: ");
                        Cat.Name = Console.ReadLine();
                        Console.Write("Введите возраст кошки: ");
                        Cat.Age = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Введите цвет кошки: ");
                        color.HealthyColor = Console.ReadLine();
                        break;
                    case 3:
                        Cat.Punish();
                        break;
                    case 4:
                        Cat.Feed();
                        break;
                    case 5:
                        break;
                }
            } while (i != 5);
        }
    }
}
