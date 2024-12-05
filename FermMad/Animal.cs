using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Cryptography;

using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public abstract class Animal
    {
        abstract public bool Health { get; }
        abstract public int Eat { get; }
        abstract public int PriceBuy { get; }
        abstract public int PriceSell { get; }
        public abstract string GetInfo(); 
    }
}
