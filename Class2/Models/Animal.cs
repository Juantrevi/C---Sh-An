using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Models
{
    public abstract class Animal
    {
        public abstract string type { get; }
        public abstract void sound();
        public abstract void move();
    }
}
