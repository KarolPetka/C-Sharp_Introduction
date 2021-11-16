using System;
namespace WDP_Projekt
{
    public class ClassInheritanceInterface
    {
        public void Example()
        {
            Console.Write("\nList of Class functionalities:\n" +
                "1. Class\n" +
                "2. Inheritance\n" +
                "3. Interface\n" +
                "q. Quit" +
                "\nPlease select what You would like to test (select 1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DogTest dogTest = new DogTest();
                    dogTest.Test();
                    break;

                case "2":
                    InheritanceTest inheritanceTest = new InheritanceTest();
                    inheritanceTest.Test();
                    break;

                case "3":
                    InterfaceTest interfaceTest = new InterfaceTest();
                    interfaceTest.Test();
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
    }

    class Dog
    {
        public string name;
        public string color;
        public string sound;

        public void Introduction(string name, string color, string sound)
        {
            Console.WriteLine("\nHi, I am dog, my name is " + name + ", my fure is " + color + ", and I go " + sound + "!");
            ClassInheritanceInterface classInheritanceInterface = new ClassInheritanceInterface();
            classInheritanceInterface.Example();
        }
    }

    class DogTest
    {
        public void Test()
        {
            Dog dog = new Dog();

            Console.Write("\nSelect dog name: ");
            dog.name = Console.ReadLine();

            Console.Write("Select dog color: ");
            dog.color = Console.ReadLine();

            Console.Write("Select dog sound: ");
            dog.sound = Console.ReadLine();

            dog.Introduction(dog.name, dog.color, dog.sound);
        }
    }

    class Father
    {
        public string eyeColor;
        public string hairColor;
        public string hobby;
    }

    class Child : Father
    {
        public string name;

        public void Introduction(string name, string eyeColor, string hairColor, string hobby)
        {
            Console.WriteLine("\nHi, my name is " + name + ", my eyes are " + eyeColor + ", and hair are " + hairColor + ", my hobby is " + hobby);
            ClassInheritanceInterface classInheritanceInterface = new ClassInheritanceInterface();
            classInheritanceInterface.Example();
        }
    }

    class InheritanceTest
    {
        public void Test()
        {
            Child child = new Child();

            Console.Write("\nSelect child name: ");
            child.name = Console.ReadLine();

            Console.Write("\nSelect child eye color: ");
            child.eyeColor = Console.ReadLine();

            Console.Write("\nSelect child hair color: ");
            child.hairColor = Console.ReadLine();

            Console.Write("\nSelect child hobby: ");
            child.hobby = Console.ReadLine();

            child.Introduction(child.name, child.eyeColor, child.hairColor, child.hobby);
        }
    }

    interface IProduct
    {
        string name { get; set; }
        string descrption { get; set; }

        void Commercial();
    }

    class Shoes : IProduct
    {
        public string name { get; set; }
        public string descrption { get; set; }

        public void Commercial()
        {
            Console.WriteLine("\nNew " + name + " shoes! They are " + descrption + ". Go buy them now!");
        }

        public Shoes (string name, string descrption)
        {
            this.name = name;
            this.descrption = descrption;
        }
    }

    class InterfaceTest
    {
        public void Test()
        {
            Console.Write("\nProvide shoes name: ");
            string name = Console.ReadLine();

            Console.Write("Provide shoes descrption: ");
            string descrption = Console.ReadLine();

            Shoes shoes = new Shoes(name, descrption);
            shoes.Commercial();

            ClassInheritanceInterface classInheritanceInterface = new ClassInheritanceInterface();
            classInheritanceInterface.Example();
        }
    }

}
