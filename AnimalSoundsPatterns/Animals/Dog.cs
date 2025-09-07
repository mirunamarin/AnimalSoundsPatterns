using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSoundsPatterns.Animals
{
    public sealed class Dog : IAnimal
    {
        public string Type => "Dog";
        public string Sound => "woof";
    }
}
