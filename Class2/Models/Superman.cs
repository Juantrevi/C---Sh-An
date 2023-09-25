using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Models
{
    public class Superman : Superheroe
    {
        public override string name => "Superman";

        public override void Fly()
        {
            Console.WriteLine($"{name} is Flying!");
        }
    }
}
