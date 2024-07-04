using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;

            Console.Write("Введите размер массива: ");
            while (size <= 0)
            {
                try
                {
                    size = int.Parse(Console.ReadLine());
                    if (size == 0)
                    {
                        Console.Write("Размер массива не может быть равен нулю! Повторите ввод: ");
                    }
                    if (size < 0)
                    {
                        Console.Write("Размер массива не может быть отрицательным! Повторите ввод:");
                    }
                }
                catch
                {
                    Console.Write("Размер массива должен быть целым числом.\nВведите корректное значение для размера массива: ");
                }
            }
            Console.Write("\n");

            Newsstand newsstand = new Newsstand(size);

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите название {i + 1}-го журнала: ");
                string name = Console.ReadLine();
                while (string.IsNullOrEmpty(name))
                {
                    Console.Write($"Поле не должно быть пустым.\nВведите название {i + 1}-го журнала: ");
                    name = Console.ReadLine();
                }

                Console.Write($"Введите издателя для {i + 1}-го журнала: ");
                string corparation = Console.ReadLine();
                while (string.IsNullOrEmpty(corparation))
                {
                    Console.Write($"Поле не должно быть пустым.\nВведите издателя для {i + 1}-го журнала: ");
                    corparation = Console.ReadLine();
                }

                double price = 0;


                Console.Write($"Введите цену для {i + 1}-го журнала: ");
                while (price <= 0)
                {
                    try
                    {
                        price = double.Parse(Console.ReadLine());

                        if (price < 0)
                        {
                            Console.Write("Цена не может быть отрицательной! Повторите ввод: ");
                        }
                    }
                    catch
                    {
                        Console.Write($"Введите корректное значение для цены журнала: ");
                    }
                }

                Console.Write($"Введите isnn для {i + 1}-го журнала: ");
                string isnn = Console.ReadLine();
                while (string.IsNullOrEmpty(isnn))
                {
                    Console.Write($"Поле не должно быть пустым.\nВведите isnn для {i + 1}-го журнала: ");
                    isnn = Console.ReadLine();
                }

                Console.Write("\n");
                newsstand.magazines[i] = new Magazine { name = name, corparation = corparation, price = price, issn = isnn };

            }

            newsstand.sort();
            newsstand.saveToFile("saveArray.txt");

        }
    }
}
