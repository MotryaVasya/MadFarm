using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class CowFerm : IFerm
    {
        private List<Cow> _animals;
        private int _max_count_animals;
        public int max_count_animals => _max_count_animals;

        public List<IAnimal> animals { get => _animals; }
    }
}
