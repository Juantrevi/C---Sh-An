using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Models
{
    public class Batman : Superheroe
    {
        public override string name => "Batman";

        public override void Fly()
        {
            Console.WriteLine($"{name} is Flying without powers");
        }
    }
}
