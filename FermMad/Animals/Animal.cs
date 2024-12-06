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
        public int Id { get; set; }
        abstract public bool Health { get; set; }
        abstract public int Eat { get; set; }
        abstract public int PriceBuy { get; set; }
        abstract public int PriceSell { get; set; }
        public abstract string GetInfo();
    }
}
