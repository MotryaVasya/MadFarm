using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Security.Cryptography.X509Certificates;
>>>>>>> 875ec63c83e330e9c55a50e066d602d71a081aa2
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
<<<<<<< HEAD
    public interface IAnimal
    {
        bool Health { get; }
        int Eat { get; }
        int PriceBuy { get; }
        int PriceSell { get; }
=======
    public abstract class Animal
    {
        abstract public bool Health { get; }
        abstract public int Eat { get; }
        abstract public int PriceBuy { get; }
        abstract public int PriceSell { get; }
        public abstract string GetInfo(); 
>>>>>>> 875ec63c83e330e9c55a50e066d602d71a081aa2
    }
}
