using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class Chicken : Animal
    {
        private bool _health;
        private int _eat;
        private int _priceBuy;
        private int _priceSell;
        public override bool Health => _health;
        public override int Eat => _eat;
        public override int PriceBuy => _priceBuy;
        public override int PriceSell => _priceSell;
        public override string GetInfo()
        {
            return $"Здоровье: {_health}\nПитание: {_eat}\nЦена покупки: {_priceBuy}\nЦена продажи: {_priceSell}\n";
        }       
    }
}
