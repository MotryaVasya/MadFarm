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
        public override bool Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public override int Eat
        {
            get { return _eat; }
            set { _eat = value; }
        }
        public override int PriceBuy
        {
            get { return _priceBuy; }
            set { _priceBuy = value; }
        }
        public override int PriceSell
        {
            get { return _priceSell; }
            set { _priceSell = value; }
        }
        public override string GetInfo()
        {
            return $"Здоровье: {_health}\nПитание: {_eat}\nЦена покупки: {_priceBuy}\nЦена продажи: {_priceSell}\n";
        }       
    }
}
