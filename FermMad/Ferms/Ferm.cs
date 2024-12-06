using System.Collections.Generic;

namespace FermMad
{
    public abstract class Ferm
    {
        public int Id { get; set; }
        public abstract  int PriceFerm { get; set; }
        public List<Animal> Animals { get; set; }
        public abstract int MaxCountAnimals { get; set; }
        public abstract string GetInfo();
    }
}