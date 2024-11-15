using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika2_mobilki
{
    internal class Program
    {
       
            static int FindMax(int[] arr)
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }

    class Printer
        {
            public void PrintDocument(string document)
            {
                Console.WriteLine(document);
            }
        }

        class Person
        {
            private string firstName;
            private string lastName;

            public Person(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public void PrintFullName()
            {
                Console.WriteLine(firstName + " " + lastName);
            }
        }

        class Computer
        {
            private string model;

            public string Model
            {
                get { return model; }
                set { model = value; }
            }
        }

        class Food
        {
            public virtual void Prepare()
            {
                Console.WriteLine("Готовлю пищю...");
            }
        }

        class Pizza : Food
        {
            public override void Prepare()
            {
                Console.WriteLine("Готовлю пиццу...");
            }
        }

        class Salad : Food
        {
            public override void Prepare()
            {
                Console.WriteLine("Готовлю салат...");
            }
        }

        static void Main()
        {
            int[] numbers = { 10, 5, 20, 15, 8 };
            Console.WriteLine("Максимальное число: " + FindMax(numbers));

            Printer printer = new Printer();
            printer.PrintDocument("Привет дорогой!");

            Person person = new Person("Александр", "Филиппов");
            person.PrintFullName();

            Computer computer = new Computer();
            computer.Model = "Asus";
            Console.WriteLine("Модель компьютера: " + computer.Model);

            Food pizza = new Pizza();
            Food salad = new Salad();

            pizza.Prepare();
            salad.Prepare();
        }
    }
    
}
