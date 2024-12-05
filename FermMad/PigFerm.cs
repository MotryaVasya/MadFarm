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

        public override List<Animal> _animals => PigkToAnim();


        private int max_count_animals;
        public override int _max_count_animals => max_count_animals;

        public override string GetInfo()
        {
            return $"Вместимость загона: {_max_count_animals}";
        }

        private List<Animal> PigkToAnim()
        {
            List<Animal> animals = new List<Animal>();
            foreach (var pigk in pigs)
            {
                animals.Add(pigk);
            }
            return animals;
        }
    }
}
