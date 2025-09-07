using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSoundsPatterns.Animals
{
    public sealed class Cow : IAnimal
    {
        public string Type => "Cow";
        public string Sound => "moo";
    }
}
