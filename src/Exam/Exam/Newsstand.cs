using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exam
{
    public class Newsstand
    {
        public Magazine[] magazines;
        public Newsstand(int size)
        {
            magazines = new Magazine[size];
        }
        //сортировка массива по убыванию
        public void sort()
        {
            magazines = magazines.OrderByDescending(m => m.price)
                                 .OrderByDescending(m => m.name)
                                 .ToArray();
        }

        //сохранение массива в файл
        public void saveToFile(string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (Magazine magazine in magazines)
                        sw.WriteLine($"Журнал {magazine.name} от издателя {magazine.corparation}, цена: {magazine.price}, номер ISSN: {magazine.issn}");
                }
                Console.WriteLine($"Данные успешно записаны в файл {fileName}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка записи данных в файл: {e.Message}");
            }

        }

    }
}



