using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public interface IAnimal
    {
        bool Health { get; }
        int Eat { get; }
        int PriceBuy { get; }
        int PriceSell { get; }
    }
}
