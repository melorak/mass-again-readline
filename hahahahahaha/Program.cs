using System;
using System.Collections.Generic;
using System.Linq;

namespace something
{
    internal class Program
    {
        // Заполняется "таблица".


        static void Main(string[] args)

        {
            List<People> database = new List<People>();



            for (int i = 0; i < 6; i++)
            {
                // Делвем так, чтобы можно было самому заполнить таблицу  (через ReadLine).
                People p1 = new People();
                p1.name = Console.ReadLine();
                p1.sekondname = Console.ReadLine();

                // Эта функция вносит в массив (как кнопка сохранить).
                database.Add(p1);
            }

            // foreach поочерёдно перебирает элементы массива.
            foreach (var p in database)
            {
                // Вывод каждого элемента.
                Console.WriteLine($"Имя: {p.name} Фамилия: {p.sekondname}");
            }
            Console.ReadKey();


        }

    }
    class People
    {
        // Создаю что-то наподобии базы данных как в Exel, чтобы можно было заполнять этот список.
        public string name { get; set; }
        public string sekondname { get; set; }

    }
} 