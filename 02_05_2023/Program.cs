using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_05_2023
{
    internal class Program
    {
        static void Main()
        {
            List<Person> person = new List<Person>()
            {
                new Person(){ Name = "Andrey", Age = 24, City = "Kyiv" },
                new Person(){ Name = "Liza", Age = 18, City = "Moscow" },
                new Person(){ Name = "Oleg", Age = 15, City = "London" },
                new Person(){ Name = "Sergey", Age = 55, City = "spb" },
                new Person(){ Name = "Sergey", Age = 32, City = "spb" }
            };
            Console.WriteLine("Люди старше 25 лет:");
            foreach (var item in (from p in person where p.Age > 25 select p).ToList())
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine("Люди, проживающие не в СПБ:");
            foreach (var item in (from p in person where p.City != "spb" select p).ToList())
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine("Имена людей, проживающих в СПБ:");
            foreach (var item in (from p in person where p.City == "spb" select p.Name).ToList())
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine("Люди старше 35 лет с именем Sergey:");
            foreach (var item in (from p in person where p.Age > 25 && p.Name == "Sergey" select p).ToList())
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine("Люди, проживающие в Москве:");
            foreach (var item in (from p in person where p.City == "Moscow" select p).ToList())
                Console.WriteLine(item);
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Name}\t{Age}\t{City}";
        }
    }
}
