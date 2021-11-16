using System;
namespace WDP_Projekt
{
    public class PassingParameters
    {
        public void Example()
        {
            try
            {
                Console.WriteLine("\nSelect number to increment by value and by reference");
                Console.Write("Provide number: ");

                int numberByValue = Convert.ToInt32(Console.ReadLine());
                int numberByReference = numberByValue;

                byValue(numberByValue);
                Console.WriteLine("\nYour number incremented by value is: " + numberByValue);

                byReference(ref numberByReference);
                Console.WriteLine("\nYour number incremented by reference is: " + numberByReference);

                do
                {
                    string choice = "";
                    Console.WriteLine("\nWould You like to try again?\n" +
                        "y = yes\n" +
                        "q = quit\n");
                    Console.Write("Select: ");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "y":
                            Example();
                            break;
                        case "q":
                            Menu menu = new Menu();
                            menu.Switches();
                            break;
                    }
                } while (true);
            }
            catch
            {
                Console.WriteLine("Something went wrong, please try again");
                Example();
            }
        }

        static void byValue(int number)
        {
            number++;
        }
        static void byReference(ref int number)
        {
            number++;
        }
    }
}
