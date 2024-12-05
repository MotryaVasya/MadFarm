using System.Collections.Generic;

namespace FermMad
{
    public abstract class Ferm
    {
        public abstract List<Animal> _animals { get; }
        public abstract int _max_count_animals { get; }

        public List<Animal> animals { get => _animals; }

        public abstract string GetInfo();


    }
}