using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class ChickenFerm : Ferm
    {
        private List<Chicken> chickens;
        private int _priceFerm;
        private int max_count_animals;
        
        
        public override int _priceFerm => PriceFerm;
        public override List<Animal> _animals => ChickToAnim();
        public override int _max_count_animals => max_count_animals;

        public ChickenFerm(int priceFrem,List<Animal> animals, int maxcountanimals)
        {
            PriceFrem = priceFrem;
            _animals = animals;
            _max_count_animals = maxcountanimals;
        }
        public override string GetInfo()
        {
            return $"Вместимость загона: {_max_count_animals}";
        }
        private List<Animal> ChickToAnim()
        {
            List<Animal> animals = new List<Animal>();
            foreach (var chik in chickens)
            {
                animals.Add(chik);
            }
            return animals;
        }
    }
}
