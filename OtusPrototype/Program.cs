using System;
using System.Text;

namespace OtusPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new PopularComposition(id:1, title:"Asia", duration:new Duration(1, "Music"),
                                                       mark:1, genre:new Genre(1, "Folk Song"), beginDate:Convert.ToDateTime("1755-01-01"),
                                                       author:"I.Susanin", createDate:Convert.ToDateTime("1755-12-01"), style:new Style(1, "Classic"));

            // выполним поверхностное копирование p1 и присвоим её p2.
            //var p2 = (PopularComposition)p1.ShallowCopy();

            // сделаем глубокую копию p1 и присвоим её p3.
             PopularComposition p3 = p1.DeepClone();
            // сделаем копию p1 стандартным методом Clone() и присвоим её p3.
            // необходимо приведение типа
            var p4 = (PopularComposition)p1.Clone();

            // Вывести значения p1, p2 и p3.
            Console.WriteLine("Original values of p1, p3, p4:");
            Console.WriteLine("p1 instance values: ");
            DisplayValues(p1);
            //Console.WriteLine("p2 instance values:");
            //DisplayValues(p2);
            Console.WriteLine("p3 instance values:");
            DisplayValues(p3);
            Console.WriteLine("p4 instance values:");
            DisplayValues(p4);

            // Изменить значение свойств p1 и отобразить значения p1, p2, p3, p4.
            p1.Id = 2;
            p1.CreateDate = new DateTime(1900,04,06);//Convert.ToDateTime("1900-01-01");
            p1.Title = new string("Popule Song");
            p1.Duration.Id = 2;
            p1.Duration.Name = "Cinemy";

            p1.Mark = 2;
            p1.BeginDate = new DateTime(2000, 02, 03);
            // p1.Genre = new Genre(2, "Popule"); //<-так глубокое копирование не работает
            p1.Genre.Id = 2;
            p1.Genre.Name = "Newera";

            p1.Author = "L.Armstrong";
            p1.CreateDate = new DateTime(2025, 01, 13);
            p1.Style.Id = 2;
            p1.Style.Name = "Latine";

            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("p1 instance values: ");
            DisplayValues(p1);
            //Console.WriteLine("p2 instance values (reference values have changed):");
            //DisplayValues(p2);
            Console.WriteLine("p3(metod DeepClone) instance values (everything was kept the same):");
            DisplayValues(p3);
            Console.WriteLine("p4(metod Clone) instance values (everything was kept the same):");
            DisplayValues(p4);
        }

        public static void DisplayValues(PopularComposition p)
        { 
            Console.WriteLine($"   ID#: {p.Id:d}, Title: {p.Title:s}, Duration.Id: {p.Duration.Id:d}, Duration.Name: {p.Duration.Name:s} \n" 
                            + $"   Mark#: {p.Mark:d}, BeginDate {p.BeginDate:MM/dd/yyyy}, Genre.Id:  {p.Genre.Id:d}, Genre.Name:  {p.Genre.Name:s}\n"
                            + $"   Author: {p.Author:s}, CreateDate {p.CreateDate:MM/dd/yyyy}, Style.Id:  {p.Style.Id:d}, Style.Name:  {p.Style.Name:s}\n");
        }
    }   
}
