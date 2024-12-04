using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class Pig : IAnimal
    {
        private bool _health;
        private int _eat;
        private int _priceBuy;
        private int _priceSell;

        public Pig(bool health, int eat, int priceBuy, int priceSell)
        {
            _health = health;
            _eat = eat;
            _priceBuy = priceBuy;
            _priceSell = priceSell;
        }

        public bool Health { get => _health; }
        public int Eat { get => _eat; }
        public int PriceBuy { get => _priceBuy; }
        public int PriceSell { get => _priceSell; }
    }
}
