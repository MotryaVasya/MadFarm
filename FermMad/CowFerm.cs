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
        public override List<Animal> _animals => CowkToAnim();
        private int max_count_animals;
        public override int _max_count_animals => max_count_animals;
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
