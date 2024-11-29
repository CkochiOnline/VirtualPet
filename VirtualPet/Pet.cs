using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; private set; }
        public int Hunger { get; private set; }
        public int Hapiness { get; private set; }

        public Pet(string name) // constructor.
        {
            Name = name;
            Hunger = 0;
            Hapiness = 0;
        }
        public void Feed() // feeding pet.
        {
            Hunger += 10; // increas hungry level by 10.
            Console.WriteLine($"{Name} has been fed, hunger level {Hunger}"); // message for food level.
        }
        public void Play() // playe with pet.
        {
            Hapiness += 10; // increase hapiness level by 10.
            Console.WriteLine($"{Name} is playing, Hapiness level is {Hapiness}"); // message for food level.
        }
        public void CheckStatus() // check status for pet. - Hunger and Hapiness.
        {
            Console.WriteLine($"{Name}'s status - Hunger: {Hunger} - Hapiness: {Hapiness}"); // Gives a message.
        }

    }
}
