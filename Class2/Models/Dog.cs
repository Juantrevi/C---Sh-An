using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Models
{
    public class Dog : Animal
    {
        public override string type => "Dog";
        public override void move()
        {
            Console.WriteLine($"The {type} moves Running");
        }
        public override void sound()
        {
            Console.WriteLine($"The {type} sound is Woof");
        }
    }
}
