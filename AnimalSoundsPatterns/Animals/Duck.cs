using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSoundsPatterns.Animals
{
    public sealed class Duck : IAnimal 
    {
        public string Type => "Duck";
        public string Sound => "quack";

    }
}
