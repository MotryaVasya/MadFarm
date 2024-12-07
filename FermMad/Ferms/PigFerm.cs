using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class PigFerm : Ferm
    {
        private static List<Pig> _pigs;
        private int _priceFerm;
        private int _maxCountAnimals;


        public List<Animal> Animals
        {
            get
            {
                return PigToAnim(_pigs);
            }
            set
            {
                Animals = value;
            }
        }
        public override int MaxCountAnimals
        {
            get
            {
                return _maxCountAnimals;
            }
            set
            {
                _maxCountAnimals = 1000000;
            }

        }
        public override int PriceFerm
        {
            get
            {
                return _priceFerm;
            }
            set
            {
                _priceFerm = 150;
            }
        }
        public override string GetInfo()
        {
            return $"Вместимость загона: {MaxCountAnimals}";
        }


        public PigFerm(int priceFrem, List<Pig> pigs)
        {
            PriceFerm = priceFrem;
            Pigs = pigs;
        }
        public static List<Pig> Pigs { get => _pigs; set => _pigs = value; }
        public static List<Animal> PigToAnim(List<Pig> pigs)
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
