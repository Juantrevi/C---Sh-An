using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class2.Models
{
    public class Cat : Animal
    {
        public override string type => "Cat";
        public override void move()
        {
            Console.WriteLine($"The {type} moves Walking");
        }
        public override void sound()
        {
            Console.WriteLine($"The {type} makes Meow");
        }
    }
}
