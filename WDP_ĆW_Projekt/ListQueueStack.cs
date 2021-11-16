using System;
using System.Collections.Generic;
using System.Linq;

namespace WDP_Projekt
{
    public class ListQueueStack
    {
        public void Example()
        {
            Console.Write("\nList of Class functionalities:\n" +
                          "1. List\n" +
                          "2. Queue\n" +
                          "3. Stack\n" +
                          "q. Quit" +
                          "\nPlease select what You would like to test (select 1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListTest();
                    break;

                case "2":
                    QueueTest();
                    break;

                case "3":
                    StackTest();
                    break;

                case "q":
                    Menu menu = new Menu();
                    menu.Switches();
                    break;

                default:
                    Console.WriteLine("\nSelected '" + choice + "' does not exist, please try again.");
                    Example();
                    break;
            }
        }

        public void ListTest()
        {
            List<Car> list = new List<Car>();
            do
            {
                Console.WriteLine("\nAdd car to garadge");

                Console.Write("Car Brand: ");
                string brand = Console.ReadLine();

                Console.Write("Car Model: ");
                string model = Console.ReadLine();

                list.Add(new Car(brand, model));

                Console.WriteLine("\nIn Your garadge You have:");
                foreach (var car in list)
                {
                    Console.WriteLine($"{car.brand} {car.model}");
                }

                Console.Write("\nWould You like to add another car?(y-Yes q-Quit): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "y":
                        break;

                    case "q":
                        Example();
                        break;

                    default:
                        Console.WriteLine("\nSelected '" + choice + "' does not exist, please try again.");
                        Example();
                        break;
                }
            } while (true);
        }

        public void QueueTest()
        {
            Queue<string> queue = new Queue<string>();
            do
            {
             Console.WriteLine("\nAdd 5 names to stand in queue");

            Console.Write("1st person name: ");
            string name1 = Console.ReadLine();

                Console.Write("2nd person name: ");
                string name2 = Console.ReadLine();

                Console.Write("3rd person name: ");
                string name3 = Console.ReadLine();

                Console.Write("4th person name: ");
                string name4 = Console.ReadLine();

                Console.Write("5th person name: ");
                string name5 = Console.ReadLine();

                queue.Enqueue(name1);
                queue.Enqueue(name2);
                queue.Enqueue(name3);
                queue.Enqueue(name4);
                queue.Enqueue(name5);

                Console.WriteLine("\nPeople that stand in queue are:");
            foreach (var person in queue)
            {
                Console.WriteLine(person);
            }

            Console.Write("\nChoose action:\n" +
                "y-create new queue\n" +
                "r-remove selected person from queue\n" +
                "d-deleted everybody from queue\n" +
                "q-Quit\n" +
                "Select: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "y":
                    QueueTest();
                    break;

                    case "r":
                        Console.Write("\nPlese provide name to be removed:");
                        string removeName = Console.ReadLine();

                        queue = new Queue<string>(queue.Where(x => x != removeName));

                        Console.WriteLine("\nPeople that stand in queue are:");
                        foreach (var person in queue)
                        {
                            Console.WriteLine(person);
                        }
                        QueueTest();
                        break;

                    case "d":
                        queue.Dequeue();
                        Console.WriteLine("\nQueue has been cleared");
                        QueueTest();
                        break;

                    case "q":
                    Example();
                    break;

                default:
                    Console.WriteLine("\nSelected '" + choice + "' does not exist, please try again.");
                    Example();
                    break;
            }
        } while (true);
        }

        public void StackTest()
        {
            Stack<String> stack = new Stack<string>();
            do
            {
                Console.WriteLine("\nAdd products to stack:");

                Console.Write("1st product: ");
                string product1 = Console.ReadLine();

                Console.Write("2nd product: ");
                string product2 = Console.ReadLine();

                Console.Write("3rd product: ");
                string product3 = Console.ReadLine();

                Console.Write("4th product: ");
                string product4 = Console.ReadLine();

                Console.Write("5th product: ");
                string product5 = Console.ReadLine();

                stack.Push(product1);
                stack.Push(product2);
                stack.Push(product3);
                stack.Push(product4);
                stack.Push(product5);

                Console.WriteLine("\nProducts in stack:");
                foreach (var prodcuts in stack)
                {
                    Console.WriteLine(prodcuts);
                }

                Console.Write("\nChoose action:\n" +
                    "y-create new stack\n" +
                    "r-remove top element in stack\n" +
                    "d-deleted everything from stack\n" +
                    "q-Quit\n" +
                    "Select: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "y":
                        QueueTest();
                        break;

                    case "r":
                        stack.Pop();
                        Console.WriteLine("\nProducts after removing top element:");
                        foreach (var prodcuts in stack)
                        {
                            Console.WriteLine(prodcuts);
                        }
                        StackTest();
                        break;

                    case "d":
                        stack.Clear();
                        Console.WriteLine("\nStack has been cleared");
                        StackTest();
                        break;

                    case "q":
                        Example();
                        break;

                    default:
                        Console.WriteLine("\nSelected '" + choice + "' does not exist, please try again.");
                        Example();
                        break;
                }
            } while (true);
        }

    }

    class Car
    {
        public string brand;
        public string model;

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}
