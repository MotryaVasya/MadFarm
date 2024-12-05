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

        public override List<Animal> _animals => ChickToAnim();


        private int max_count_animals;
        public override int _max_count_animals => max_count_animals;

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
