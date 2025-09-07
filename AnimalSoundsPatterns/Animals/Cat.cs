using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSoundsPatterns.Animals
{
    public sealed class Cat : IAnimal
    {
        public string Type => "Cat";
        public string Sound => "meow";
    }
}
