using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad
{
    public class CowFerm : Ferm
    {
        private static List<Cow> _cows;
        private int _priceFerm;
        private int _maxCountAnimals;


        public List<Animal> Animals
        {
            get
            {
                return CowToAnim(_cows);
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
                _priceFerm = 175;
            }
        }
        public override string GetInfo()
        {
            return $"Вместимость загона: {MaxCountAnimals}";
        }


        public CowFerm(int priceFrem, List<Cow> cows)
        {
            PriceFerm = priceFrem;
            Cows = cows;
        }
        public static List<Cow> Cows { get => _cows; set => _cows = value; }
        public static List<Animal> CowToAnim(List<Cow> cows)
        {
            List<Animal> animals = new List<Animal>();
            foreach (var cow in cows)
            {
                animals.Add(cow);
            }
            return animals;
        }
    }
}
