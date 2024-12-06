using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class CowFerm : Ferm
    {
        private List<Cow> cows;
        private int _priceFerm;
        private int max_count_animals;

        public override int _priceFerm => PriceFerm;
        public override List<Animal> _animals => CowkToAnim();
        public override int _max_count_animals => max_count_animals;

        public CowFerm(int priceFrem, List<Animal> animals, int maxcountanimals)
        {
            PriceFrem = priceFrem;
            _animals = animals;
            _max_count_animals = maxcountanimals;
        }

        public override string GetInfo()
        {
            return $"Вместимость загона: {_max_count_animals}";
        }
        private List<Animal> CowkToAnim()
        {
            List<Animal> animals = new List<Animal>();
            foreach (var cowk in cows)
            {
                animals.Add(cowk);
            }
            return animals;
        }
    }
}
