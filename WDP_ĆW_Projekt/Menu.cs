using System;
namespace WDP_Projekt
{
    public class Menu
    {

        public void Greeting()
        {
            Console.Write("******************************\n" +
                          "*                            *\n" +
                          "*   WELCOME TO WDP PROJECT   *\n" +
                          "*                            *\n" +
                          "******************************\n");
            Switches();
        }

        public void Switches()
        {
            Console.Write("\nList of Project functionalities:\n" +
                "1. Exception handling - try-catch-finally\n" +
                "2. Passing parameters by value vs by reference\n" +
                "3. Class, Inheritance, Interface\n" +
                "4. Collections: List<T>, Queue<T>, Stack<T>\n" +
                "5. Collections: SortedList<K, V>, Dictionary<K, V>\n" +
                "\nPlease select what You would like to test (select 1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExceptionHandling exceptionHandling = new ExceptionHandling();
                    exceptionHandling.Example();
                    break;

                case "2":
                    PassingParameters passingParameters = new PassingParameters();
                    passingParameters.Example();
                    break;

                case "3":
                    ClassInheritanceInterface classInheritanceInterface = new ClassInheritanceInterface();
                    classInheritanceInterface.Example();
                    break;

                case "4":
                    ListQueueStack listQueueStack = new ListQueueStack();
                    listQueueStack.Example();
                    break;

                case "5":
                    SortedListDictionary sortedListDictionary = new SortedListDictionary();
                    sortedListDictionary.Example();
                    break;

                default:
                    Console.WriteLine("\nSelected '" + choice + "' does not exist, please try again.");
                    Switches();
                    break;
            }
        }
    }
}
