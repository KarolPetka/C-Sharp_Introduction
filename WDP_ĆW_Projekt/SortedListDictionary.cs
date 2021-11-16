using System;
using System.Collections;
using System.Collections.Generic;

namespace WDP_Projekt
{
    public class SortedListDictionary
    {
        public void Example()
        {
            Console.Write("\nList of Class functionalities:\n" +
              "1. SortedList\n" +
              "2. Dictionary\n" +
              "q. Quit" +
              "\nPlease select what You would like to test (select 1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SortedListTest();
                    break;

                case "2":
                    DictionaryTest();
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

        public void SortedListTest()
        {
            SortedList sortedList = new SortedList();

            Console.WriteLine("\nAdd four rank(key) and product(value)");

            Console.Write("Rank(key): ");
            string key1 = Console.ReadLine();

            Console.Write("Product(value): ");
            string value1 = Console.ReadLine();

            Console.Write("Rank(key): ");
            string key2 = Console.ReadLine();

            Console.Write("Product(value): ");
            string value2 = Console.ReadLine();

            Console.Write("Rank(key): ");
            string key3 = Console.ReadLine();

            Console.Write("Product(value): ");
            string value3 = Console.ReadLine();

            Console.Write("Rank(key): ");
            string key4 = Console.ReadLine();

            Console.Write("Product(value): ");
            string value4 = Console.ReadLine();

            sortedList.Add(key1, value1);
            sortedList.Add(key2, value2);
            sortedList.Add(key3, value3);
            sortedList.Add(key4, value4);

            Console.WriteLine("\nProduct list:");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine($"Rank(key):{sortedList.GetKey(i)}, Product(value):{sortedList.GetByIndex(i)}");
            }

            Console.Write("\nChoose action:\n" +
           "r-remove product based on rank\n" +
           "d-deleted everything from list\n" +
           "q-Quit\n" +
           "Select: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "r":
                    Console.Write("\nPlease provide rank to be removed: ");
                    string removeProduct = Console.ReadLine();

                    sortedList.Remove(removeProduct);

                    Console.WriteLine("\nCurrent list:");
                    for (int i = 0; i < sortedList.Count; i++)
                    {
                        Console.WriteLine($"Rank(key):{sortedList.GetKey(i)}, Product(value):{sortedList.GetByIndex(i)}");
                    }
                    Example();
                    break;

                case "d":
                    sortedList.Clear();
                    Console.WriteLine("\nList has been cleared");
                    Example();
                    break;

                case "q":
                    Example();
                    break;

                default:
                    Console.WriteLine("\nSelected '" + choice + "' does not exist, please try again.");
                    Example();
                    break;
            }
        }

        public void DictionaryTest()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            Console.WriteLine("\nAdd four keys and values");

            Console.Write("Key: ");
            string key1 = Console.ReadLine();

            Console.Write("Value: ");
            string value1 = Console.ReadLine();

            Console.Write("Key: ");
            string key2 = Console.ReadLine();

            Console.Write("Value: ");
            string value2 = Console.ReadLine();

            Console.Write("Key: ");
            string key3 = Console.ReadLine();

            Console.Write("Value: ");
            string value3 = Console.ReadLine();

            Console.Write("Key: ");
            string key4 = Console.ReadLine();

            Console.Write("Value: ");
            string value4 = Console.ReadLine();

            dictionary.Add(key1, value1);
            dictionary.Add(key2, value2);
            dictionary.Add(key3, value3);
            dictionary.Add(key4, value4);

            Console.WriteLine("\nProduct list:");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Rank(key):{item.Key}, Product(value):{item.Value}");
            }

            Console.Write("\nChoose action:\n" +
           "r-remove product based on rank\n" +
           "d-deleted everything from list\n" +
           "q-Quit\n" +
           "Select: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "r":
                    Console.Write("\nPlease provide rank to be removed: ");
                    string removeProduct = Console.ReadLine();

                    dictionary.Remove(removeProduct);

                    Console.WriteLine("\nCurrent list:");
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine($"Rank(key):{item.Key}, Product(value):{item.Value}");
                    }
                    Example();
                    break;

                case "d":
                    dictionary.Clear();
                    Console.WriteLine("\nList has been cleared");
                    Example();
                    break;

                case "q":
                    Example();
                    break;

                default:
                    Console.WriteLine("\nSelected '" + choice + "' does not exist, please try again.");
                    Example();
                    break;
            }
        }
    }
}
