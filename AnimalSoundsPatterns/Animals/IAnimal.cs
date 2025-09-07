using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSoundsPatterns.Animals
{
    public interface IAnimal
    {
        string Type { get;  }
        string Sound { get; }
    }
}
