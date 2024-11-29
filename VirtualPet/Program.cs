namespace VirtualPet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is yout pets name?");
            string petName = Console.ReadLine();
            Pet myPet = new Pet(petName);

            while (true) 
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Feed your pet.");
                Console.WriteLine("2. Play with your pet.");
                Console.WriteLine("3. Check if your pet is hungry.");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("Enter your choice.");
                string choice = Console.ReadLine();

                switch (choice) 
                {
                    case "1":
                        myPet.Feed();
                        break;
                    case "2":
                        myPet.Play(); 
                        break;
                    case "3":
                        myPet.CheckStatus(); 
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            }
        }
    }
}
