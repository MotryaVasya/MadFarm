using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class PigFerm : Ferm
    {
        private List<Pig> pigs;
        private int _priceFerm;
        private int max_count_animals;

        public override int _priceFerm => PriceFerm;
        public override List<Animal> _animals => PigkToAnim();
        public override int _max_count_animals => max_count_animals;

        public PigFerm(int priceFrem, List<Animal> animals, int maxcountanimals)
        {
            PriceFrem = priceFrem;
            _animals = animals;
            _max_count_animals = maxcountanimals;
        }

        public override string GetInfo()
        {
            return $"Вместимость загона: {_max_count_animals}";
        }
        private List<Animal> PigkToAnim()
        {
            List<Animal> animals = new List<Animal>();
            foreach (var pig in pigs)
            {
                animals.Add(pig);
            }
            return animals;
        }
    }
}
