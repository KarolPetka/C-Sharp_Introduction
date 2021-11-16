using System;
namespace WDP_Projekt
{
    public class ExceptionHandling
    {
        public void Example()
        {
            try
            {
                Console.WriteLine("\nTRY:\n" +
                                  "Provide numbers to be divded\n");

                Console.Write("x=");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("y=");
                int y = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Your result is: " + x / y);
            }
            catch(Exception e)
            {
                Console.WriteLine("CATCH:\n" +
                    "\n" + e.Message);
            }
            finally
            {
                do
                {
                    Console.WriteLine("\nFINALLY:\n" +
                        "\nWould You like to try again?\n" +
                        "y = yes\n" +
                        "q = quit\n");
                    Console.Write("Select: ");
                    string choice = Console.ReadLine();

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

        }
    }
}
